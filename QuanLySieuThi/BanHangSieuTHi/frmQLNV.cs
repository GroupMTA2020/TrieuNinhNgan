using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanHangSieuTHi.Class;

namespace BanHangSieuTHi
{
    public partial class frmQLNV : Form
    {
        public frmQLNV()
        {
            InitializeComponent();           
        }

        string temp;
        public void LoadListView1()
        {
            listView1.Items.Clear();
            sqlQuery sql = new sqlQuery();
            DataTable dt = sql.LayDuLieu("Select * from NHANVIEN");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add(dt.Rows[i][0].ToString());
                item.SubItems.Add(dt.Rows[i][1].ToString());
                item.SubItems.Add(dt.Rows[i][2].ToString());
                item.SubItems.Add(dt.Rows[i][5].ToString());
                item.SubItems.Add(dt.Rows[i][3].ToString());
                item.SubItems.Add(dt.Rows[i][6].ToString());
                item.SubItems.Add(dt.Rows[i][4].ToString());
                listView1.Items.Add(item);
            }
        }
        private void frmQLNV_Load(object sender, EventArgs e)
        {
            LoadListView1();
        }







        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMa.Text != "")
                {
                    DialogResult result;
                    result = MessageBox.Show("BẠN CÓ MUỐN XÓA NHÂN VIÊN NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string[] name = { "@MaNV" };
                        string[] value = { temp };
                        sqlQuery sql = new sqlQuery();
                        sql.update("DELETE_NV", name, value, 1);
                        MessageBox.Show("Xóa thành công .");
                        listView1.Items.Clear();
                        LoadListView1();
                    }
                }
                else { MessageBox.Show("Hãy chọn một nhân viên bạn muốn thao tác !!", "Warning"); }

            }
            catch (Exception)
            {

            }
        }

       



        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMa.Text != "")
                {
                    DialogResult result;
                    result = MessageBox.Show("BẠN CÓ MUỐN SỬA THÔNG TIN NHÂN VIÊN NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string[] name = { "@MaBanDau", "@MaNV", "@HoTenNV", "@DiaChiNV", "@SdtNV", "@ChucVu", "@NgaySinh", "@GioiTinh" };
                        string[] value = { temp, txtMa.Text, txtTen.Text, txtDiaChi.Text, txtSdt.Text, cbCV.SelectedItem.ToString(), dateTimePicker1.Value.ToString(), cbGT.SelectedItem.ToString() };
                        sqlQuery sql = new sqlQuery();
                        sql.update("UPDATE_NV", name, value, 8);
                        MessageBox.Show("Cập nhật thành công");
                        listView1.Items.Clear();
                        LoadListView1();
                    }
                }
                else { MessageBox.Show("Hãy chọn một nhân viên bạn muốn thao tác !!", "Warning"); }
            }
            catch (Exception)
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                      
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listView1_ItemActivate_1(object sender, EventArgs e)
        {
          
        }
    }
}
