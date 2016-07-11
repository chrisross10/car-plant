namespace CarPlant
{
	class FrontWheelDrive : IDrive
	{
		private readonly Wheels _wheels;

		public FrontWheelDrive(Wheels wheels)
		{
			_wheels = wheels;
		}

		public void Accelerate(int kph)
		{
			_wheels.FrontLeft.rotate(kph);
			_wheels.FrontRight.rotate(kph);
		}
	}
}