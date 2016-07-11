namespace CarPlant
{
	class RearWheelDrive
	{
		private static Wheels _wheels;

		public RearWheelDrive(Wheels wheels)
		{
			_wheels = wheels;
		}

		public void Accelerate(int kph)
		{
			_wheels.RearLeft.rotate(kph);
			_wheels.RearRight.rotate(kph);
		}
	}
}