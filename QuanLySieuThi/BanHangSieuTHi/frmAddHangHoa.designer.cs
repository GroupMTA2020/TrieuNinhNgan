﻿namespace BanHangSieuTHi.Add
{
    partial class frmHangHoa
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Ma = new System.Windows.Forms.TextBox();
            this.Ten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DonVi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TenNhaSX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GiaDeNghi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SoLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Loai = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hàng Hóa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Ma
            // 
            this.Ma.Enabled = false;
            this.Ma.Location = new System.Drawing.Point(262, 125);
            this.Ma.Margin = new System.Windows.Forms.Padding(2);
            this.Ma.Multiline = true;
            this.Ma.Name = "Ma";
            this.Ma.Size = new System.Drawing.Size(247, 22);
            this.Ma.TabIndex = 1;
            // 
            // Ten
            // 
            this.Ten.Location = new System.Drawing.Point(262, 172);
            this.Ten.Margin = new System.Windows.Forms.Padding(2);
            this.Ten.Multiline = true;
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(247, 22);
            this.Ten.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Hàng Hóa";
            // 
            // DonVi
            // 
            this.DonVi.Location = new System.Drawing.Point(262, 219);
            this.DonVi.Margin = new System.Windows.Forms.Padding(2);
            this.DonVi.Multiline = true;
            this.DonVi.Name = "DonVi";
            this.DonVi.Size = new System.Drawing.Size(247, 22);
            this.DonVi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 221);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đơn vị";
            // 
            // TenNhaSX
            // 
            this.TenNhaSX.Location = new System.Drawing.Point(262, 266);
            this.TenNhaSX.Margin = new System.Windows.Forms.Padding(2);
            this.TenNhaSX.Multiline = true;
            this.TenNhaSX.Name = "TenNhaSX";
            this.TenNhaSX.Size = new System.Drawing.Size(247, 22);
            this.TenNhaSX.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 269);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên Nhà SX";
            // 
            // GiaDeNghi
            // 
            this.GiaDeNghi.Location = new System.Drawing.Point(262, 313);
            this.GiaDeNghi.Margin = new System.Windows.Forms.Padding(2);
            this.GiaDeNghi.Multiline = true;
            this.GiaDeNghi.Name = "GiaDeNghi";
            this.GiaDeNghi.Size = new System.Drawing.Size(247, 22);
            this.GiaDeNghi.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 317);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giá Đề Nghị";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(112, 365);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Loại";
            // 
            // SoLuong
            // 
            this.SoLuong.Location = new System.Drawing.Point(262, 409);
            this.SoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.SoLuong.Multiline = true;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Size = new System.Drawing.Size(247, 22);
            this.SoLuong.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(112, 413);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Số Lượng";
            // 
            // Loai
            // 
            this.Loai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Loai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Loai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Loai.FormattingEnabled = true;
            this.Loai.Location = new System.Drawing.Point(262, 360);
            this.Loai.Margin = new System.Windows.Forms.Padding(2);
            this.Loai.Name = "Loai";
            this.Loai.Size = new System.Drawing.Size(247, 24);
            this.Loai.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(259, 483);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 54);
            this.button1.TabIndex = 15;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 71);
            this.panel1.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(201, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Thêm Hàng Hóa";
            // 
            // frmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 567);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Loai);
            this.Controls.Add(this.SoLuong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GiaDeNghi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TenNhaSX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DonVi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Ten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ma);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHangHoa";
            this.Text = "frmHangHoa";
            this.Load += new System.EventHandler(this.frmHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Ma;
        private System.Windows.Forms.TextBox Ten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DonVi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TenNhaSX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GiaDeNghi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox SoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Loai;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
    }
}