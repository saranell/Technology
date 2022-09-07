using System;
namespace Technology
{
	public class Computer
	{
		public double Ram { get; set; }
		public double Storage { get; set; }
		public string OperatingSystem { get; set; }
		

		public Computer(double ram, double storage, string operatingSystem)
		{
			Ram = ram;
			Storage = storage;
			OperatingSystem = operatingSystem;
		}

		public double IncreaseRam(double extraRam)
        {
			return Ram += extraRam;
        }

		public double IncreaseStorage(double extraStorage)
        {
			return Storage += extraStorage;
        }
	}

}