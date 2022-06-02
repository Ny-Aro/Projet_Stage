using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjetStage
{
    class DBAccess
    {
        private static SqlConnection connection = new SqlConnection();
        private static SqlCommand command = new SqlCommand();
        private static SqlDataAdapter adapter = new SqlDataAdapter();

        private static string strConnString = @"Data Source=(local);Initial Catalog=HistoriqueDB;Integrated Security=True";

        //Connect with Database
        public void createConn()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = strConnString;
                    connection.Open();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Close Database
        public void closeConn()
        {
            connection.Close();
        }

        //Insert Command
        public int executeQuery(SqlCommand command)
        {
            try
            {
                if (connection.State == 0)
                {
                    createConn();
                }
                command.Connection = connection;
                command.CommandType = CommandType.Text;

                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //DataGridView Adapter
        public void dataGridView(string query, DataTable tblName)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;

                adapter = new SqlDataAdapter(command);
                adapter.Fill(tblName);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
