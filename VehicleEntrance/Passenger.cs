using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BehComponents;

namespace VehicleTraffX
{
    class Passenger
    {
        private string fullName, nationalID, vehicleModel;
        Plate plate;
        PersianDateTime entranceDate, exitDate;

        public Passenger(string fullName, string nationalID, string vehicleModel, Plate plate, PersianDateTime date,
            byte entranceHour, byte entranceMinute, byte exitHour, byte exitMinute)
        {
            this.FullName = fullName;
            this.NationalID = nationalID;
            this.Plate = plate;
            // TODO: create entrance and exit dates
            //TimeSpan entranceTime = new TimeSpan(entranceHour, entranceMinute, 0),
            //    exitTime = new TimeSpan(exitHour, exitMinute, 0);
            this.EntranceDate = new PersianDateTime(date.Year, date.Month, date.Day, entranceHour, entranceMinute, 0);
            this.ExitDate = new PersianDateTime(date.Year, date.Month, date.Day, exitHour, exitMinute, 0);
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

        public PersianDateTime EntranceDate
        {
            get { return this.entranceDate; }
            set { this.entranceDate = value; }
        }
        public PersianDateTime ExitDate
        {
            get { return this.exitDate; }
            set { this.exitDate = value; }
        }

        public string ToString()
        {
            // TODO: complete this
            return string.Format("{0} به شماره ملی {1} صاحب وسیله نقلیه {2} به پلاک {3}", 
                this.FullName, this.NationalID, this.VehicleModel, this.Plate.ToString());
        }
    }
}
