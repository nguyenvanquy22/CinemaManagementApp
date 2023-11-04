using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagementApp.Classes
{
    internal class Functions
    {
        DataProcessor dataBase = new DataProcessor();
        public string SinhMaTuDong(string TenBang, string TruongMa, string MaBatDau)
        {
            int id = 0;
            bool dung = false;
            string ma = "";
            DataTable dm = new DataTable();
            while (dung == false)
            {
                dm = dataBase.ReadData("Select * from " + TenBang + " where " + TruongMa + "='" + MaBatDau +
                    id.ToString() + "'");
                if (dm.Rows.Count == 0)
                {
                    dung = true;
                }
                else
                {
                    id++;
                    dung = false;
                }
            }
            ma = MaBatDau + id.ToString();
            return ma;
        }
    }
}
