namespace CarPlant
{
	class FourWheelSteering : ISteering
	{
		private readonly Wheels _wheels;

		public FourWheelSteering(Wheels wheels)
		{
			_wheels = wheels;
		}

		public void TurnLeft(int degrees)
		{
			_wheels.FrontLeft.turnLeft(degrees);
			_wheels.FrontRight.turnLeft(degrees);
			_wheels.RearLeft.turnRight(degrees);
			_wheels.RearRight.turnRight(degrees);
		}

		public void TurnRight(int degrees)
		{
			_wheels.FrontLeft.turnRight(degrees);
			_wheels.FrontRight.turnRight(degrees);
			_wheels.RearLeft.turnLeft(degrees);
			_wheels.RearRight.turnLeft(degrees);
		}
	}
}