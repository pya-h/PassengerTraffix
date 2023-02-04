using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BehComponents;

namespace VehicleTraffix
{
    class Passenger
    {
        private string fullName, nationalID, vehicleModel;
        Plate plate;
        PersianDateTime date;
        TimeSpan entrance, exit;

        public Passenger(string fullName, string nationalID, string vehicleModel, Plate plate, PersianDateTime date,
            byte entranceHour, byte entranceMinute, byte exitHour, byte exitMinute)
        {
            this.FullName = fullName;
            this.NationalID = nationalID;
            this.Plate = plate;
            // TODO: create entrance and exit dates
            this.Entrance = new TimeSpan(entranceHour, entranceMinute, 0);
            this.Exit = new TimeSpan(exitHour, exitMinute, 0);
            this.Date = new PersianDateTime(date.Year, date.Month, date.Day);
            this.VehicleModel = vehicleModel;
        }

        public string VehicleModel
        {
            get { return this.vehicleModel; }
            set { this.vehicleModel = value; } // TODO: check value
        }

        public string FullName
        {
            get { return this.fullName; }
            set { this.fullName = value; } // TODO: check value
        }

        public string NationalID
        {
            get { return this.nationalID; }
            set { this.nationalID = value; }
        }

        public Plate Plate
        {
            get { return this.plate; }
            set { this.plate = value; }
        }

        public PersianDateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public TimeSpan Entrance
        {
            get { return this.entrance; }
            set { this.entrance = value; }
        }
        public TimeSpan Exit
        {
            get { return this.exit; }
            set { this.exit = value; }
        }

        public string ToString()
        {
            // TODO: complete this
            return string.Format("{0} به شماره ملی {1} صاحب وسیله نقلیه {2} به پلاک {3}", 
                this.FullName, this.NationalID, this.VehicleModel, this.Plate.ToString());
        }
    }
}
