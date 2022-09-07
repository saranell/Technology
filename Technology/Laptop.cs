using System;
namespace Technology
{
    public class Laptop : Computer
    {
        public int SoftwareDate { get; set; }
        public string Dimensions { get; set; }

        public Laptop(double ram, double storage, string operatingSystem, int softwareDate, string dimensions) : base(ram, storage, operatingSystem)
        {
            SoftwareDate = softwareDate;
            Dimensions = dimensions;
        }

        public bool NeedsSoftwareUpdate()
        {
            if (SoftwareDate < 2017)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

