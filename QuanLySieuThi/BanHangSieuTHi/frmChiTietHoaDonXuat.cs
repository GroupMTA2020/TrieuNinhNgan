using BanHangSieuTHi.Class;
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

namespace BanHangSieuTHi
{
    public partial class frmChiTietHoaDonXuat : Form
    {
        
        public frmChiTietHoaDonXuat()
        {
            InitializeComponent();
        }

        public frmChiTietHoaDonXuat(string MaHDX) : this()
        {
            
        }
        private void frmChiTietHoaDonXuat_Load(object sender, EventArgs e)
        {
            
            
        }
        //load lại datagridview
        public void LoadDatagridView()
        {           
           
        }


        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {        
          
        }

        private void btnExit_Click(object sender, EventArgs es)
        {
        }

    }
}
