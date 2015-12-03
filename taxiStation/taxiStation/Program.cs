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
            string filePathInput = @".\Cars.txt";
            string filePathOutput = @".\ResultFile.txt";
            string binaryFile = @".\SuperHumanInfo.dat";
            // Util.fillCollection();
           // Util.AddCarFromFile(filePathInput);

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
                Console.WriteLine(" '8' - Save to binary file ");
                Console.WriteLine(" '9' - Read data from binary file ");
                Console.WriteLine(" 'f' - Temp method to fill car collection");

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

                    case "8":
                        Util.SaveWithBinarySerialization(binaryFile);
                        Console.WriteLine("Data saved");

                        break;

                    case "9":
                        try {
                            Util.ReadFromBinaryFile(binaryFile);
                            Console.WriteLine("Data has been read from the binary file " + binaryFile);
                        }
                        catch(System.IO.FileNotFoundException fnfEx)
                        {
                            Console.WriteLine("Binary file not found");
                        }
                        break;

                    case "f":
                        Util.fillCollection();
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
