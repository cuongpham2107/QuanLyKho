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
    
    public partial class ThemSanPham : Form
    {
        public ThemSanPham()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connect_Model connect_Model = new Connect_Model();
            connect_Model.Execute("Insert into SanPham(name,description,body,image,price,sale_price,danhmuc_id,created_at) values(N'" + txtName.Text + "',N'" + rtxtDesc.Text + "',N'" + rtxtBody.Text + "',N'" + pbImage.Text + "',N'" + txtPrice.Text + "',N'" + txtSalePrice.Text + "',N'" + int.Parse(cbCategory.Text) + "','" + DateTime.Now.Date.ToString("yyyy/MM/dd") + "')");
            if(connect_Model.check == true)
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
        

    }
}
