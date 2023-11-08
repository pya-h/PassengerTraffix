using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PassengerTraffix
{
    class Plate
    {
        private short iranID; // 56
        private short firstSection, secondSection;
        private string letter;

        public Plate(short firstSection, string letter, short secondSection, short iranID)
        {
            this.FirstSection = firstSection;
            this.SecondSection = secondSection;
            this.Letter = letter;
            this.IranID = iranID;
            
        }

        public short IranID
        {
            get { return this.iranID; }
            set { this.iranID = value > 0 ? value : this.iranID; }
        }

        public short FirstSection
        {
            get { return this.firstSection; }
            set { this.firstSection = value > 0 ? value : this.firstSection; }
        }

        public short SecondSection
        {
            get { return this.secondSection; }
            set { this.secondSection = value > 0 ? value : this.secondSection; }
        }

        public string Letter
        {
            get { return this.letter; }
            set { this.letter = value; }
        }

        public string ToString()
        {
            return string.Format("{0} {1} {2} ایران {3}", this.FirstSection, this.Letter, this.SecondSection, this.IranID);
        }
    }
}
