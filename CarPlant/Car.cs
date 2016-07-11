using System;

namespace CarPlant
{
	public abstract class Car
	{
		public abstract string Name ();
		public abstract void Accelerate(int kmsPerHour);
		public abstract void TurnLeft(int degrees);
		public abstract void TurnRight(int degrees);
	}
}