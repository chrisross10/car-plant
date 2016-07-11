namespace CarPlant
{
	class FourWheelDrive : IDrive
	{
		private readonly Wheels _wheels;

		public FourWheelDrive(Wheels wheels)
		{
			_wheels = wheels;
		}

		public void Accelerate(int kph)
		{
			_wheels.FrontLeft.rotate(kph);
			_wheels.FrontRight.rotate(kph);
			_wheels.RearLeft.rotate(kph);
			_wheels.RearRight.rotate(kph);
		}
	}
}