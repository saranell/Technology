using System;
namespace Technology
{
    public class SmartPhone : Computer
    {
        public string Carrier { get; set; }
        public string[] Applications { get; set; }

        public SmartPhone(double ram, double storage, string operatingSystem, int softwareDate, string dimensions, string carrier, string[] applications) : base(ram, storage, operatingSystem)
        {
            Carrier = carrier;
            Applications = applications;
        }

        public string DownloadApplication()
        {
            //TODO: if an application is new, add to array
            if ()
        }
    }
}//here are some changes

