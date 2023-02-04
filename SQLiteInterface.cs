using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace VehicleTraffix
{

    class SQLiteInterface
    {

        const string CONNECTION_STRING = "Data Source=database.db;Version=3;New=True;Compress=True;datetimeformat=CurrentCulture";
        private static SQLiteInterface database = new SQLiteInterface();
        SQLiteConnection connection;

        public static string[] TABLE_HEADERS_EN = { "fullName", "nationalID", "vehicleModel", "plate", "date", "entrance", "exit" };
        public static string[] TABLE_HEADERS_FA = { "نام", "کد ملی", "مدل خودرو", "پلاک", "تاریخ", "ورود", "خروج" };
        public static SQLiteInterface Database { get { return SQLiteInterface.database; } }

        public SQLiteCommand NewCommand(string text)
        {
            this.connection = new SQLiteConnection(CONNECTION_STRING);
            this.connection.Open();
            if (this.connection.State != ConnectionState.Open)
                throw new DatabaseOutOfReachException();
            SQLiteCommand cmd = new SQLiteCommand(text);
            cmd.Connection = this.connection;
            return cmd;
        }
        public void CreateTableIfNotExists() 
        {
            try
            {
                NewCommand("CREATE TABLE passengers(id INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "nationalID TEXT NOT NULL, vehicleModel TEXT, fullName TEXT NOT NULL, plate TEXT NOT NULL, " +
                    "date DATE NOT NULL, entrance TIME NOT NULL, exit TIME NOT NULL)")
                    .ExecuteNonQuery();
                this.connection.Close();
                Console.WriteLine("Table created!");
            }
            catch (SQLiteException ex) 
            {
                Console.WriteLine(ex.Message);
            } 

        }

        private SQLiteInterface()
        {
            try
            {
                this.CreateTableIfNotExists();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }

        }

        public void Add(Passenger passenger)
        {
            this.connection = new SQLiteConnection(CONNECTION_STRING);
            this.connection.Open();
            if (this.connection.State != ConnectionState.Open)
                throw new DatabaseOutOfReachException();
            NewCommand(string.Format("INSERT INTO `passengers` " +
                "(nationalID, vehicleModel, fullName, plate, date, entrance, exit)" +
                " VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                    passenger.NationalID, passenger.VehicleModel, passenger.FullName, passenger.Plate.ToString(),
                    passenger.Date.ToShortDateString(),
                    passenger.Entrance, passenger.Exit))
                .ExecuteNonQuery();
            this.connection.Close();
        }

        public DataTable Fetch()
        {
            SQLiteCommand cmd = NewCommand(
                "SELECT fullName, nationalID, vehicleModel, plate, date, TIME(entrance) AS entrance, TIME(exit) AS exit FROM `passengers`;");

            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd.CommandText, this.connection))
            {
                DataTable result = new DataTable();
                adapter.Fill(result);
                return result;
            }
        }
    }
}
