using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;
using System.IO;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;

namespace MMHCollegeSalaryMaker
{
    public partial class frm_mmh_clg_salary_maker : Form
    {
        /* following are the position of 
         * cell number in the salery 
         * excel sheet
         */
        int CELL_POS_INDX;
        int CELL_POS_NAME;
        int CELL_POS_PAN;
        int CELL_POS_DESIG;
        int CELL_POS_BASIC_PAY;
        int CELL_POS_GRADE_PAY;
        int CELL_POS_DA;
        int CELL_POS_HRA;
        int CELL_POS_CCA;
        int CELL_POS_OTHER_FP;
        int CELL_POS_GROSS_SALARY;
        int CELL_POS_PF_GPF;
        int CELL_POS_GPF_LOAN;
        int CELL_POS_GLIP;
        int CELL_POS_INC_TAX;
        int CELL_POS_BANK_LOAN;
        int CELL_POS_RECOVERY;
        int CELL_POS_TOTAL_DEDUCT;
        int CELL_POS_NET_SALARY;

        int indx;
        string name;
        string pancard;
        string desig;
        int basic_pay;
        int grade_pay;
        int da;
        int hra;
        int cca;
        int other_fp;
        int gross_salary;
        int pf_gpf;
        int gpf_loan;
        int glip;
        int inc_tax;
        int bank_loan;
        int recovery;
        int total_deduct;
        int net_salary;
        string gender;
        string department;
        string isPermanent;
        DateTime today;
        Excel.Application xlApp;
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;
        Excel.Range xlRange;
        public frm_mmh_clg_salary_maker()
        {
            InitializeComponent();
        }

        private void frm_mmh_clg_salary_maker_Load(object sender, EventArgs e)
        {
            CELL_POS_INDX = Convert.ToInt32(MMHCollegeSalaryMaker.Properties.Resources.rsc_string_cell_pos_indx);//1;
            CELL_POS_NAME = Convert.ToInt32(MMHCollegeSalaryMaker.Properties.Resources.rsc_string_cell_pos_name);//2;
            CELL_POS_PAN = Convert.ToInt32(MMHCollegeSalaryMaker.Properties.Resources.rsc_string_cell_pos_pan);//3;
            CELL_POS_DESIG = Convert.ToInt32(MMHCollegeSalaryMaker.Properties.Resources.rsc_string_cell_pos_designation);//5;
            CELL_POS_BASIC_PAY = Convert.ToInt32(MMHCollegeSalaryMaker.Properties.Resources.rsc_string_cell_pos_basic_pay);//7;
            CELL_POS_GRADE_PAY = Convert.ToInt32(MMHCollegeSalaryMaker.Properties.Resources.rsc_string_cell_pos_grade_pay);//8;
            CELL_POS_DA = Convert.ToInt32(MMHCollegeSalaryMaker.Properties.Resources.rsc_string_cell_pos_da);//9;
            CELL_POS_HRA = Convert.ToInt32(MMHCollegeSalaryMaker.Properties.Resources.rsc_string_cell_pos_hra);//10;
            CELL_POS_CCA = Convert.ToInt32(MMHCollegeSalaryMaker.Properties.Resources.rsc_string_cell_pos_cca);//11;
            CELL_POS_OTHER_FP = Convert.ToInt32(MMHCollegeSalaryMaker.Properties.Resources.rsc_string_cell_pos_other_fp);//6;
            CELL_POS_GROSS_SALARY = Convert.ToInt32(MMHCollegeSalaryMaker.Properties.Resources.rsc_string_cell_pos_gross_salary);//12;
            CELL_POS_PF_GPF = Convert.ToInt32(MMHCollegeSalaryMaker.Properties.Resources.rsc_string_cell_pos_gpf);//14;
            CELL_POS_GPF_LOAN = Convert.ToInt32(MMHCollegeSalaryMaker.Properties.Resources.rsc_string_cell_pos_gpf_loan);//15;
            CELL_POS_GLIP = Convert.ToInt32(MMHCollegeSalaryMaker.Properties.Resources.rsc_string_cell_pos_glip);//16;
            CELL_POS_INC_TAX = Convert.ToInt32(MMHCollegeSalaryMaker.Properties.Resources.rsc_string_cell_pos_income_tax);//13;
            CELL_POS_BANK_LOAN = Convert.ToInt32(MMHCollegeSalaryMaker.Properties.Resources.rsc_string_cell_pos_bank_loan);//17;
            CELL_POS_RECOVERY = Convert.ToInt32(MMHCollegeSalaryMaker.Properties.Resources.rsc_string_cell_pos_recovery);//17;
            CELL_POS_TOTAL_DEDUCT = Convert.ToInt32(MMHCollegeSalaryMaker.Properties.Resources.rsc_string_cell_pos_total_deduction);//18;
            CELL_POS_NET_SALARY = Convert.ToInt32(MMHCollegeSalaryMaker.Properties.Resources.rsc_string_cell_pos_net_salary);//19;

            today = DateTime.Today;
            this.num_up_dwn_year.Value = today.Year;
            this.cmb_box_month.SelectedIndex = today.Month;
            this.btn_src_file_path.Text = "Select Salary File" ;
            this.btn_dest_path.Text = "Select Out Path";
            txtbx_src_file_path.Text = "";
            xlApp = new Excel.Application();
            this.cmb_box_sheet_number.Text = "--- Select Salary File First ---";
            this.cmb_box_serial_number.Text = "--- Select Sheet First ---";

            
        }

