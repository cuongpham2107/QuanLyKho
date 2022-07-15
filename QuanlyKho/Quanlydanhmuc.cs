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
    public partial class Quanlydanhmuc : Form
    {
        public Quanlydanhmuc()
        {
            InitializeComponent();
            Load_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connect_Model connect_Model = new Connect_Model();
            connect_Model.Execute("Insert into DanhMucSanPham(name,description,body,created_at) values(N'" + txtName.Text + "',N'" + rtxtDesc.Text + "',N'" + rtxtBody.Text + "','" + DateTime.Now.Date.ToString("yyyy/MM/dd") + "')");
            if (connect_Model.check == true)
            {
                txtName.Clear();
                rtxtDesc.Clear();
                rtxtBody.Clear();
                //pbImage.Clear();

                MessageBox.Show("Thêm dữ liệu thành công");
                Load_data();
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu không thành công");

            }
        }
        private void Load_data()
        {
            Connect_Model connect_Model = new Connect_Model();
            DataTable category = connect_Model.Query("Select * from DanhMucSanPham");

            if(category != null)
            {
                dgvDanhmuc.DataSource = category;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connect_Model connect_Model = new Connect_Model();
            connect_Model.Execute("Update DanhMucSanPham Set name = N'" + txtName.Text + "',description= N'" + rtxtDesc.Text + "',body = N'" + rtxtBody.Text + "',updated_at = N'" + DateTime.Now.Date.ToString("yyyy/MM/dd") + "' where id = '" + dgvDanhmuc.CurrentRow.Cells[0].Value + "'");
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

        private void dgvDanhmuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvDanhmuc.CurrentRow.Cells[1].Value.ToString();
            rtxtDesc.Text = dgvDanhmuc.CurrentRow.Cells[2].Value.ToString();
            rtxtBody.Text = dgvDanhmuc.CurrentRow.Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Connect_Model connect_Model = new Connect_Model();
            connect_Model.Execute("Delete from DanhMucSanPham where id ='" + dgvDanhmuc.CurrentRow.Cells[0].Value.ToString() + "'");
            if (connect_Model.check == true)
            {

                MessageBox.Show("Xoá dữ liệu thành công");
                txtName.Clear();
                rtxtDesc.Clear();
                rtxtBody.Clear();
                Load_data();
            }
            else
            {
                MessageBox.Show("Xoá dữ liệu không thành công");
            }
        }
    }
}
