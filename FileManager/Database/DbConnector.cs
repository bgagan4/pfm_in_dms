using System;
using System.Configuration;
using System.Data;
using System.Windows;
using Oracle.ManagedDataAccess.Client;

namespace FileManager.Database
{
    public class DbConnector
    {
        private readonly OracleConnection _connection;

        public DbConnector()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString; ;
            _connection = new OracleConnection(connectionString);
        }

        public void TestConnection()
        {
            try
            {
                OpenConnection();
                MessageBox.Show("Successful :D");
            }
            catch (Exception)
            {
                MessageBox.Show("Failure :(  " + Environment.NewLine + " Could be an invalid connection string.");
            }
            finally
            {
                CloseConnection();
            }
        }

        private void OpenConnection()
        {
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
        }

        private void CloseConnection()
        {
            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        public IDataReader ExecuteReader(string sql)
        {
            IDataReader dataReader;
            var cmd = new OracleCommand(sql, _connection) {CommandType = CommandType.Text};
            OpenConnection();
            try
            {
                dataReader = cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                throw;
            }

            CloseConnection();
            return dataReader;
        }

    }
}
