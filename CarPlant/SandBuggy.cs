namespace CarPlant
{
	class SandBuggy : Car
	{
		private readonly FourWheelDrive _drive;
		private readonly Wheels _wheels;

		public SandBuggy(Wheels wheels, FourWheelDrive drive)
		{
			_drive = drive;
			_wheels = wheels;
		}

		public override string Name()
		{
			return "Sand Buggy";
		}

		public override void Accelerate(int kph)
		{
			_drive.Accelerate(kph);
		}

		public override void TurnLeft(int degrees)
		{
			_wheels.FrontLeft.turnLeft(degrees);
			_wheels.FrontRight.turnLeft(degrees);
			_wheels.RearLeft.turnRight(degrees);
			_wheels.RearRight.turnRight(degrees);
		}

		public override void TurnRight(int degrees)
		{
			_wheels.FrontLeft.turnRight(degrees);
			_wheels.FrontRight.turnRight(degrees);
			_wheels.RearLeft.turnLeft(degrees);
			_wheels.RearRight.turnLeft(degrees);
		}
	}
}