using System;
using System.Collections.Generic;
using System.Text;

namespace whatever
{
    internal class Kidney
    {
        public Kidney(bool isHealthy, string donorName)
        {
            IsHealthy = isHealthy;
            DonorName = donorName;
        }

        public bool IsHealthy { get; set; }
        public string DonorName { get; set; }


    }
}
