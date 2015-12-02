using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace taxiStation
{
    class Util
    {
        public static ArrayList taxiCarsList = new ArrayList();
        public static void AddCar()
        {
            MyAutoTaxi newCar = new MyAutoTaxi();

            Console.WriteLine("Enter car brand");
            newCar.CarBrand = Console.ReadLine();
            Console.WriteLine("Enter car model");
            newCar.Model = Console.ReadLine();
            Console.WriteLine("Enter dateOfProduction");
            newCar.DateOfProduction = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter fuel type");
            newCar.FuelType = Console.ReadLine();
            Console.WriteLine("Enter Consumption");
            newCar.Consumption = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter color");
            newCar.Color = Console.ReadLine();
            Console.WriteLine("Enter car cost");
            newCar.Cost = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Id Taxi car");
            newCar.IdTaxi = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter car capacity");
            newCar.Capacity = Int32.Parse(Console.ReadLine());


            taxiCarsList.Add(newCar);

        }


        public static void DeleteCar(int id)
        {
            bool result = true;
            for (int i = 0; i < taxiCarsList.Count; i++)
            {
                MyAutoTaxi car = (MyAutoTaxi)taxiCarsList[i];

                if (car.IdTaxi.Equals(id))
                {

                    taxiCarsList.Remove(car);
                    Console.WriteLine("Car - " + car.Model + "  " + car.CarBrand + "  " + car.DateOfProduction + "  " + car.Color + ", Fuel Type - " + car.FuelType + "  " + car.Consumption + " Cost - " + car.Cost + "$ , Id - " + car.IdTaxi + ", Capacity -  " + car.Capacity + " DELETED");
                    result = false;
                }

            }
            if (result)
            {
                Console.WriteLine("Car with such id = "+id+" does not exist");
            }

        }

        public static void ShowCars()
        {
            foreach (MyAutoTaxi car in taxiCarsList)
            {
                Console.WriteLine("Car - " + car.Model + "  " + car.CarBrand + "  " + car.DateOfProduction + "  " + car.Color + ", Fuel Type - " + car.FuelType + "  " + car.Consumption + " Cost - " + car.Cost + "$ , Id - " + car.IdTaxi + ", Capacity -  " + car.Capacity);
            }
        }

        public static int GetTotalCost()
        {
            int totalCost = 0;
            foreach (MyAutoTaxi car in taxiCarsList)
            {
                totalCost += car.Cost;
            }
            return totalCost;
        }

        public static void SortByConsumption()
        {
            taxiCarsList.Sort(sortConsumption());

        }

        public static IComparer sortConsumption()
        {
            return (IComparer)new sortConsumptionHelper();
        }

        private class sortConsumptionHelper : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                MyAutoTaxi c1 = (MyAutoTaxi)a;
                MyAutoTaxi c2 = (MyAutoTaxi)b;
                if (c1.Consumption > c2.Consumption)
                    return 1;
                if (c1.Consumption < c2.Consumption)
                    return -1;
                else
                    return 0;
            }
        }


        //temp Method to fill Collection
        public static void fillCollection()
        {
            MyAutoTaxi car0 = new MyAutoTaxi("BMW", "X5", 2010, "diesel", 8.3, "black", 50000, 1, 4);
            MyAutoTaxi car1 = new MyAutoTaxi("AUDI", "A4", 2009, "diesel", 7.5, "white", 25000, 2, 4);
            MyAutoTaxi car2 = new MyAutoTaxi("BMW", "X6", 2012, "diesel", 9.5, "black", 60000, 3, 4);
            MyAutoTaxi car3 = new MyAutoTaxi("Opel", "Astra", 2008, "diesel", 6.3, "green", 15000, 4, 4);
            MyAutoTaxi car4 = new MyAutoTaxi("Mersedes-Benz", "CLS", 2013, "diesel", 7.2, "red", 33000, 5, 4);
            MyAutoTaxi car5 = new MyAutoTaxi("BMW", "X5", 2010, "diesel", 8.3, "black", 50000, 6, 4);

            taxiCarsList.Add(car0);
            taxiCarsList.Add(car1);
            taxiCarsList.Add(car2);
            taxiCarsList.Add(car3);
            taxiCarsList.Add(car4);
            taxiCarsList.Add(car5);

        }

        public static void AddCarFromFile(String filepath)
        {
            string[] lines = System.IO.File.ReadAllLines(@filepath);

            for (int i = 0; i < lines.Length; i++)
            {
                MyAutoTaxi newFileCar = new MyAutoTaxi();
                string[] carData = lines[i].Split(new Char[] { ',' });

                newFileCar.CarBrand = carData[1];
                newFileCar.Model = carData[0];
                newFileCar.DateOfProduction = Int32.Parse(carData[2]);
                newFileCar.FuelType = carData[3];
                newFileCar.Consumption = Double.Parse(carData[4]);
                newFileCar.Color = carData[5];
                newFileCar.Cost = Int32.Parse(carData[6]);
                newFileCar.IdTaxi = Int32.Parse(carData[7]);
                newFileCar.Capacity = Int32.Parse(carData[8]);

                taxiCarsList.Add(newFileCar);
            }
        }

        public static void OutputDataInFile(String filepath)
        {
            using (StreamWriter outputFile = new StreamWriter(@filepath))
            {
                foreach (MyAutoTaxi car in taxiCarsList)
                {
                    string result = car.CarBrand + ", " + car.Model + ", " + car.DateOfProduction + ", " + car.FuelType + ", " + car.Consumption + ", " + car.Color + ", " + car.Cost + ", " + car.IdTaxi + ", " + car.Capacity;

                    outputFile.WriteLine(result);
                }
                outputFile.Close();
            }

            Console.WriteLine("Done! File " + filepath + " is changed ");
        }

        public static void SaveChanges(string inputFile, string outputFile)
        {
            Console.WriteLine("Do you  want to save changes? (y/n)");

            string answer;
            string pattern = "^yes$|^no$";
            do
            {
                Console.WriteLine("'yes' - Save & Exit / 'no' - Exit without saving");
                answer = Console.ReadLine();
            } while (Regex.IsMatch(answer, pattern) == false);

            if (answer.Equals("yes"))
            {
                Util.OutputDataInFile(inputFile);
                Util.OutputDataInFile(outputFile);
            }
            else
            {
                Console.WriteLine("Goodbye");
            }

            Console.ReadLine();
        }
    }
}


