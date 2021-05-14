using System;
using System.Collections.Generic;
using System.Text;

namespace laba3568
{
    class Birds
    {
        Bird[] data;
        public Birds()
        {
            data = new Bird[10];
        }
        public Bird this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
    }
}
