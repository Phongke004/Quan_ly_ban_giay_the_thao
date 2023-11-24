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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            txtUser = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            btnLogin = new Button();
            btnQmk = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Stencil", 10.125F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(48, 88);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 22);
            label1.TabIndex = 1;
            label1.Text = "User : ";
            // 
            // txtUser
            // 
            txtUser.BackColor = SystemColors.Info;
            txtUser.Location = new Point(250, 139);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(381, 39);
            txtUser.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Stencil", 10.125F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(48, 135);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(114, 22);
            label2.TabIndex = 1;
            label2.Text = "PassWord : ";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Info;
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(250, 214);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(381, 39);
            txtPassword.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Sitka Display", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(250, 26);
            label3.Name = "label3";
            label3.Size = new Size(256, 71);
            label3.TabIndex = 1;
            label3.Text = "Đăng Nhập";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Info;
            btnLogin.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogin.Font = new Font("Source Sans Pro", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(88, 177);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(176, 46);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Đặng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnQmk
            // 
            btnQmk.BackColor = SystemColors.Info;
            btnQmk.BackgroundImageLayout = ImageLayout.Zoom;
            btnQmk.Font = new Font("Source Sans Pro", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQmk.ForeColor = Color.Black;
            btnQmk.Location = new Point(244, 177);
            btnQmk.Margin = new Padding(2);
            btnQmk.Name = "btnQmk";
            btnQmk.Size = new Size(138, 29);
            btnQmk.TabIndex = 3;
            btnQmk.Text = "Quyên mật khẩu";
            btnQmk.UseVisualStyleBackColor = false;
          //  btnQmk.Click += btnQmk_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 282);
            Controls.Add(btnQmk);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "Login";
            FormClosed += Login_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtUser;
        private Label label2;
        private TextBox txtPassword;
        private Label label3;
        private Button btnLogin;
        private Button btnQmk;
    }
}

namespace PRL
{
    class Resources
    {
        public static Image Hinh_anh_12_con_giap_Black_Robot_tuoi_Suu { get; internal set; }
    }
}