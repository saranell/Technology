using System;
namespace Technology
{
    public class SmartPhone : Computer
    {
        public List<Application> = new List<Applications>();
        public string Carrier { get; set; }
        public List<Application> Applications { get; set; }

        public SmartPhone(int ram, int storage, string operatingSystem, int softwareDate, string dimensions, string carrier, List<string> application) : base(ram, storage, operatingSystem)
        {
            Carrier = carrier;
            Applications = application;
        }

        //public List<Application> DownloadApp(Application app)
        //{
        //    Applications.Add(app);
        //    return Applications;
        //}
    }
}

