using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanlyKho
{
    public class Connect_Model
    {
        public Boolean check { get; set; } = false;
        SqlConnection sql = new SqlConnection(@"Data Source=.;Initial Catalog=QuanLyKhoHang;Integrated Security=True");
        
        public void openConnect()
        {
            if(sql.State == ConnectionState.Closed)
            {
                sql.Open();
            }    
        }
        public void closeConnect()
        {
            if( sql.State == ConnectionState.Open)
            {
                sql.Close();
            }
        }
        public Boolean Execute(string cmd)
        {
            openConnect();
            try
            {
                SqlCommand command = new SqlCommand(cmd, sql);
                command.ExecuteNonQuery();
                check = true;
            }
            catch (Exception)
            {
                check = false;
                throw;
            }
            closeConnect();
            return check;
        }
        public DataTable Query(string cmd)
        {
            openConnect();
            DataTable data = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(cmd, sql);
                SqlDataAdapter sqlData = new SqlDataAdapter(command);
                sqlData.Fill(data);
            }
            catch (Exception)
            {
                data = null;
                throw;
            }
            closeConnect();
            return data;
        }

    }
}
