using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyKho
{
    public partial class Quanlykho : Form
    {
        public Quanlykho()
        {
            InitializeComponent();
            Load_data();
        }

        private void Load_data()
        {
            Connect_Model connect_Model = new Connect_Model();
            DataTable kho = connect_Model.Query("Select * from Kho");
            if(kho != null)
            {
                dataGridView1.DataSource = kho;
            }
            DataTable nhanvien = connect_Model.Query("Select *from NhanVien");
            if (nhanvien != null)
            {
                cbNhanVien.DataSource = nhanvien;
                cbNhanVien.ValueMember = nhanvien.Columns[0].ColumnName;
                cbNhanVien.DisplayMember = nhanvien.Columns[1].ColumnName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connect_Model connect_Model = new Connect_Model();
            connect_Model.Execute("Insert into Kho (tenKho,diachi,sodienthoai,nhanvien_id,created_at) values(N'" + txtName.Text + "',N'" + rtxtDiaChi.Text + "',N'" + txtSDT.Text + "','" + cbNhanVien.SelectedValue + "','" + DateTime.Now.Date.ToString("yyyy/MM/dd") + "')");
            if (connect_Model.check == true)
            {
                txtName.Clear();
                rtxtDiaChi.Clear();
                txtSDT.Clear();
                //pbImage.Clear();

                MessageBox.Show("Thêm dữ liệu thành công");
                Load_data();
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu không thành công");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connect_Model connect_Model = new Connect_Model();
            connect_Model.Execute("Update Kho Set tenKho = N'" + txtName.Text + "',diachi= N'" + rtxtDiaChi.Text + "',sodienthoai = N'" + txtSDT.Text + "',nhanvien_id = N'" + cbNhanVien.SelectedValue + "',updated_at = N'" + DateTime.Now.Date.ToString("yyyy/MM/dd") + "' where id = '" + dataGridView1.CurrentRow.Cells[0].Value + "'");
            if (connect_Model.check == true)
            {

                MessageBox.Show("Cập nhập dữ liệu thành công");
                Load_data();
            }
            else
            {
                MessageBox.Show("Cập nhập dữ liệu không thành công");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Connect_Model connect_Model = new Connect_Model();
            connect_Model.Execute("Delete from Kho where id ='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'");
            if (connect_Model.check == true)
            {

                MessageBox.Show("Xoá dữ liệu thành công");
                txtName.Clear();
                rtxtDiaChi.Clear();
                txtSDT.Clear();
                Load_data();
            }
            else
            {
                MessageBox.Show("Xoá dữ liệu không thành công");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            rtxtDiaChi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSDT.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cbNhanVien.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            
        }
    }
}
