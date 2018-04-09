namespace MMHCollegeSalaryMaker
{
    partial class Form_mmh_slry_login_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_mmh_slry_login_screen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_user_name = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txtbx_user_name = new System.Windows.Forms.TextBox();
            this.txtbx_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_reset_password = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MMHCollegeSalaryMaker.Properties.Resources.rsc_image_mmh_logo_login;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_user_name
            // 
            this.lbl_user_name.AutoSize = true;
            this.lbl_user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_name.Location = new System.Drawing.Point(280, 95);
            this.lbl_user_name.Name = "lbl_user_name";
            this.lbl_user_name.Size = new System.Drawing.Size(98, 17);
            this.lbl_user_name.TabIndex = 1;
            this.lbl_user_name.Text = "User Name :";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(291, 127);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(87, 17);
            this.lbl_password.TabIndex = 2;
            this.lbl_password.Text = "Password :";
            // 
            // txtbx_user_name
            // 
            this.txtbx_user_name.Location = new System.Drawing.Point(384, 94);
            this.txtbx_user_name.Name = "txtbx_user_name";
            this.txtbx_user_name.ReadOnly = true;
            this.txtbx_user_name.Size = new System.Drawing.Size(137, 20);
            this.txtbx_user_name.TabIndex = 10;
            this.txtbx_user_name.Text = "Administrator";
            // 
            // txtbx_password
            // 
            this.txtbx_password.Location = new System.Drawing.Point(384, 126);
            this.txtbx_password.Name = "txtbx_password";
            this.txtbx_password.Size = new System.Drawing.Size(137, 20);
            this.txtbx_password.TabIndex = 4;
            this.txtbx_password.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(405, 178);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(116, 28);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_reset_password
            // 
            this.btn_reset_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset_password.Location = new System.Drawing.Point(283, 178);
            this.btn_reset_password.Name = "btn_reset_password";
            this.btn_reset_password.Size = new System.Drawing.Size(116, 28);
            this.btn_reset_password.TabIndex = 6;
            this.btn_reset_password.Text = "Change Password";
            this.btn_reset_password.UseVisualStyleBackColor = true;
            this.btn_reset_password.Click += new System.EventHandler(this.btn_reset_password_Click);
            // 
            // Form_mmh_slry_login_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 290);
            this.Controls.Add(this.btn_reset_password);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txtbx_password);
            this.Controls.Add(this.txtbx_user_name);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_user_name);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_mmh_slry_login_screen";
            this.Text = "MMH College Salary Slip";
            this.Load += new System.EventHandler(this.Form_mmh_slry_login_screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_user_name;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txtbx_user_name;
        private System.Windows.Forms.TextBox txtbx_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_reset_password;
    }
}