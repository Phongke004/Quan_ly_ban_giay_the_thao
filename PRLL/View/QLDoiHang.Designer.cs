﻿namespace PRL.View
{
    partial class QLDoiHang
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
            txtSearchSDTKH = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtSearchSDTKH
            // 
            txtSearchSDTKH.Location = new Point(39, 57);
            txtSearchSDTKH.Name = "txtSearchSDTKH";
            txtSearchSDTKH.PlaceholderText = "Vui lòng nhập sdt khách hàng";
            txtSearchSDTKH.Size = new Size(264, 27);
            txtSearchSDTKH.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 77);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1006, 432);
            dataGridView1.TabIndex = 2;
            // 
            // QLDoiHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 613);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(txtSearchSDTKH);
            Name = "QLDoiHang";
            Text = "QLDoiHang";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearchSDTKH;
        private Label label1;
        private DataGridView dataGridView1;
    }
}