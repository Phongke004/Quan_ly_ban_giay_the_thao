namespace PRLL.View
{
    partial class Login
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
            btnDoiMK = new Button();
            label1 = new Label();
            txtUser = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // btnDoiMK
            // 
            btnDoiMK.BackColor = SystemColors.Info;
            btnDoiMK.Font = new Font("Snap ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoiMK.ForeColor = Color.Red;
            btnDoiMK.Location = new Point(422, 342);
            btnDoiMK.Name = "btnDoiMK";
            btnDoiMK.Size = new Size(210, 46);
            btnDoiMK.TabIndex = 0;
            btnDoiMK.Text = "Đổi mật khẩu";
            btnDoiMK.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Stencil", 10.125F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(78, 167);
            label1.Name = "label1";
            label1.Size = new Size(107, 34);
            label1.TabIndex = 1;
            label1.Text = "User : ";
            // 
            // txtUser
            // 
            txtUser.BackColor = SystemColors.Info;
            txtUser.Location = new Point(251, 167);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(381, 39);
            txtUser.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Stencil", 10.125F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(66, 248);
            label2.Name = "label2";
            label2.Size = new Size(179, 34);
            label2.TabIndex = 1;
            label2.Text = "PassWord : ";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Info;
            txtPassword.Location = new Point(251, 248);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(381, 39);
            txtPassword.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.InactiveCaptionText;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(251, 25);
            label3.Name = "label3";
            label3.Size = new Size(299, 62);
            label3.TabIndex = 1;
            label3.Text = "Đăng Nhập";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Info;
            btnLogin.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogin.Font = new Font("Snap ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Red;
            btnLogin.Location = new Point(197, 342);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(175, 46);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Đặng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 459);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(btnDoiMK);
            Name = "Login";
            Text = "Login";
            FormClosed += Login_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDoiMK;
        private Label label1;
        private TextBox txtUser;
        private Label label2;
        private TextBox txtPassword;
        private Label label3;
        private Button btnLogin;
    }
}

namespace PRL
{
    class Resources
    {
        public static Image Hinh_anh_12_con_giap_Black_Robot_tuoi_Suu { get; internal set; }
    }
}