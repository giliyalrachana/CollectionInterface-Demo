using System;
using System.Collections.Generic;


namespace CollectionInterfaces
{
    class SmartPhone : IComparable<SmartPhone>
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int CompareTo(SmartPhone other)
        {
            if(other!=null)
            {
                this.Price.CompareTo(other);
            }
            else
            {
                throw new ArgumentException("object doesn't have price");
            }
        }

    }
}
