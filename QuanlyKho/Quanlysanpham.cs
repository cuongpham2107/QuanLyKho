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


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connect_Model connect_Model = new Connect_Model();
            connect_Model.Execute("Insert into SanPham(id,name,description,body,image,price,sale_price,danhmuc_id,created_at) values('" + txtID.Text + "',N'" + txtName.Text + "',N'" + rtxtDesc.Text + "',N'" + rtxtBody.Text + "',N'" + pbImage.Text + "',N'" + txtPrice.Text + "',N'" + txtSalePrice.Text + "',N'" + int.Parse(cbCategory.Text) + "','" + DateTime.Now.Date.ToString("yyyy/MM/dd") + "')");
            if (connect_Model.check == true)
            {
                txtName.Clear();
                rtxtDesc.Clear();
                rtxtBody.Clear();
                //pbImage.Clear();
                txtPrice.Clear();
                txtSalePrice.Clear();

                MessageBox.Show("Thêm dữ liệu thành công");
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu không thành công");

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Connect_Model connect_Model = new Connect_Model();
            connect_Model.Execute("Delete from Products where id = '" + int.Parse(txtID.Text) + "'");
        }
        private void Load_data()
        {
            Connect_Model connect_Model = new Connect_Model();
            DataTable products = connect_Model.Query("Select * from SanPham");
            if (products != null)
            {
                dataGridView1.DataSource = products;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            rtxtDesc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            rtxtBody.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            pbImage.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtPrice.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtSalePrice.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            cbCategory.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
           
        }
    }
}
