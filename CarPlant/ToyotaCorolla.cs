namespace CarPlant
{
	class ToyotaCorolla : Car
	{
		private readonly FrontWheelDrive _drive;
		private readonly FrontWheelSteering _steering;

		public ToyotaCorolla(FrontWheelDrive drive, FrontWheelSteering steering)
		{
			_drive = drive;
			_steering = steering;
		}

		public override string Name()
		{
			return "Toyota Corolla";
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