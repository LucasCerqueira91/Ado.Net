
using System;
using System.Data;
using System.Data.SqlClient;

namespace AdoNetExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = @"Server=localhost\MSSQLSERVER06;Database=Cliente;Trusted_Connection=True;";



            SqlConnection sqlConnection = new SqlConnection(connectionString);



            try
            {
                //string queryTable = "SELECT * FROM Client";
                //string queryValue = "SELECT Count(Name) FROM Client";
                //string queryInsert = @"
                //    IF NOT EXISTS (SELECT 1 FROM Client WHERE Name = 'Rodolfo')
                //    BEGIN
                //        INSERT INTO Client(Name) VALUES('Rodolfo');
                //    END



                //   IF NOT EXISTS(SELECT 1 FROM Client WHERE Name = 'Elker')
                //    BEGIN
                //        INSERT INTO Client(Name) VALUES('Elker');
                //    END



                //   IF NOT EXISTS(SELECT 1 FROM Client WHERE Name = 'Mateus')
                //    BEGIN
                //        INSERT INTO Client(Name) VALUES('Mateus');
                //    END



                //   IF NOT EXISTS(SELECT 1 FROM Client WHERE Name = 'Ricardo')
                //    BEGIN
                //        INSERT INTO Client(Name) VALUES('Ricardo');
                //    END



                //   IF NOT EXISTS(SELECT 1 FROM Client WHERE Name = 'Lucas')
                //    BEGIN
                //        INSERT INTO Client(Name) VALUES('Lucas');
                //    END



                //   IF NOT EXISTS(SELECT 1 FROM Client WHERE Name = 'Ana')
                //    BEGIN
                //        INSERT INTO Client(Name) VALUES('Ana');
                //    END";



                string addClient = "INSERT INTO DataClient1 (Client) VALUES ('Rodolfo'); " +
                   "INSERT INTO DataClient1 (Client) VALUES ('Elker'); " +
                   "INSERT INTO DataClient1 (Client) VALUES ('Mateus'); " +
                   "INSERT INTO DataClient1 (Client) VALUES ('Ricardo'); " +
                   "INSERT INTO DataClient1 (Client) VALUES ('Lucas'); " +
                   "INSERT INTO DataClient1 (Client) VALUES ('Ana'); " +
                   "INSERT INTO DataClient1 (Client) VALUES ('Robert'); ";

                string addFatura = "INSERT INTO DataFatura (Client) VALUES ('Rodolfo'); " +
                 "INSERT INTO DataClient1 (Client) VALUES ('Elker'); " +
                 "INSERT INTO DataClient1 (Client) VALUES ('Mateus'); " +
                 "INSERT INTO DataClient1 (Client) VALUES ('Ricardo'); " +
                 "INSERT INTO DataClient1 (Client) VALUES ('Lucas'); " +
                 "INSERT INTO DataClient1 (Client) VALUES ('Ana'); " +
                 "INSERT INTO DataClient1 (Client) VALUES ('Robert'); ";


                //string queryDelete = "DELETE FROM Client WHERE Name = 'Rodolfo'";
                // string queryUpdate = "UPDATE Client SET Name='Bonandi' WHERE Name = 'Elker'";



                //SqlCommand sqlCommandTable = new SqlCommand(queryTable, sqlConnection);
                //SqlCommand sqlCommandValue = new SqlCommand(queryValue, sqlConnection);
                SqlCommand sqlCommandInsert = new SqlCommand(addClient, sqlConnection);
                //SqlCommand sqlCommandDelete = new SqlCommand(queryDelete, sqlConnection);
                //SqlCommand sqlCommandUpdate = new SqlCommand(queryUpdate, sqlConnection);



                sqlConnection.Open();
                //SqlDataReader readerTable = sqlCommandTable.ExecuteReader();



                //    while (readerTable.Read())
                //    {
                //        Console.WriteLine($"Id: {readerTable["Id"]} - Name: {readerTable["Name"]}");
                //    }



                //    readerTable.Close();



                //    int readerValue = Convert.ToInt32(sqlCommandValue.ExecuteScalar());
                //    Console.WriteLine($"Número total de clientes: {readerValue}");



                int readerInsert = Convert.ToInt32(sqlCommandInsert.ExecuteNonQuery());
                //    Console.WriteLine($"Número de clientes Inseridos: {readerInsert}");



                //    int readerDelete = Convert.ToInt32(sqlCommandDelete.ExecuteNonQuery());
                //    Console.WriteLine($"Número de clientes Eliminados: {readerDelete}");



                //    int readerUpdate = Convert.ToInt32(sqlCommandUpdate.ExecuteNonQuery());
                //    Console.WriteLine($"Número de clientes Atualizados: {readerUpdate}");



                //    // Lança uma exceção
                //    // sqlConnection.Open();



                //    Console.WriteLine(sqlConnection.State);



                sqlConnection.Close();



                //    Console.WriteLine(sqlConnection.State);
                //}
                //catch (SqlException ex)
                //{
                //    Console.WriteLine(ex.Message);
                //}
                //catch (InvalidOperationException ex)
                //{
                //    Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sqlConnection.State.ToString().Equals("Open"))
                    sqlConnection.Close();



                if (sqlConnection.State.Equals(ConnectionState.Open))

                    sqlConnection.Close();
            }


        }
    }
}
