namespace CarPlant
{
	class SandBuggyLite : Car
	{
		private readonly Wheels _wheels;
		private readonly FourWheelSteering _steering;

		public SandBuggyLite(Wheels wheels, FourWheelSteering steering)
		{
			_wheels = wheels;
			_steering = steering;
		}

		public override string Name()
		{
			return "Sand Buggy Lite";
		}

		public override void Accelerate(int kph)
		{
			_wheels.RearLeft.rotate(kph);
			_wheels.RearRight.rotate(kph);
		}

		public override void TurnLeft(int degrees)
		{
			_steering.TurnLeft(degrees);
		}

		public override void TurnRight(int degrees)
		{
			_steering.TurnRight(degrees);
		}
	}
}