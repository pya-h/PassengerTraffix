using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace PassengerTraffix
{

    class SQLiteInterface
    {

        const string CONNECTION_STRING = "Data Source=database.db;Version=3;New=True;Compress=True;datetimeformat=CurrentCulture";
        private static SQLiteInterface database = new SQLiteInterface();
        SQLiteConnection connection;

        public static string[] TABLE_HEADERS_EN = 
            { "fullName", "nationalID", "phonenumber", "targetUnit", "vehicleModel", "plate", "date", "entrance", "exit" };
        public static string[] TABLE_HEADERS_FA = 
            { "نام", "کد ملی", "شماره تلفن", "واحد مراجعه", "مدل خودرو", "پلاک", "تاریخ", "ورود", "خروج" };

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
        private void AlterOldTables()
        {
            try
            {
                // phone number and target unit columns:
                NewCommand("ALTER TABLE passengers ADD COLUMN phonenumber text").ExecuteNonQuery();
                NewCommand("ALTER TABLE passengers ADD COLUMN targetUnit text").ExecuteNonQuery();
                Console.WriteLine("phonenumber and targetUnit columns added to the old table.");

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void CreateTableIfNotExists() 
        {
            try
            {
                NewCommand("CREATE TABLE passengers(id INTEGER PRIMARY KEY AUTOINCREMENT,"
                    + "nationalID TEXT NOT NULL, phonenumber text, targetUnit text, " 
                    + "vehicleModel TEXT, fullName TEXT NOT NULL, "
                    + "plate TEXT, date DATE NOT NULL, entrance TIME, exit TIME)")
                    .ExecuteNonQuery();
                this.connection.Close();
                Console.WriteLine("Table created!");
            }
            catch (SQLiteException ex) 
            {
                Console.WriteLine(ex.Message);
                // make sure new fields (phonenumber and targetUnit) are added to the database.
                AlterOldTables();
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
            NewCommand("INSERT INTO `passengers` " +
                string.Format("({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", TABLE_HEADERS_EN[0], TABLE_HEADERS_EN[1], TABLE_HEADERS_EN[2],
                    TABLE_HEADERS_EN[3], TABLE_HEADERS_EN[4], TABLE_HEADERS_EN[5], TABLE_HEADERS_EN[6], passenger.Entering ? TABLE_HEADERS_EN[7] : TABLE_HEADERS_EN[8]) +
                string.Format(" VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
                    passenger.FullName, passenger.NationalID, passenger.Phonenumber,
                    passenger.TargetUnit, passenger.VehicleModel, passenger.Plate != null ? passenger.Plate.ToString() : null,
                    passenger.Date.ToStringFormat("yyyy/MM/dd"), passenger.Time))
                .ExecuteNonQuery();
            this.connection.Close();
        }

        public DataTable Fetch()
        {
            SQLiteCommand cmd = NewCommand(
                string.Format("SELECT {0}, {1}, {2}, {3}, {4}, {5}, {6}, TIME({7}) AS {7}," +
                    " TIME({8}) AS {8} FROM `passengers`;", TABLE_HEADERS_EN[0], TABLE_HEADERS_EN[1], TABLE_HEADERS_EN[2],
                        TABLE_HEADERS_EN[3], TABLE_HEADERS_EN[4], TABLE_HEADERS_EN[5], TABLE_HEADERS_EN[6], 
                        TABLE_HEADERS_EN[7], TABLE_HEADERS_EN[8]));

            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd.CommandText, this.connection))
            {
                DataTable result = new DataTable();
                adapter.Fill(result);
                this.connection.Close();

                return result;
            }

        }

        public void Save(DataTable newData)
        {
            NewCommand(string.Format("DELETE FROM {0}", newData.TableName)).ExecuteNonQuery();
            SQLiteCommand cmd = NewCommand(string.Format("SELECT * from {0}", newData.TableName));
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd.CommandText, this.connection))
            {
                adapter.Update(newData);
            }
            this.connection.Close();

        }
    }
}
