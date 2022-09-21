using System;
using System.Data;
using System.Data.SqlClient;



namespace SqlInjectionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = @"Server=localhost\MSSQLSERVER05;Database=AdoNetExampleDB;Trusted_Connection=True;";



           SqlConnection sqlConnection = new SqlConnection(connectionString);



           try
            {
                Console.Write("Introduza um nome para pesquisa: ");
                string name = Console.ReadLine();



               // Ana'; DELETE FROM Client; SELECT * FROM Client WHERE Name='



               if (name.ToLower().Contains("insert") || name.ToLower().Contains("delete"))
                    throw new Exception("Seu malandroooooo!");
                
                string queryTable = $"SELECT * FROM Client WHERE Name='{name}'";



               SqlCommand sqlCommandTable = new SqlCommand(queryTable, sqlConnection);



               sqlConnection.Open();
                SqlDataReader readerTable = sqlCommandTable.ExecuteReader();



               while (readerTable.Read())
                {
                    Console.WriteLine($"Id: {readerTable["Id"]} - Name: {readerTable["Name"]}");
                }



               readerTable.Close();
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
            catch (Exception ex)
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
