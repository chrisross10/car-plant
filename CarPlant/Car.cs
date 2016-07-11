using System;

namespace CarPlant
{
	public abstract class Car
	{
		public Wheel _frontLeft;
		public Wheel _frontRight;
		public Wheel _rearLeft;
		public Wheel _rearRight;

		public abstract string Name ();
		public abstract void Accelerate(int kmsPerHour);

		protected Car()
		{
			_frontLeft = new Wheel("front left");
			_frontRight = new Wheel("front right");
			_rearLeft = new Wheel("rear left");
			_rearRight = new Wheel("rear right");
		}

		public abstract void TurnLeft(int degrees);

		public abstract void TurnRight(int degrees);
	}
}