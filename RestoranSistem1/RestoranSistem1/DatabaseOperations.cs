using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RestoranSistem1
{
    class DatabaseOperations
    {
        public static bool runCommand(string query)
        {
            SqlCommand komut = new SqlCommand();
            if(DatabaseConnections.baglan.State == ConnectionState.Closed)
            {
                DatabaseConnections.baglan.Open();
            }
            try
            {
                komut.CommandText = query;
                komut.Connection = DatabaseConnections.baglan;
                komut.ExecuteNonQuery();
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("Bağlantı Hatası !"+e.Message);
                return false;
            }
            finally
            {
                DatabaseConnections.baglan.Close();
            }

        }
        public static DataTable GetData(string query)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, DatabaseConnections.baglan);
            da.Fill(dataTable);
            return dataTable;
        }
    }
}
