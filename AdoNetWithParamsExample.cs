using System;
using System.Data;
using System.Data.SqlClient;



namespace AdoNetWithParamsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = @"Server=localhost\MSSQLSERVER05;Database=AdoNetExampleDB;Trusted_Connection=True;";



           SqlConnection sqlConnection = new SqlConnection(connectionString);



           try
            {
                string query = "";



               SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);



               sqlConnection.Open();



               SqlDataReader readerTable = sqlCommand.ExecuteReader();



               while (readerTable.Read())
                {
                    Console.WriteLine($"Id: {readerTable["Id"]} - Name: {readerTable["Name"]}");
                }



               sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sqlConnection.State.Equals(ConnectionState.Open))
                    sqlConnection.Close();
            }



       }
    }
}
