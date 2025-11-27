using System;
using System.Collections.Generic;
using System.Text;

namespace whatever
{
    internal class Clicker
    {
        public int Count;

        public Clicker(int count)
        {
            Count = count;
        }

        public void Click()
        {
            Count++;
        }
    }
}
