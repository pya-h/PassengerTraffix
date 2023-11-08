using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BehComponents;

namespace PassengerTraffix
{
    class Passenger
    {
        private string fullName, nationalID, vehicleModel, targetUnit, phonenumber;
        Plate plate;
        PersianDateTime date;
        TimeSpan time;
        private bool entering; //true: enter, false: exit

        public Passenger(string fullName, string nationalID, string phonenumber,
            string targetUnit, string vehicleModel, Plate plate, PersianDateTime date,
            short hour, short minute, bool entering)
        {
            this.FullName = fullName;
            this.NationalID = nationalID;
            this.Plate = plate;
            // TODO: create entrance and exit dates
            this.Time = new TimeSpan(hour, minute, 0);
            this.Entering = entering;
            this.Date = new PersianDateTime(date.Year, date.Month, date.Day);
            this.VehicleModel = vehicleModel;
            this.Phonenumber = phonenumber;
            this.TargetUnit = targetUnit;
        }

        public string TargetUnit
        {
            get { return this.targetUnit; }
            set { this.targetUnit = value; }
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

        public TimeSpan Time
        {
            get { return this.time; }
            set { this.time = value; }
        }

        public bool Entering
        {
            get { return this.entering; }
            set { this.entering = value; }
        }

        public string Phonenumber
        {
            get { return this.phonenumber; }
            set { this.phonenumber = value; }
        }
        public string ToString()
        {
            // TODO: complete this
            return this.VehicleModel != "" || this.Plate != null ? string.Format("{0} به شماره ملی {1} صاحب وسیله نقلیه {2} به پلاک {3}", 
                this.FullName, this.NationalID, this.VehicleModel, this.Plate.ToString()) :
                string.Format("{0} به شماره ملی {1}", this.FullName, this.NationalID);
        }

    }
}
