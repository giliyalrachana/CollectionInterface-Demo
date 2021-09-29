using System;
using System.Collections.Generic;

namespace CollectionInterfaces
{
    class Cars : IEnumerator<Car>
    {
        List<Cars> carList = new List<Car>();
        int position = -1;

        public Car this[int index]
        {
            get
            {
                return carList[index];

            }
            set
            {
                carList.Add

            }
        }
    }
    class Car
    {
        public int Year { get; set; }
        public string ModelName { get; set; }

    }
}
