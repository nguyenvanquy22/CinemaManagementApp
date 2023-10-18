using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagementApp.Classes
{
    internal class DataProcessor
    {
        string sqlConnectStr = "Data Source=LAPTOP-\\SQLEXPRESS;Initial Catalog=DBCinemaManagement;User ID=sa;Password=";
        SqlConnection sqlConn = null;

        //PT mở kết nối
        void OpenConncect()
        {
            sqlConn = new SqlConnection(sqlConnectStr);
            if (sqlConn.State != ConnectionState.Open)
                sqlConn.Open();
        }

        //PT đóng kết nối
        void CloseConnect()
        {
            if (sqlConn.State != ConnectionState.Closed)
            {
                sqlConn.Close();
                sqlConn.Dispose();
            }
        }

        //PT thực hiện lệnh dạng insert, update, delete
        public void ChangeData(string sql)
        {
            OpenConncect();
            SqlCommand sqlCmm = new SqlCommand();
            sqlCmm.Connection = sqlConn;
            sqlCmm.CommandText = sql;
            sqlCmm.ExecuteNonQuery();
            sqlCmm.Dispose();
            CloseConnect();
        }

        //PT thực hiện lệnh select
        public DataTable ReadData(string sqlSelect)
        {
            DataTable dt = new DataTable();
            OpenConncect();
            SqlDataAdapter sqldata = new SqlDataAdapter(sqlSelect, sqlConn);
            sqldata.Fill(dt);
            CloseConnect();
            sqldata.Dispose();
            return dt;
        }
    }
}
