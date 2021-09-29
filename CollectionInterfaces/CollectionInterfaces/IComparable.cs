using System;
using System.Collections.Generic;

namespace CollectionInterfaces
{
    // This program demo. how to sort collection and IComparable Interface
    class IComparable
    {
        static void Main()
        {
            List<int> intList = new List<int> { 11, 4, 6, 22, 54 };
            intList.Sort();
            foreach (var num in intList)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();

                
        }
            
    }
}
