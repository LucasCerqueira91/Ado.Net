using System;
using System.Data;
using System.Data.SqlClient;



namespace AdoNetWithParamsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = @"Server=localhost\MSSQLSERVER06;Database=Cliente;Trusted_Connection=True;";



            SqlConnection sqlConnection = new SqlConnection(connectionString);



            try
            {
                // Select
                string query = "GetDataClient1ByName";



                SqlParameter searchParam = new SqlParameter();
                searchParam.Direction = ParameterDirection.Input;
                searchParam.ParameterName = "@SearchParam";
                searchParam.Value = "Rodolfo";



                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(searchParam);




                sqlConnection.Open();



                SqlDataReader readerTable = sqlCommand.ExecuteReader();



                while (readerTable.Read())
                {
                    Console.WriteLine($"Id: {readerTable["Id"]} - Name: {readerTable["Client"]}");
                }



                sqlConnection.Close();




                // Insert
                //string queryInsert = "INSERT INTO Client (Name) VALUES (@NameParam)";



                //SqlCommand sqlCommandInsert = new SqlCommand(queryInsert, sqlConnection);
                //sqlCommandInsert.Parameters.AddWithValue("@NameParam", "Rodolfo");



                //sqlConnection.Open();



                //int readerInsert = Convert.ToInt32(sqlCommandInsert.ExecuteNonQuery());
                //Console.WriteLine($"Número de clientes Inseridos: {readerInsert}");



                //sqlConnection.Close();
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
