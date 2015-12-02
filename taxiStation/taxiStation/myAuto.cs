using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxiStation
{
    class MyAuto
    {
        public MyAuto(string carBrand, string model, int dateOfProduction, string fuelType, double consumption, string color, int cost)
        {
            this.Model = model;
            this.CarBrand = carBrand;
            this.DateOfProduction = dateOfProduction;
            this.FuelType = fuelType;
            this.Consumption = consumption;
            this.Color = color;
            this.Cost = cost;

        }

        //default constructor
        public MyAuto()
        {
        }


        private string model;
        private string carBrand;
        private int dateOfProduction;
        private string fuelType;
        private double consumption;
        private string color;
        private int cost;

        public string Model { get; set; }
        public string CarBrand { get; set; }
        public int DateOfProduction { get; set; }
        public string FuelType { get; set; }
        public double Consumption { get; set; }
        public string Color { get; set; }
        public int Cost { get; set; }






    }
}
