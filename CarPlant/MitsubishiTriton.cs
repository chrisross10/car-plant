namespace CarPlant
{
	class MitsubishiTriton : Car
	{
		private readonly FourWheelDrive _drive;
		private readonly FrontWheelSteering _steering;

		public MitsubishiTriton(FourWheelDrive drive, FrontWheelSteering steering)
		{
			_drive = drive;
			_steering = steering;
		}

		public override string Name()
		{
			return "Mitsubishi Triton";
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