        private void btn_src_file_path_Click(object sender, EventArgs e)
        {
            if (ofd_mmh_clg_slry_mkr.ShowDialog() == DialogResult.OK)
            {
                this.btn_src_file_path.Text = ofd_mmh_clg_slry_mkr.FileName;
                try
                {
                    xlWorkBook.Close(false, null, null);
                    this.cmb_box_sheet_number.Items.Clear();
                }
                catch (Exception)
                { }
                xlWorkBook = xlApp.Workbooks.Open(this.btn_src_file_path.Text, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                this.cmb_box_sheet_number.Items.Add("Select Sheet");
                foreach(Excel.Worksheet worksheet in xlWorkBook.Worksheets)
                {
                    this.cmb_box_sheet_number.Items.Add(worksheet.Name);
                }
                this.cmb_box_sheet_number.Text = "Select Sheet";
                this.cmb_box_sheet_number.SelectedIndex = 0;
                this.cmb_box_serial_number.Text = "--- Select Sheet First ---";
            }
        }

        private void btn_dest_path_Click(object sender, EventArgs e)
        {
            if (fbd_mmh_clg_slry_mkr.ShowDialog() == DialogResult.OK)
            {
                this.btn_dest_path.Text = fbd_mmh_clg_slry_mkr.SelectedPath + "\\";
            }
        }

        private void btn_create_slry_slip_Click(object sender, EventArgs e)
        {
            string relationship;
            if(this.btn_src_file_path.Text == "Select Salary File")
            {
                MessageBox.Show("Select Salary file first", "Salary File Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 
            if (this.btn_dest_path.Text == "Select Out Path")
            {
                MessageBox.Show("Select out path where files to be saved", "Destination Path Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.cmb_box_sheet_number.Text == "Select Sheet")
            {
                MessageBox.Show("Sheet number missing.\nSelect Sheet of the file first", "Sheet not selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.cmb_box_serial_number.Text == "Select Name")
            {
                MessageBox.Show("Person name missing.\nSelect name from list first", "Person details Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((this.cmb_box_permanent.Text == "Permanent") || (this.cmb_box_gender.Text == "Select Gender") || (this.txtbx_src_file_path.Text == "_______________"))
            {
                MessageBox.Show("One or more of optional fields are not changed.\nOutput Salary slip file might not look nice.", "Default value not changed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            string cmbboxselectedtext = this.cmb_box_serial_number.SelectedItem.ToString();
            string index_to_check_str = string.Empty;
            for (int tmpctr = 0; tmpctr < cmbboxselectedtext.Length; tmpctr++)
            {
                if (Char.IsDigit(cmbboxselectedtext[tmpctr]))
                {
                    index_to_check_str += cmbboxselectedtext[tmpctr];
                }
                else
                {
                    break;
                }
            }

            int index_to_check = Convert.ToInt32(index_to_check_str);
            
            string month = this.cmb_box_month.Text + " " + this.num_up_dwn_year.Value.ToString();
            string date_str;

            System.Double prgsbrCntr = 0.00;

            this.prgsbr_mmh_slry_mkr.Maximum = xlRange.Rows.Count;
            this.prgsbr_mmh_slry_mkr.Value = 0;

            /* below this portion is for creating salary slip */
            date_str = today.ToString("d");
            XImage image = MMHCollegeSalaryMaker.Properties.Resources.rsc_image_mmh_logo;
            int rCnt = 0; 
            for (rCnt = 1; rCnt <= xlRange.Rows.Count; rCnt++)
            {
                indx = -1 ;
                Object value;
                string filepath;
                string fileContent;

                value = (xlRange.Cells[rCnt, CELL_POS_INDX] as Excel.Range).Value2;
                if (value == null)
                {
                    continue;
                }
                if (value.GetType().ToString() == prgsbrCntr.GetType().ToString())
                {
                    indx = Convert.ToInt32(value);
                }
                if (indx < 1)
                {
                    continue;
                }
                if (indx != index_to_check)
                {
                    continue;
                }
                value = (xlRange.Cells[rCnt, CELL_POS_NAME] as Excel.Range).Value2;
                if (value == null)
                { 
                    /* name cannot be null */
                    continue;
                }
                else if (value.GetType().ToString() == prgsbrCntr.GetType().ToString())
                {
                    /* name field cannot be double too*/
                    continue;
                }
                else
                { 
                    /* copy name string to name variable*/
                    name = (string)value;
                }
                value = (xlRange.Cells[rCnt, CELL_POS_PAN] as Excel.Range).Value2;
                if (value == null)
                {
                    /* name cannot be null */
                    pancard = " ";
                }
                else if (value.GetType().ToString() == prgsbrCntr.GetType().ToString())
                {
                    /* name field cannot be double too*/
                    pancard = " ";
                }
                else
                {
                    /* copy name string to name variable*/
                    pancard = (string)value;
                }

                relationship = indx.ToString() + "_" + name + "(" + pancard + ")";
                if (relationship == this.cmb_box_serial_number.SelectedItem.ToString())
                { }
                else
                {
                    continue;
                }
                value = (xlRange.Cells[rCnt, CELL_POS_DESIG] as Excel.Range).Value2;
                if (value == null)
                {
                    /* if desig field is null then copy ______ */
                    desig = "________";
                }
                else if (value.GetType().ToString() == prgsbrCntr.GetType().ToString())
                {
                    /* if desig field is double then copy ______*/
                    desig = "________";
                }
                else
                {
                    /* copy name string to name variable*/
                    desig = (string)value;
                }
                value = (xlRange.Cells[rCnt, CELL_POS_OTHER_FP] as Excel.Range).Value2;
                if (value == null)
                {
                    other_fp = 0;
                }
                else if (value.GetType().ToString() == prgsbrCntr.GetType().ToString())
                {
                    other_fp = Convert.ToInt32(value);
                }
                else
                {
                    other_fp = 0;
                }
                value = (xlRange.Cells[rCnt, CELL_POS_BASIC_PAY ] as Excel.Range).Value2;
                if (value == null)
                {
                    basic_pay = 0;
                }
                else if (value.GetType().ToString() == prgsbrCntr.GetType().ToString())
                {
                    basic_pay = Convert.ToInt32(value);
                }
                else
                {
                    basic_pay = 0;
                }
                value = (xlRange.Cells[rCnt, CELL_POS_GRADE_PAY] as Excel.Range).Value2;
                if (value == null)
                {
                    grade_pay = 0;
                }
                else if (value.GetType().ToString() == prgsbrCntr.GetType().ToString())
                {
                    grade_pay = Convert.ToInt32(value);
                }
                else
                {
                    grade_pay = 0;
                }
                value = (xlRange.Cells[rCnt, CELL_POS_DA] as Excel.Range).Value2;
                if (value == null)
                {
                    da = 0;
                }
                else if (value.GetType().ToString() == prgsbrCntr.GetType().ToString())
                {
                    da = Convert.ToInt32(value);
                }
                else
                {
                    da = 0;
                }
                value = (xlRange.Cells[rCnt, CELL_POS_HRA] as Excel.Range).Value2;
                if (value == null)
                {
                    hra = 0;
                }
                else if (value.GetType().ToString() == prgsbrCntr.GetType().ToString())
                {
                    hra = Convert.ToInt32(value);
                }
                else
                {
                    hra = 0;
                }
                value = (xlRange.Cells[rCnt, CELL_POS_CCA] as Excel.Range).Value2;
                if (value == null)
                {
                    cca = 0;
                }
                else if (value.GetType().ToString() == prgsbrCntr.GetType().ToString())
                {
                    cca = Convert.ToInt32(value);
                }
                else
                {
                    cca = 0;
                }
                value = (xlRange.Cells[rCnt, CELL_POS_GROSS_SALARY] as Excel.Range).Value2;
                if (value == null)
                {
                    gross_salary = 0;
                }
                else if (value.GetType().ToString() == prgsbrCntr.GetType().ToString())
                {
                    gross_salary = Convert.ToInt32(value);
                }
                else
                {
                    gross_salary = 0;
                }
                value = (xlRange.Cells[rCnt, CELL_POS_INC_TAX] as Excel.Range).Value2;
                if (value == null)
                {
                    inc_tax = 0;
                }
                else if (value.GetType().ToString() == prgsbrCntr.GetType().ToString())
                {
                    inc_tax = Convert.ToInt32(value);
                }
                else
                {
                    inc_tax = 0;
                }
                value = (xlRange.Cells[rCnt, CELL_POS_PF_GPF] as Excel.Range).Value2;
                if (value == null)
                {
                    pf_gpf = 0;
                }
                else if (value.GetType().ToString() == prgsbrCntr.GetType().ToString())
                {
                    pf_gpf = Convert.ToInt32(value);
                }
                else
                {
                    pf_gpf = 0;
                }
                value = (xlRange.Cells[rCnt, CELL_POS_GPF_LOAN] as Excel.Range).Value2;
                if (value == null)
                {
                    gpf_loan = 0;
                }
                else if (value.GetType().ToString() == prgsbrCntr.GetType().ToString())
                {
                    gpf_loan = Convert.ToInt32(value);
                }
                else
                {
                    gpf_loan = 0;
                }
                value = (xlRange.Cells[rCnt, CELL_POS_GLIP] as Excel.Range).Value2;
                if (value == null)
                {
                    glip = 0;
                }
                else if (value.GetType().ToString() == prgsbrCntr.GetType().ToString())
                {
                    glip = Convert.ToInt32(value);
                }
                else
                {
                    glip = 0;
                }
                value = (xlRange.Cells[rCnt, CELL_POS_BANK_LOAN] as Excel.Range).Value2;
                if (value == null)
                {
                    bank_loan = 0;
                }
                else if (value.GetType().ToString() == prgsbrCntr.GetType().ToString())
                {
                    bank_loan = Convert.ToInt32(value);
                }
                else
                {
                    bank_loan = 0;
                }
                value = (xlRange.Cells[rCnt, CELL_POS_RECOVERY] as Excel.Range).Value2;
                if (value == null)
                {
                    recovery = 0;
                }
                else if (value.GetType().ToString() == prgsbrCntr.GetType().ToString())
                {
                    recovery = Convert.ToInt32(value);
                }
                else
                {
                    recovery = 0;
                }
                value = (xlRange.Cells[rCnt, CELL_POS_TOTAL_DEDUCT] as Excel.Range).Value2;
                if (value == null)
                {
                    total_deduct = 0;
                }
                else if (value.GetType().ToString() == prgsbrCntr.GetType().ToString())
                {
                    total_deduct = Convert.ToInt32(value);
                }
                else
                {
                    total_deduct = 0;
                }
                value = (xlRange.Cells[rCnt, CELL_POS_NET_SALARY] as Excel.Range).Value2;
                if (value == null)
                {
                    net_salary = 0;
                }
                else if (value.GetType().ToString() == prgsbrCntr.GetType().ToString())
                {
                    net_salary = Convert.ToInt32(value);
                }
                else
                {
                    net_salary = 0;
                }
                //gender = this.cmb_box_gender.SelectedItem.ToString();
                //isPermanent = this.cmb_box_permanent.SelectedItem.ToString();
                gender = this.cmb_box_gender.Text;
                isPermanent = this.cmb_box_permanent.Text;
                department = this.txtbx_src_file_path.Text;
                
                /* writefile content to file */
                PdfDocument document = new PdfDocument();
                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);
                XFont font = new XFont("Times New Roman", 11, XFontStyle.Regular);
                XFont headerFont = new XFont("Times New Roman", 20, XFontStyle.Underline);
                XTextFormatter tf = new XTextFormatter(gfx);
                gfx.DrawImage(image, 40, 40);
                
                fileContent ="SALARY CERTIFICATE\n";
                //fileContent = fileContent +  "------------------------------------";
                XRect rect = new XRect(40, 200, 500, 40);
                gfx.DrawRectangle(XBrushes.White, rect);
                tf.Alignment = XParagraphAlignment.Center;
                tf.DrawString(fileContent, headerFont, XBrushes.Black, rect, XStringFormat.TopLeft);
                fileContent = "        This is to certify that " + name + ",";
                fileContent = fileContent +  " " + desig + ", dept. of " + department + ",";
                if ( gender.Equals("MALE",StringComparison.OrdinalIgnoreCase) )
                {
                    fileContent = fileContent +  " is a " + isPermanent + " employee of this college.\n\n";
                    fileContent = fileContent + "Details of his salary for " + month + " as below:\n";
                }
                else if (gender.Equals("FEMALE", StringComparison.OrdinalIgnoreCase))
                {
                    fileContent = fileContent +  " is a " + isPermanent + " employee of this college.\n\n";
                    fileContent = fileContent + "Details of her salary for " + month + " as below:\n";
                }
                else
                {
                    fileContent = fileContent +  " is a " + isPermanent + " employee of this college.\n\n";
                    fileContent = fileContent + "Details of his/her salary for " + month + " as below:\n";
                }

                /*
                 * print personal information first
                 */
                rect = new XRect(90, 240, 400, 40);
                gfx.DrawRectangle(XBrushes.White, rect);
                tf.Alignment = XParagraphAlignment.Justify;
                tf.DrawString(fileContent, font, XBrushes.Black, rect, XStringFormat.TopLeft);
                
                //fileContent = "Month : " + month + "\n\n";
                /*fileContent = " EARNINGS\n";
                fileContent = fileContent + "-------------------------------------------\n";*/
                fileContent = "\nBasic Pay"
                    + "\nGrade Pay"
                    +  "\nD. A."
                    + "\nH. R. A."
                    +  "\nC. C. A."
                    + "\nOthers(FP)"
                    + "\n\nGross Salary";
                rect = new XRect(100, 310, 100, 120);
                gfx.DrawRectangle(XBrushes.White, rect);
                tf.Alignment = XParagraphAlignment.Left;
                tf.DrawString(fileContent, font, XBrushes.Black, rect, XStringFormat.TopLeft);

                fileContent = "\n : " + basic_pay.ToString()
                    + "\n : " + grade_pay.ToString()
                    + "\n : " + da.ToString()
                    + "\n : " + hra.ToString()
                    + "\n : " + cca.ToString()
                    + "\n : " + other_fp.ToString()
                    + "\n\n : " + gross_salary.ToString();
                rect = new XRect(180, 310, 100, 120);
                gfx.DrawRectangle(XBrushes.White, rect);
                tf.Alignment = XParagraphAlignment.Left;
                tf.DrawString(fileContent, font, XBrushes.Black, rect, XStringFormat.TopLeft);

                ///*fileContent = "-------------------------------------------\n";*/
                //fileContent = "\nGross Salary    : " + gross_salary.ToString() + "\n";
                ///*fileContent = fileContent +  "-------------------------------------------\n\n";*/
                //rect = new XRect(100, 420, 250, 40);
                //gfx.DrawRectangle(XBrushes.White, rect);
                //tf.Alignment = XParagraphAlignment.Left;
                //tf.DrawString(fileContent, font, XBrushes.Black, rect, XStringFormat.TopLeft);
                
                fileContent = "Deductions\n"
                    + "\n"
                    + "PF/GPF\n"
                    + "GPF Loan\n"
                    + "GLIP\n" 
                    + "Income Tax\n"
                    + "Other\n\n"
                    + "Total deductions";
                rect = new XRect(330, 310, 100, 90);
                gfx.DrawRectangle(XBrushes.White, rect);
                tf.Alignment = XParagraphAlignment.Left;
                tf.DrawString(fileContent, font, XBrushes.Black, rect, XStringFormat.TopLeft);

                fileContent = "\n"
                    + "\n : " + pf_gpf.ToString()
                    + "\n : " + gpf_loan.ToString()
                    + "\n : " + glip.ToString()
                    + "\n : " + inc_tax.ToString()
                    + "\n : " + (bank_loan + recovery).ToString()
                    + "\n\n : " + total_deduct.ToString();
                rect = new XRect(410, 310, 100, 120);
                gfx.DrawRectangle(XBrushes.White, rect);
                tf.Alignment = XParagraphAlignment.Left;
                tf.DrawString(fileContent, font, XBrushes.Black, rect, XStringFormat.TopLeft);

                ////fileContent = "-------------------------------------------\n";
                //fileContent = "\n Total Deduction : " + total_deduct.ToString() + "\n";
                ////fileContent = fileContent +  "-------------------------------------------\n\n";
                //rect = new XRect(350, 420, 250, 40);
                //gfx.DrawRectangle(XBrushes.White, rect);
                //tf.Alignment = XParagraphAlignment.Left;
                //tf.DrawString(fileContent, font, XBrushes.Black, rect, XStringFormat.TopLeft);
                /*if (gender.Equals("MALE", StringComparison.OrdinalIgnoreCase))
                {
                    fileContent = "Note : He received Rs  " + net_salary.ToString() + " after deduction, ";
                }
                else if (gender.Equals("FEMALE", StringComparison.OrdinalIgnoreCase))
                {
                    fileContent = "Note : She received Rs " + net_salary.ToString() + " after deduction, ";
                }
                else
                {
                    fileContent = "Note : He/She received Rs " + net_salary.ToString() + " after deduction, ";
                }*/
                fileContent = "Note : Net salary Rs " + net_salary.ToString() + " after deduction, ";
                fileContent = fileContent +  "for the month of : " + month + "\n";
                rect = new XRect(90, 500, 400, 40);
                gfx.DrawRectangle(XBrushes.White, rect);
                tf.Alignment = XParagraphAlignment.Center;
                tf.DrawString(fileContent, font, XBrushes.Black, rect, XStringFormat.TopLeft);
                fileContent = "Date " + date_str + "\n\nAmount in Rs.   ";
                rect = new XRect(410/*40*/, 140/*610*/, 100, 20);
                gfx.DrawRectangle(XBrushes.White, rect);
                tf.Alignment = XParagraphAlignment.Right;
                tf.DrawString(fileContent, font, XBrushes.Black, rect, XStringFormat.TopLeft);
                fileContent = "Principal";
                rect = new XRect(450, 610, 100, 20);
                gfx.DrawRectangle(XBrushes.White, rect);
                tf.Alignment = XParagraphAlignment.Right;
                tf.DrawString(fileContent, font, XBrushes.Black, rect, XStringFormat.TopLeft);
                fileContent = "Accountant";
                rect = new XRect(80, 610, 100, 20);
                gfx.DrawRectangle(XBrushes.White, rect);
                tf.Alignment = XParagraphAlignment.Left;
                tf.DrawString(fileContent, font, XBrushes.Black, rect, XStringFormat.TopLeft);
                fileContent = "Office\nSuperintendent";
                rect = new XRect(250, 600, 100, 20);
                gfx.DrawRectangle(XBrushes.White, rect);
                tf.Alignment = XParagraphAlignment.Center;
                tf.DrawString(fileContent, font, XBrushes.Black, rect, XStringFormat.TopLeft);


                filepath = this.btn_dest_path.Text + indx.ToString() + "_" + name + "_" + this.cmb_box_month.SelectedItem.ToString() + "_SalarySlip" + ".pdf";

                // Save the document...
                try
                {
                    document.Save(filepath);
                    MessageBox.Show("Salary slip is created for " + name + " whose PAN is " + pancard);
                }
                catch (Exception excp)
                {
                    MessageBox.Show("Filename: " + filepath + " Cannot be saved.\n" + excp.Message + "\nTrying with no name", "Error in Saving Salary Slip.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    filepath = this.btn_dest_path.Text + indx.ToString() + "_name_" + this.cmb_box_month.SelectedItem.ToString() + "_SalarySlip" + ".pdf";
                    try
                    {
                        document.Save(filepath);
                        MessageBox.Show("Salary slip is created for " + name + " whose PAN is " + pancard);
                    }
                    catch (Exception excp2)
                    {
                        MessageBox.Show("Filename: " + filepath + " Cannot be saved again.\n" + excp2.Message + "\nCheck the out path", "Error in Saving Salary Slip.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                document.Close();
                break;
                /************************************************************************/
            }

            this.prgsbr_mmh_slry_mkr.Value = this.prgsbr_mmh_slry_mkr.Maximum;
            /********************************************/
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }

        private void cmb_box_sheet_number_SelectedIndexChanged(object sender, EventArgs e)
        {
            int counter;
            System.Double prgsbrCntr = 0.00;
            releaseObject(xlRange);
            releaseObject(xlWorkSheet);
            this.cmb_box_serial_number.Items.Clear();
            if (this.cmb_box_sheet_number.SelectedIndex == 0)
            {
                this.cmb_box_serial_number.Text = "--- Select Sheet First ---";
                return;
            }
            try
            {
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(this.cmb_box_sheet_number.SelectedIndex);
                if (xlWorkSheet.Name != this.cmb_box_sheet_number.Text)
                {
                    int tempCounter;
                    for (tempCounter = 1; tempCounter <= xlWorkBook.Worksheets.Count; tempCounter++)
                    {
                        releaseObject(xlWorkSheet);
                        xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(tempCounter);
                        if (xlWorkSheet.Name == this.cmb_box_sheet_number.Text)
                        {
                            break;
                        }
                    }
                    if (tempCounter > xlWorkBook.Worksheets.Count)
                    {
                        releaseObject(xlWorkSheet);
                        MessageBox.Show("Error in Sheet please check the salary file.", "Error in Sheet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                xlRange = xlWorkSheet.UsedRange;
                this.cmb_box_serial_number.Items.Add("Select Name");
                for (counter = 1; counter <= xlRange.Rows.Count; counter++)
                {
                    Object value = null;
                    indx = 0;
                    name = "";
                    pancard = "";

                    value = (xlRange.Cells[counter, CELL_POS_INDX] as Excel.Range).Value2;
                    if (value == null)
                    {
                        continue;
                    }
                    if (value.GetType().ToString() == prgsbrCntr.GetType().ToString())
                    {
                        indx = Convert.ToInt32(value);
                    }
                    if (indx < 1)
                    {
                        continue;
                    }
                    value = (xlRange.Cells[counter, CELL_POS_NAME] as Excel.Range).Value2;
                    if (value == null)
                    {
                        /* name cannot be null */
                        continue;
                    }
                    else if (value.GetType().ToString() == prgsbrCntr.GetType().ToString())
                    {
                        /* name field cannot be double too*/
                        continue;
                    }
                    else
                    {
                        /* copy name string to name variable*/
                        name = (string)value;
                    }
                    value = (xlRange.Cells[counter, CELL_POS_PAN] as Excel.Range).Value2;
                    if (value == null)
                    {
                        /* name cannot be null */
                        pancard = " ";
                    }
                    else if (value.GetType().ToString() == prgsbrCntr.GetType().ToString())
                    {
                        /* name field cannot be double too*/
                        pancard = " ";
                    }
                    else
                    {
                        /* copy name string to name variable*/
                        pancard = (string)value;
                    }
                    this.cmb_box_serial_number.Items.Add(indx.ToString() + "_" + name + "(" + pancard + ")");
                }
                this.cmb_box_serial_number.Text = "Select Person";
                this.cmb_box_serial_number.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Select Proper sheet", "Sheet Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void frm_mmh_clg_salary_maker_FormClosing(object sender, FormClosingEventArgs e)
        {
            releaseObject(xlRange);
            releaseObject(xlWorkSheet);
            try
            {
                xlWorkBook.Close(false, null, null);
                xlApp.Quit();
            }
            catch (Exception)
            { 
            }
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }

        private void cmb_box_serial_number_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmb_box_permanent.Text = "Permanent";
            this.cmb_box_gender.Text = "Select Gender";
            this.txtbx_src_file_path.Text = "_______________";
        }

        private void frm_mmh_clg_salary_maker_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
