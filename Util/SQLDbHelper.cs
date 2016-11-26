//=================================================
//
//	Copyright(C)2016Glf9832@163.com
//	All rights reserved
//	
//	filename:Util.SQLDbHelper.cs
//	description:
//
//	created by Glf9832@163.com at 2016/11/25 21:41:11
//	http://www.Glfsoft.com/
//
//=================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Util
{
    public class SQLDbHelper
    {
        public static bool SQL_Connection()
        {
            bool result = false;
            SqlConnection SqlConnect = new SqlConnection();
            try
            {
                SqlConnect.ConnectionString = "Data Source=PC201610251427;Initial Catalog=MyDb;User ID=sa;Password=123456;";
                SqlConnect.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("连接数据库失败\r\n" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (SqlConnect.State == ConnectionState.Open)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }
    }
}
