namespace CarPlant
{
	class FrontWheelSteering : ISteering
	{
		private readonly Wheels _wheels;

		public FrontWheelSteering(Wheels wheels)
		{
			_wheels = wheels;
		}

		public void TurnLeft(int degrees)
		{
			_wheels.FrontLeft.turnLeft(degrees);
			_wheels.FrontRight.turnLeft(degrees);
		}

		public void TurnRight(int degrees)
		{
			_wheels.FrontLeft.turnRight(degrees);
			_wheels.FrontRight.turnRight(degrees);
		}
	}
}