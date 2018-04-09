using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MMHCollegeSalaryMaker
{
    public partial class Form_mmh_slry_login_screen : Form
    {
        Boolean isPasswordChanging;
        public Form_mmh_slry_login_screen()
        {
            InitializeComponent();
        }

        private void Form_mmh_slry_login_screen_Load(object sender, EventArgs e)
        {
            /*this.txtbx_user_name.Text = MMHCollegeSalaryMaker.Properties.Settings.Default.sttng_string_password;*/
            this.txtbx_user_name.Text = MMHCollegeSalaryMaker.Properties.Resources.rsc_string_user_name;
            this.txtbx_password.Text = "";
            this.isPasswordChanging = false;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (this.txtbx_password.Text == MMHCollegeSalaryMaker.Properties.Settings.Default.sttng_string_password)
            {
                frm_mmh_clg_salary_maker frm_mmh_clg_salary_maker_new = new frm_mmh_clg_salary_maker();
                this.txtbx_password.Text = "";
                this.Hide();
                frm_mmh_clg_salary_maker_new.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Login Password not matched", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtbx_password.Text = "";
            }
        }

        private void btn_reset_password_Click(object sender, EventArgs e)
        {
            if (this.isPasswordChanging)
            {
                /* procedure for password change */
                this.isPasswordChanging = false;
                this.btn_reset_password.Text = "Change Password";
                this.txtbx_user_name.Text = MMHCollegeSalaryMaker.Properties.Resources.rsc_string_user_name;
                this.btn_login.Enabled = true;
                if (this.txtbx_password.Text == MMHCollegeSalaryMaker.Properties.Resources.rsc_string_password_admin)
                {
                    MessageBox.Show("Password changed to default. As provided by the developer", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MMHCollegeSalaryMaker.Properties.Settings.Default.sttng_string_password = MMHCollegeSalaryMaker.Properties.Resources.rsc_string_password_default;
                    MMHCollegeSalaryMaker.Properties.Settings.Default.Save();
                    this.txtbx_password.Text = "";
                    return;
                }
                if (this.txtbx_password.Text == "")
                {
                    MessageBox.Show("Empty String:\n Password not changed", "Password Not Changed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MMHCollegeSalaryMaker.Properties.Settings.Default.sttng_string_password = this.txtbx_password.Text;
                MMHCollegeSalaryMaker.Properties.Settings.Default.Save();
                this.txtbx_password.Text = "";
                MessageBox.Show("Password changed successfully!", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (this.txtbx_password.Text == MMHCollegeSalaryMaker.Properties.Resources.rsc_string_password_admin)
                {
                    MessageBox.Show("Password changed to default. As provided by the developer", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MMHCollegeSalaryMaker.Properties.Settings.Default.sttng_string_password = MMHCollegeSalaryMaker.Properties.Resources.rsc_string_password_default;
                    MMHCollegeSalaryMaker.Properties.Settings.Default.Save();
                    this.txtbx_password.Text = "";
                    return;
                }
                if (this.txtbx_password.Text == MMHCollegeSalaryMaker.Properties.Settings.Default.sttng_string_password)
                {
                    MessageBox.Show("Changing login password.\nEnter new password in above field", "Password Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.isPasswordChanging = true;
                    this.btn_reset_password.Text = "Update Password";
                    this.txtbx_user_name.Text = "Enter new password";
                    this.txtbx_password.Text = "";
                    this.btn_login.Enabled = false;
                    return;
                }
                MessageBox.Show("Password does not match.\nPlease type login password in above field.\nIf forget the login password, then follow the instruction provided by the developer", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtbx_password.Text = "";
            }
        }
    }
}
