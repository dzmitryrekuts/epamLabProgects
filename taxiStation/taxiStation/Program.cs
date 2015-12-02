using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace taxiStation
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("Choose comand");
            Console.WriteLine("1. ");
            Console.WriteLine("2. ");
            Console.WriteLine("3. ");
            Console.WriteLine("4. ");
            Console.WriteLine("5. ");
            string action =  Console.ReadLine();

            switch (action)
            {
                case "1":
                    Util.fillCollection();
                    break;
                case "2":
                    Util.fillCollection();
                    Util.ShowCars();
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                default:
                    break;

            }



            string filePath = "C:\\Users\\Dzmitry_Rekuts\\Documents\\Visual Studio 2015\\Projects\\taxiStation\\taxiStation\\Cars.txt";
            string resultFilePath = "C:\\Users\\Dzmitry_Rekuts\\Documents\\Visual Studio 2015\\Projects\\taxiStation\\taxiStation\\ResultFile.txt";

            Util.fillCollection();
           
            Util.ShowCars();
            Console.WriteLine("=================================================================");
            Util.AddCarFromFile(filePath);
            Util.ShowCars();
            Console.WriteLine("=================================================================");
            Util.SortByConsumption();
            Util.ShowCars();
            Util.OutputDataInFile(resultFilePath);

            Console.ReadLine();

        }
    }
}
