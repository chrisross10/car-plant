namespace CarPlant
{
	class SandBuggyLite : Car
	{
		private readonly FourWheelSteering _steering;
		private readonly RearWheelDrive _drive;

		public SandBuggyLite(FourWheelSteering steering, RearWheelDrive drive)
		{
			_steering = steering;
			_drive = drive;
		}

		public override string Name()
		{
			return "Sand Buggy Lite";
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