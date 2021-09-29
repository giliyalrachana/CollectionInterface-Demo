using System;
using System.Collections.Generic;

namespace CollectionInterfaces
{
    // This class demo. how to use collection which implemets IEnumerator Interface
    class IEnumeratorDemo
    {
        static void Main()
        {
            Car car1 = new Car { Year = 2021, ModelName = "tata Indica" };
            Car car2 = new Car { Year = 2018, ModelName = "tata Nexon" };
            Car car3 = new Car { Year = 2015, ModelName = "tata Hexa" };

            Cars = new Cars();
            { 
            Cars[0] = car1;
            Cars[1] = car2;
            Cars[2] = car3;

            int index = 0;
            while (Cars.MoveNext())
            {
                var car = Cars[index];
                Console.WriteLine($"Model Year={car.Year}\nModel Name={car.ModelName}");
                index++;
            }
        }
               Console.ReadLine();   
        }
    }
}
