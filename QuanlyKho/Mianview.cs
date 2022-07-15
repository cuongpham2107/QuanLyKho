using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanlyKho
{
    public partial class Mianview : Form
    {
        public Mianview()
        {
            InitializeComponent();
            Load_data();
        }
        
        private void Load_data()
        {
            Connect_Model connect_Model = new Connect_Model();

            DataTable products = connect_Model.Query("Select * from SanPham");
            if(products != null)
            {
                dgvSanPham.DataSource = products;
            }
            DataTable phieu = connect_Model.Query("Select * from Phieu");
            if (phieu != null)
            {
                dgvPhieu.DataSource = phieu;
            }
            DataTable nhienvien = connect_Model.Query("Select * from NhanVien");
            if (nhienvien != null)
            {
                dgvNhanVien.DataSource = nhienvien;
            }
            DataTable kho = connect_Model.Query("Select * from Kho");
            if (kho != null)
            {
                dgvKho.DataSource = kho;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Quanlysanpham quanlysanpham = new Quanlysanpham();
            quanlysanpham.ShowDialog();
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Quanlykho quanlykho = new Quanlykho();
            quanlykho.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Quanlydanhmuc quanlydanhmuc = new Quanlydanhmuc();
            quanlydanhmuc.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.ShowDialog();
        }
    }
}
