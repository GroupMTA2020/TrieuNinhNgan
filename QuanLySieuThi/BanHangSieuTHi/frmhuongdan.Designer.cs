namespace BanHangSieuTHi
{
    partial class frmhuongdan
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Login");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Màn hình chính");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Bán hàng");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Nhập");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("xuất");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Hóa Đơn", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Hàng hóa");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("danh mục");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("nhập bán");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Thống Kê", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("khách hàng");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Nhân Viên");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("QLnguoidung");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Các chức năng", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode6,
            treeNode7,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Giới thiệu phần mềm", new System.Windows.Forms.TreeNode[] {
            treeNode14});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtGioiThieu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "gtlogin";
            treeNode1.Text = "Login";
            treeNode2.Name = "gtManHinhChinh";
            treeNode2.Text = "Màn hình chính";
            treeNode3.Name = "gtbanhang";
            treeNode3.Text = "Bán hàng";
            treeNode4.Name = "gtnhap";
            treeNode4.Text = "Nhập";
            treeNode5.Name = "gtxuat";
            treeNode5.Text = "xuất";
            treeNode6.Name = "gthoadon";
            treeNode6.Text = "Hóa Đơn";
            treeNode7.Name = "gthanghoa";
            treeNode7.Text = "Hàng hóa";
            treeNode8.Name = "gtdanhmuc";
            treeNode8.Text = "danh mục";
            treeNode9.Name = "gtnhapban";
            treeNode9.Text = "nhập bán";
            treeNode10.Name = "gtthongke";
            treeNode10.Text = "Thống Kê";
            treeNode11.Name = "gtkhachhang";
            treeNode11.Text = "khách hàng";
            treeNode12.Name = "gtnhanvien";
            treeNode12.Text = "Nhân Viên";
            treeNode13.Name = "gtQlnguoidung";
            treeNode13.Text = "QLnguoidung";
            treeNode14.Name = "gtChucNang";
            treeNode14.Text = "Các chức năng";
            treeNode15.Name = "gtPhanMem";
            treeNode15.Text = "Giới thiệu phần mềm";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15});
            this.treeView1.Size = new System.Drawing.Size(228, 647);
            this.treeView1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(228, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(889, 395);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtGioiThieu
            // 
            this.txtGioiThieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGioiThieu.Location = new System.Drawing.Point(228, 395);
            this.txtGioiThieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGioiThieu.Multiline = true;
            this.txtGioiThieu.Name = "txtGioiThieu";
            this.txtGioiThieu.Size = new System.Drawing.Size(889, 252);
            this.txtGioiThieu.TabIndex = 4;
            // 
            // frmhuongdan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 647);
            this.Controls.Add(this.txtGioiThieu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "frmhuongdan";
            this.Text = "frmhuongdan";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtGioiThieu;
    }
}