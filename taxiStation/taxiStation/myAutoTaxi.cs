using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxiStation
{
    class MyAutoTaxi : MyAuto
    {

        public MyAutoTaxi(string carBrand, string model, int dateOfProduction, string fuelType, double consumption, string color, int cost, int idTaxi, int capacity) : base(model, carBrand, dateOfProduction, fuelType, consumption, color, cost)
        {
            this.IdTaxi = idTaxi;
            this.Capacity = capacity;
        }

        //default constructor
        public MyAutoTaxi()
        {
        }

        private int idTaxi;
        private int capacity;

        public int IdTaxi { get; set; }
        public int Capacity { get; set; }


    }
}
