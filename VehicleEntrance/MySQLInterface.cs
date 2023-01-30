using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace VehicleTraffX
{

    class MySQLInterface
    {
        const string CONNECTION_STRING = @"server=localhost;userid=root;password=;database=passengers;Convert Zero Datetime=True;";
        private static MySQLInterface database = new MySQLInterface();
        MySqlConnection connection;
        MySqlCommand command;

        public static string[] TABLE_HEADERS_EN = { "fullName", "nationalID", "vehicleModel", "plate", "entranceDate", "exitDate" };
        public static string[] TABLE_HEADERS_FA = { "نام", "کد ملی", "مدل خودرو", "پلاک", "تاریخ ورود", "تاریخ خروج" };
        public static MySQLInterface Database { get { return MySQLInterface.database; } }

        public void CreateDatabaseIfNotExists() {
            MySqlConnection testConnection = new MySqlConnection();
            
            MySqlCommand testCommand = new MySqlCommand();
            bool tableExists = true;
            try
            {
                testConnection.ConnectionString = @"server=localhost;userid=root;password=;Convert Zero Datetime=True;";
                testConnection.Open();
                testCommand.CommandText = "CREATE DATABASE `passengers`;";
                testCommand.Connection = testConnection;
                testCommand.ExecuteNonQuery();
                Console.WriteLine("Database created!");
                tableExists = false;
            }
            catch(MySqlException ex) {
                Console.WriteLine("Database existance check completed!");

            }
            testConnection.Close();
            if(!tableExists)
            {
                try
                {
                    testConnection.ConnectionString = CONNECTION_STRING;
                    testConnection.Open();
                    testCommand.CommandText = "CREATE TABLE passengers(id INTEGER PRIMARY KEY AUTO_INCREMENT," +
                        "nationalID TEXT NOT NULL, vehicleModel TEXT, fullName TEXT NOT NULL, plate TEXT NOT NULL, " +
                        "entranceDate DATETIME NOT NULL,exitDate DATETIME NOT NULL)";

                    testCommand.Connection = testConnection;
                    testCommand.ExecuteNonQuery();
                    testConnection.Close();
                    Console.WriteLine("Table created!");
                }
                catch (MySqlException ex) 
                {
                    Console.WriteLine(ex.Message);
                } 
            }

        }

        private MySQLInterface()
        {
            try
            {
                this.CreateDatabaseIfNotExists();
                this.command = new MySqlCommand();

                this.connection = new MySqlConnection(CONNECTION_STRING);

                this.connection.Open();
                this.command.Connection = this.connection;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }

        }

        public void Add(Passenger passenger)
        {
            if (this.connection.State != ConnectionState.Open)
                throw new DatabaseOutOfReachException();
            this.command.CommandText = string.Format("INSERT INTO `passengers` " +
                "(nationalID, vehicleModel, fullName, plate, entranceDate, exitDate)" +
                " VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                    passenger.NationalID, passenger.VehicleModel, passenger.FullName, passenger.Plate.ToString(),
                    passenger.EntranceDate.ToString(),
                    passenger.ExitDate.ToString());
            // is it needed to change sql TABLE datetime => string/ *******************
                
            this.command.ExecuteNonQuery();
            
        }

        public DataTable Fetch()
        {
            if (this.connection.State != ConnectionState.Open)
                throw new DatabaseOutOfReachException();
            this.command.CommandText = "SELECT fullName, nationalID, vehicleModel, plate, entranceDate, exitDate FROM `passengers`;";
            //this.command.Connection = this.connection;
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(this.command.CommandText, this.connection))
            {
                DataTable result = new DataTable();
                
                adapter.Fill(result);

                return result;
            }
        }
    }
}
