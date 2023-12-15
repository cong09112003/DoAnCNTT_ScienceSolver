using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows;

namespace Science_Solver.DBConnection
{
    public class DBconnection
    {
        public static DataTable getData(SqlConnection conn,string sqlStr)
        {
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);  
                //Log.Instance.Error(nameof(DBConnection), ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return new DataTable();
        }
        //Execute
        public static void Execute(SqlConnection conn, string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() <= 0)
                    throw new Exception();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Execute failed: \n" + ex);
                //Log.Instance.Error(nameof(DBConnection), ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
