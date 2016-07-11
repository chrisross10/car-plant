namespace CarPlant
{
	class ToyotaCorollaSports : Car
	{
		private readonly RearWheelDrive _drive;
		private readonly FrontWheelSteering _steering;

		public ToyotaCorollaSports(RearWheelDrive drive, FrontWheelSteering steering)
		{
			_drive = drive;
			_steering = steering;
		}

		public override string Name()
		{
			return "Toyota Corolla sports";
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