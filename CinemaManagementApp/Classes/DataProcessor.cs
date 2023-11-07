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
        string sqlConnectStr = "Data Source=LAPTOP-CFGTBTO6\\SQLEXPRESS;Initial Catalog=DBCinemaManagement;User ID=sa;Password=sa";
        SqlConnection sqlConn = null;

        //PT mở kết nối
        void OpenConnect()
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
            OpenConnect();
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
            OpenConnect();
            SqlDataAdapter sqldata = new SqlDataAdapter(sqlSelect, sqlConn);
            sqldata.Fill(dt);
            CloseConnect();
            sqldata.Dispose();
            return dt;
        }

        public SqlDataReader dataReader(string sql)
        {
            OpenConnect();
            SqlCommand sqlcomma = new SqlCommand();
            sqlcomma.Connection = sqlConn;
            sqlcomma.CommandText = sql;
            SqlDataReader dt = sqlcomma.ExecuteReader();
            CloseConnect();
            sqlcomma.Dispose();
            return dt;
        }
    }
}
