using System;
using System.Collections.Generic;

namespace CollectionInterfaces
{
    class SortDisplay:IComparer<Display>
    {
        public int Compare(Display x,Display y)
        {
            return x.PPI.CompareTo(y, PPI); 
        }
    }
    class Display
    {
        // pixels per inches
        public int PPI { get; set; }
        public string Resolution { get; set; }
        public string Size { get; set; }
    }
}
