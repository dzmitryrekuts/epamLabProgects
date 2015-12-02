using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = 1000;
            myArray myArrayList = new myArray(1000000);
            checkCollection(myArrayList, amount);

            myLinked myLinkedList = new myLinked(1000000);
            checkCollection(myLinkedList, amount);

            Console.ReadLine();

        }

        static void checkCollection(IMyList collection, int count)
        {
            middleObject middleObject = new middleObject();

            Console.WriteLine("Check collection  -  " + collection.GetName());
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            collection.AddEnd(count);
            stopWatch.Stop();
            Console.WriteLine("Time spent on the addition {0} objects to the end - {1} ms", count, stopWatch.ElapsedMilliseconds);
            stopWatch.Restart();
            collection.AddBegin(count);
            stopWatch.Stop();
            Console.WriteLine("Time spent on the addition {0} objects to the top - {1} ms", count, stopWatch.ElapsedMilliseconds);
            stopWatch.Restart();
            collection.AddMiddle(count);
            stopWatch.Stop();
            Console.WriteLine("Time spent on the addition {0} objects to the middle - {1} ms", count, stopWatch.ElapsedMilliseconds);
            stopWatch.Restart();
            collection.DeleteEnd(count);
            stopWatch.Stop();
            Console.WriteLine("Time spent on the removal {0} objects of the end of Collection- {1} ms", count, stopWatch.ElapsedMilliseconds);
            stopWatch.Restart();
            collection.DeleteMiddle(count);
            stopWatch.Stop();
            Console.WriteLine("Time spent on the removal {0} objects of the middle of collection- {1} ms", count, stopWatch.ElapsedMilliseconds);
            stopWatch.Restart();
            collection.DeleteBegin(count);
            stopWatch.Stop();
            Console.WriteLine("Time spent on the removal {0} objects of the top of collection- {1} ms", count, stopWatch.ElapsedMilliseconds);
            stopWatch.Restart();
            collection.GetMiddleElem(count, middleObject);
            stopWatch.Stop();
            Console.WriteLine("Time spent on the getting {0} objects from the middle of collection- {1} ms", count, stopWatch.ElapsedMilliseconds);
            Console.WriteLine("===============================================================================================");

        }


    }
}
