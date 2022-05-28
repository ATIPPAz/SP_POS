using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_POS.Classes
{
    public class Sql
    {
        private string connection = @"Server=0.tcp.ap.ngrok.io\SQLSERVER,12256;Database=ShopDB;User Id=user1;Password=mypass1;";
        public DataTable Select(string cmd)
        {
            Console.WriteLine(cmd);
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd,con))
                {
                    adapter.Fill(dt);
                }
                
            }
            return dt;
        }
        public void Update(string cmd, string[] column, object[] columnvalue)
        {
            Console.WriteLine(cmd);
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                using (SqlCommand sqlcmd = new SqlCommand(cmd, con))
                {
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    for (int i = 0; i < column.Length; i++)
                    {
                        sqlcmd.Parameters.AddWithValue(column[i], columnvalue[i]);
                        Console.WriteLine(column[i] +" : " +columnvalue[i]);
                    }
                    sqlcmd.ExecuteNonQuery();
                }
            }
        }
        public void Delete(string cmd, string column, object columnvalue)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                using (SqlCommand sqlcmd = new SqlCommand(cmd, con))
                {
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue(column, columnvalue);
                    sqlcmd.ExecuteNonQuery();
                }

            }
        }
        public void Insert(string cmd,string[] column,object[] columnvalue)
        {
            Console.WriteLine(cmd);

            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                using (SqlCommand sqlcmd = new SqlCommand(cmd, con))
                {
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    for (int i = 0; i < column.Length; i++)
                    {
                        sqlcmd.Parameters.AddWithValue(column[i], columnvalue[i]);
                    }
                    sqlcmd.ExecuteNonQuery();
                }

            }
        }
    }
}
