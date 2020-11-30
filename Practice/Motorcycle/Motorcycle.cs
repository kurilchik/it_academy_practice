using System;
using System.Collections.Generic;
using System.Text;

namespace Motorcycle
{
    class Motorcycle
    {
        private int _vin;

        public int Vin
        {
            get { return _vin; }
            set { _vin = value; }
        }

        private int _model;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private string _manufacturer;

        public int Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; }
        }

        private int _yearOfIssue = 2020;

        public int YearOfIssue
        {
            get { return _yearOfIssue; }
            private set
        }

        private int _mileage;

        public int Mileage
        {
            get { return _mileage; }
            set { _mileage = value; }
        }



    }
}
