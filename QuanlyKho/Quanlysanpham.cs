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
    public partial class Quanlysanpham : Form
    {
        public Quanlysanpham()
        {
            InitializeComponent();
            Load_data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connect_Model connect_Model = new Connect_Model();
            connect_Model.Execute("Update SanPham Set name = N'" + txtName.Text + "',description= N'" + rtxtDesc.Text + "',body = N'" + rtxtBody.Text + "',image = N'" + pbImage.Text + "',price = N'" + txtPrice.Text + "',sale_price = N'" + txtSalePrice.Text + "',danhmuc_id = N'" + cbCategory.SelectedValue + "',updated_at = N'" + DateTime.Now.Date.ToString("yyyy/MM/dd") + "' where id = '" + dataGridView1.CurrentRow.Cells[0].Value + "'");
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

        private void button1_Click(object sender, EventArgs e)
        {
            Connect_Model connect_Model = new Connect_Model();
            connect_Model.Execute("Insert into SanPham(name,description,body,image,price,sale_price,danhmuc_id,created_at) values(N'" + txtName.Text + "',N'" + rtxtDesc.Text + "',N'" + rtxtBody.Text + "',N'" + pbImage.Text + "',N'" + txtPrice.Text + "',N'" + txtSalePrice.Text + "',N'" + cbCategory.SelectedValue + "','" + DateTime.Now.Date.ToString("yyyy/MM/dd") + "')");
            if (connect_Model.check == true)
            {
                txtName.Clear();
                rtxtDesc.Clear();
                rtxtBody.Clear();
                //pbImage.Clear();
                txtPrice.Clear();
                txtSalePrice.Clear();

                MessageBox.Show("Thêm dữ liệu thành công");
                Load_data();
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu không thành công");

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Connect_Model connect_Model = new Connect_Model();
            connect_Model.Execute("Delete from SanPham where id ='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() +"'");
            if (connect_Model.check == true)
            {
              
                MessageBox.Show("Xoá dữ liệu thành công");
                txtName.Clear();
                rtxtDesc.Clear();
                rtxtBody.Clear();
                txtPrice.Clear();
                txtSalePrice.Clear();
                Load_data();
            }
            else
            {
                MessageBox.Show("Xoá dữ liệu không thành công");

            }
        }
        private void Load_data()
        {
            Connect_Model connect_Model = new Connect_Model();
            DataTable products = connect_Model.Query("Select * from SanPham");
            if (products != null)
            {
                dataGridView1.DataSource = products;
            }
            DataTable category = connect_Model.Query("Select *from DanhMucSanPham");
            if(category != null)
            {
                cbCategory.DataSource = category;
                cbCategory.ValueMember = category.Columns[0].ColumnName;
                cbCategory.DisplayMember = category.Columns[1].ColumnName;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cbCategory.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            rtxtDesc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            rtxtBody.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            pbImage.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtPrice.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtSalePrice.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
           
           
        }
    }
}
