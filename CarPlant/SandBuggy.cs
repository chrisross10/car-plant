namespace CarPlant
{
	class SandBuggy : Car
	{
		private readonly FourWheelDrive _drive;
		private readonly FourWheelSteering _steering;

		public SandBuggy(FourWheelDrive drive, FourWheelSteering steering)
		{
			_drive = drive;
			_steering = steering;
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
			_steering.TurnLeft(degrees);
		}

		public override void TurnRight(int degrees)
		{
			_steering.TurnRight(degrees);
		}
	}
}