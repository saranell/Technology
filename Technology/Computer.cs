using System;
namespace Technology
{
	public class Computer : AbstractEntity
	{
		public double Ram { get; set; }
		public double Storage { get; set; }
		public string OperatingSystem { get; set; }
		

		public Computer(int ram, int storage, string operatingSystem)
		{
			Ram = ram;
			Storage = storage;
			OperatingSystem = operatingSystem;
		}

		public double IncreaseRam(int n)
        {
			return Ram += n;
        }

		public double IncreaseStorage(int x)
        {
			return Storage += x;
        }
	}

}