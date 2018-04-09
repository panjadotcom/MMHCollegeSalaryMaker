namespace MMHCollegeSalaryMaker
{
    partial class frm_mmh_clg_salary_maker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mmh_clg_salary_maker));
            this.lbl_src_file_path = new System.Windows.Forms.Label();
            this.txtbx_src_file_path = new System.Windows.Forms.TextBox();
            this.btn_src_file_path = new System.Windows.Forms.Button();
            this.btn_dest_path = new System.Windows.Forms.Button();
            this.btn_create_slry_slip = new System.Windows.Forms.Button();
            this.fbd_mmh_clg_slry_mkr = new System.Windows.Forms.FolderBrowserDialog();
            this.ofd_mmh_clg_slry_mkr = new System.Windows.Forms.OpenFileDialog();
            this.prgsbr_mmh_slry_mkr = new System.Windows.Forms.ProgressBar();
            this.num_up_dwn_year = new System.Windows.Forms.NumericUpDown();
            this.cmb_box_month = new System.Windows.Forms.ComboBox();
            this.cmb_box_sheet_number = new System.Windows.Forms.ComboBox();
            this.cmb_box_serial_number = new System.Windows.Forms.ComboBox();
            this.cmb_box_gender = new System.Windows.Forms.ComboBox();
            this.cmb_box_permanent = new System.Windows.Forms.ComboBox();
            this.lbl_screen_text_month = new System.Windows.Forms.Label();
            this.lbl_screen_info_gender = new System.Windows.Forms.Label();
            this.lbl_screen_info_permanent = new System.Windows.Forms.Label();
            this.pctr_box_mmh_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_up_dwn_year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctr_box_mmh_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_src_file_path
            // 
            this.lbl_src_file_path.AutoSize = true;
            this.lbl_src_file_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_src_file_path.Location = new System.Drawing.Point(12, 394);
            this.lbl_src_file_path.Name = "lbl_src_file_path";
            this.lbl_src_file_path.Size = new System.Drawing.Size(209, 17);
            this.lbl_src_file_path.TabIndex = 0;
            this.lbl_src_file_path.Text = "member of the department :";
            // 
            // txtbx_src_file_path
            // 
            this.txtbx_src_file_path.Location = new System.Drawing.Point(223, 394);
            this.txtbx_src_file_path.Name = "txtbx_src_file_path";
            this.txtbx_src_file_path.Size = new System.Drawing.Size(448, 20);
            this.txtbx_src_file_path.TabIndex = 18;
            // 
            // btn_src_file_path
            // 
            this.btn_src_file_path.Location = new System.Drawing.Point(12, 231);
            this.btn_src_file_path.Name = "btn_src_file_path";
            this.btn_src_file_path.Size = new System.Drawing.Size(432, 23);
            this.btn_src_file_path.TabIndex = 12;
            this.btn_src_file_path.Text = "Select Excel Salery File";
            this.btn_src_file_path.UseVisualStyleBackColor = true;
            this.btn_src_file_path.Click += new System.EventHandler(this.btn_src_file_path_Click);
            // 
            // btn_dest_path
            // 
            this.btn_dest_path.Location = new System.Drawing.Point(450, 231);
            this.btn_dest_path.Name = "btn_dest_path";
            this.btn_dest_path.Size = new System.Drawing.Size(221, 23);
            this.btn_dest_path.TabIndex = 13;
            this.btn_dest_path.Text = "Select Out Path";
            this.btn_dest_path.UseVisualStyleBackColor = true;
            this.btn_dest_path.Click += new System.EventHandler(this.btn_dest_path_Click);
            // 
            // btn_create_slry_slip
            // 
            this.btn_create_slry_slip.Location = new System.Drawing.Point(12, 434);
            this.btn_create_slry_slip.Name = "btn_create_slry_slip";
            this.btn_create_slry_slip.Size = new System.Drawing.Size(659, 23);
            this.btn_create_slry_slip.TabIndex = 19;
            this.btn_create_slry_slip.Text = "Generate Salery Slip";
            this.btn_create_slry_slip.UseVisualStyleBackColor = true;
            this.btn_create_slry_slip.Click += new System.EventHandler(this.btn_create_slry_slip_Click);
            // 
            // ofd_mmh_clg_slry_mkr
            // 
            this.ofd_mmh_clg_slry_mkr.DefaultExt = "xls";
            this.ofd_mmh_clg_slry_mkr.FileName = "MMH College Salary Slip";
            this.ofd_mmh_clg_slry_mkr.Filter = "Excel 2007 file (*.xls)|*.xls|Excel 2010 file (*.xlsx)|*.xlsx|All (*.*)|*.*";
            this.ofd_mmh_clg_slry_mkr.Title = "Select Salary file";
            // 
            // prgsbr_mmh_slry_mkr
            // 
            this.prgsbr_mmh_slry_mkr.Location = new System.Drawing.Point(12, 488);
            this.prgsbr_mmh_slry_mkr.Name = "prgsbr_mmh_slry_mkr";
            this.prgsbr_mmh_slry_mkr.Size = new System.Drawing.Size(659, 23);
            this.prgsbr_mmh_slry_mkr.TabIndex = 20;
            // 
            // num_up_dwn_year
            // 
            this.num_up_dwn_year.Location = new System.Drawing.Point(617, 192);
            this.num_up_dwn_year.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.num_up_dwn_year.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.num_up_dwn_year.Name = "num_up_dwn_year";
            this.num_up_dwn_year.Size = new System.Drawing.Size(54, 20);
            this.num_up_dwn_year.TabIndex = 11;
            this.num_up_dwn_year.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            // 
            // cmb_box_month
            // 
            this.cmb_box_month.FormattingEnabled = true;
            this.cmb_box_month.Items.AddRange(new object[] {
            "Select Month",
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmb_box_month.Location = new System.Drawing.Point(473, 192);
            this.cmb_box_month.Name = "cmb_box_month";
            this.cmb_box_month.Size = new System.Drawing.Size(138, 21);
            this.cmb_box_month.TabIndex = 10;
            this.cmb_box_month.Text = "Select Month";
            // 
            // cmb_box_sheet_number
            // 
            this.cmb_box_sheet_number.FormattingEnabled = true;
            this.cmb_box_sheet_number.Location = new System.Drawing.Point(12, 271);
            this.cmb_box_sheet_number.Name = "cmb_box_sheet_number";
            this.cmb_box_sheet_number.Size = new System.Drawing.Size(659, 21);
            this.cmb_box_sheet_number.TabIndex = 14;
            this.cmb_box_sheet_number.Text = "Select Sheet";
            this.cmb_box_sheet_number.SelectedIndexChanged += new System.EventHandler(this.cmb_box_sheet_number_SelectedIndexChanged);
            // 
            // cmb_box_serial_number
            // 
            this.cmb_box_serial_number.FormattingEnabled = true;
            this.cmb_box_serial_number.Location = new System.Drawing.Point(12, 311);
            this.cmb_box_serial_number.Name = "cmb_box_serial_number";
            this.cmb_box_serial_number.Size = new System.Drawing.Size(659, 21);
            this.cmb_box_serial_number.TabIndex = 15;
            this.cmb_box_serial_number.Text = "Select Person name";
            this.cmb_box_serial_number.SelectedIndexChanged += new System.EventHandler(this.cmb_box_serial_number_SelectedIndexChanged);
            // 
            // cmb_box_gender
            // 
            this.cmb_box_gender.FormattingEnabled = true;
            this.cmb_box_gender.Items.AddRange(new object[] {
            "Select gender",
            "Male",
            "Female"});
            this.cmb_box_gender.Location = new System.Drawing.Point(223, 353);
            this.cmb_box_gender.Name = "cmb_box_gender";
            this.cmb_box_gender.Size = new System.Drawing.Size(154, 21);
            this.cmb_box_gender.TabIndex = 16;
            this.cmb_box_gender.Text = "Select gender";
            // 
            // cmb_box_permanent
            // 
            this.cmb_box_permanent.FormattingEnabled = true;
            this.cmb_box_permanent.Items.AddRange(new object[] {
            "____________",
            "permanent",
            "temporary"});
            this.cmb_box_permanent.Location = new System.Drawing.Point(460, 353);
            this.cmb_box_permanent.Name = "cmb_box_permanent";
            this.cmb_box_permanent.Size = new System.Drawing.Size(211, 21);
            this.cmb_box_permanent.TabIndex = 17;
            this.cmb_box_permanent.Text = "Select";
            // 
            // lbl_screen_text_month
            // 
            this.lbl_screen_text_month.AutoSize = true;
            this.lbl_screen_text_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_screen_text_month.Location = new System.Drawing.Point(202, 192);
            this.lbl_screen_text_month.Name = "lbl_screen_text_month";
            this.lbl_screen_text_month.Size = new System.Drawing.Size(257, 16);
            this.lbl_screen_text_month.TabIndex = 5;
            this.lbl_screen_text_month.Text = "Generate salary slip for the month of";
            // 
            // lbl_screen_info_gender
            // 
            this.lbl_screen_info_gender.AutoSize = true;
            this.lbl_screen_info_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_screen_info_gender.Location = new System.Drawing.Point(12, 353);
            this.lbl_screen_info_gender.Name = "lbl_screen_info_gender";
            this.lbl_screen_info_gender.Size = new System.Drawing.Size(205, 17);
            this.lbl_screen_info_gender.TabIndex = 25;
            this.lbl_screen_info_gender.Text = "Above selected person is a";
            // 
            // lbl_screen_info_permanent
            // 
            this.lbl_screen_info_permanent.AutoSize = true;
            this.lbl_screen_info_permanent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_screen_info_permanent.Location = new System.Drawing.Point(383, 354);
            this.lbl_screen_info_permanent.Name = "lbl_screen_info_permanent";
            this.lbl_screen_info_permanent.Size = new System.Drawing.Size(71, 17);
            this.lbl_screen_info_permanent.TabIndex = 26;
            this.lbl_screen_info_permanent.Text = "and is a ";
            // 
            // pctr_box_mmh_logo
            // 
            this.pctr_box_mmh_logo.Image = global::MMHCollegeSalaryMaker.Properties.Resources.rsc_image_mmh_logo;
            this.pctr_box_mmh_logo.Location = new System.Drawing.Point(12, 12);
            this.pctr_box_mmh_logo.Name = "pctr_box_mmh_logo";
            this.pctr_box_mmh_logo.Size = new System.Drawing.Size(659, 174);
            this.pctr_box_mmh_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctr_box_mmh_logo.TabIndex = 23;
            this.pctr_box_mmh_logo.TabStop = false;
            // 
            // frm_mmh_clg_salary_maker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 527);
            this.Controls.Add(this.lbl_screen_info_permanent);
            this.Controls.Add(this.lbl_screen_info_gender);
            this.Controls.Add(this.lbl_screen_text_month);
            this.Controls.Add(this.pctr_box_mmh_logo);
            this.Controls.Add(this.cmb_box_permanent);
            this.Controls.Add(this.cmb_box_gender);
            this.Controls.Add(this.cmb_box_serial_number);
            this.Controls.Add(this.cmb_box_sheet_number);
            this.Controls.Add(this.cmb_box_month);
            this.Controls.Add(this.num_up_dwn_year);
            this.Controls.Add(this.prgsbr_mmh_slry_mkr);
            this.Controls.Add(this.btn_create_slry_slip);
            this.Controls.Add(this.btn_dest_path);
            this.Controls.Add(this.btn_src_file_path);
            this.Controls.Add(this.txtbx_src_file_path);
            this.Controls.Add(this.lbl_src_file_path);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_mmh_clg_salary_maker";
            this.Text = "MMH College Salary Maker";
            this.Load += new System.EventHandler(this.frm_mmh_clg_salary_maker_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_mmh_clg_salary_maker_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_mmh_clg_salary_maker_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.num_up_dwn_year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctr_box_mmh_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_src_file_path;
        private System.Windows.Forms.TextBox txtbx_src_file_path;
        private System.Windows.Forms.Button btn_src_file_path;
        private System.Windows.Forms.Button btn_dest_path;
        private System.Windows.Forms.Button btn_create_slry_slip;
        private System.Windows.Forms.FolderBrowserDialog fbd_mmh_clg_slry_mkr;
        private System.Windows.Forms.OpenFileDialog ofd_mmh_clg_slry_mkr;
        private System.Windows.Forms.ProgressBar prgsbr_mmh_slry_mkr;
        private System.Windows.Forms.NumericUpDown num_up_dwn_year;
        private System.Windows.Forms.ComboBox cmb_box_month;
        private System.Windows.Forms.ComboBox cmb_box_sheet_number;
        private System.Windows.Forms.ComboBox cmb_box_serial_number;
        private System.Windows.Forms.ComboBox cmb_box_gender;
        private System.Windows.Forms.ComboBox cmb_box_permanent;
        private System.Windows.Forms.PictureBox pctr_box_mmh_logo;
        private System.Windows.Forms.Label lbl_screen_text_month;
        private System.Windows.Forms.Label lbl_screen_info_gender;
        private System.Windows.Forms.Label lbl_screen_info_permanent;
    }
}

