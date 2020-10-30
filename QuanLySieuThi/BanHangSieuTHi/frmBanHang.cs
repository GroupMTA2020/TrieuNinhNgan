using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanHangSieuTHi.Class;
using System.Collections;

namespace BanHangSieuTHi
{
    public partial class frmBanHang : Form
    {
        SqlCommand cmd;
        sqlQuery truyVanDL = new sqlQuery();
        public frmBanHang()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-KBK3516B\SQLEXPRESS;Initial Catalog=QLBanHangSieuThi;Integrated Security=True");
        private void frmBanHang_Load(object sender, EventArgs e)
        {
            loadDBSdtKhachHang();
            loadDBComBoxHangHoa();
            loadDBComBoxNhanVien();
        }

        public void loadDBSdtKhachHang()
        {
            DataTable sdt = truyVanDL.LayDuLieu("select * from KHACHHANG ");

            cmbSdtKH.DataSource = sdt;

            cmbSdtKH.DisplayMember = "SdtKH".ToString().Trim();
            cmbSdtKH.SelectedIndex = -1;
        }

        private void cmbSdtKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void loadDBComBoxHangHoa()
        {           
            
        }

        private void cmbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }


        public void loadDBComBoxNhanVien()
        {
           
        }

        public void LoadDatagridView()
        {
          
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btnThemHH_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           
        }
    }
}
