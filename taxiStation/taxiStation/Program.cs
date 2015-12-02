using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace taxiStation
{
    class Program
    {

        static void Main(string[] args)
        {
            string filePathInput = "C:\\Users\\Dzmitry_Rekuts\\Documents\\Visual Studio 2015\\Projects\\taxiStation\\taxiStation\\Cars.txt";
            string filePathOutput = "C:\\Users\\Dzmitry_Rekuts\\Documents\\Visual Studio 2015\\Projects\\taxiStation\\taxiStation\\ResultFile.txt";
            Util.fillCollection();
            bool status = true;

            while (status)
            {
                Console.WriteLine("Choose comand");
                Console.WriteLine(" '1'  - Show all cars");
                Console.WriteLine(" '2' - Add new car ");
                Console.WriteLine(" '3' - Calculate the price of all cars ");
                Console.WriteLine(" '4' - Add new cars from file.txt ");
                Console.WriteLine(" '5' - Write car collection in file.txt ");
                Console.WriteLine(" '6' - Sort cars by consumption ");
                Console.WriteLine(" '7' - Delete car by IdTaxi ");

                Console.WriteLine(" '0' - Exit ");

                string action = Console.ReadLine();

                switch (action)
                {
                    case "1":
                        Util.ShowCars();
                        break;

                    case "2":
                        Util.AddCar();
                        Util.ShowCars();
                        break;

                    case "3":
                        Console.WriteLine("Total price = $" + Util.GetTotalCost());
                        break;

                    case "4":
                        Util.AddCarFromFile(filePathInput);
                        Console.WriteLine("Data has been read from the file " + filePathInput);
                        break;

                    case "5":
                        Util.OutputDataInFile(filePathOutput);
                        Console.WriteLine("Data were added to the file " + filePathOutput);
                        break;

                    case "6":
                        Util.SortByConsumption();
                        Util.ShowCars();
                        break;

                    case "7":
                        try
                        {
                            Console.WriteLine("Please enter IdTaxi to delete car");
                            Util.ShowCars();

                            int IdCarDelete = Int32.Parse(Console.ReadLine());
                            Util.DeleteCar(IdCarDelete);
                        }
                        catch (System.FormatException formatExeption)
                        {
                            Console.WriteLine("==Error=====     Incorrect value!    =====Error==");
                        }
                        break;

                    case "0":
                        status = false;
                        break;
                    default:
                        Console.WriteLine("Unknown comand");
                        break;

                }

            }

            Util.SaveChanges(filePathInput, filePathOutput);

        }
    }
}
