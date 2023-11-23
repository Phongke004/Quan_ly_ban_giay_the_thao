namespace PRL.View
{
    partial class DoiMatKhau
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtConfirmNewPassWord = new TextBox();
            txtNewPassWord = new TextBox();
            txtPassword = new TextBox();
            txtUser = new TextBox();
            btnDMK = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(110, 9);
            label1.Name = "label1";
            label1.Size = new Size(211, 41);
            label1.TabIndex = 0;
            label1.Text = "Đổi Mật Khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 78);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 116);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu cũ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 154);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 3;
            label4.Text = "Mật khẩu mới";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 192);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 4;
            label5.Text = "Xác nhận mật khẩu";
            // 
            // txtConfirmNewPassWord
            // 
            txtConfirmNewPassWord.Location = new Point(187, 185);
            txtConfirmNewPassWord.Name = "txtConfirmNewPassWord";
            txtConfirmNewPassWord.Size = new Size(225, 27);
            txtConfirmNewPassWord.TabIndex = 5;
            // 
            // txtNewPassWord
            // 
            txtNewPassWord.Location = new Point(187, 147);
            txtNewPassWord.Name = "txtNewPassWord";
            txtNewPassWord.Size = new Size(225, 27);
            txtNewPassWord.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(187, 109);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(225, 27);
            txtPassword.TabIndex = 7;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(187, 71);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(225, 27);
            txtUser.TabIndex = 8;
            // 
            // btnDMK
            // 
            btnDMK.Location = new Point(66, 257);
            btnDMK.Name = "btnDMK";
            btnDMK.Size = new Size(135, 29);
            btnDMK.TabIndex = 9;
            btnDMK.Text = "Đổi mật khẩu";
            btnDMK.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(227, 257);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(129, 29);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // DoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 322);
            Controls.Add(btnBack);
            Controls.Add(btnDMK);
            Controls.Add(txtUser);
            Controls.Add(txtPassword);
            Controls.Add(txtNewPassWord);
            Controls.Add(txtConfirmNewPassWord);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DoiMatKhau";
            Text = "DoiMatKhau";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtConfirmNewPassWord;
        private TextBox txtNewPassWord;
        private TextBox txtPassword;
        private TextBox txtUser;
        private Button btnDMK;
        private Button btnBack;
    }
}