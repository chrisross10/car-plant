namespace CarPlant
{
	class ToyotaCorollaSports : ICar
	{
		private readonly IDrive _drive;
		private readonly ISteering _steering;

		public ToyotaCorollaSports(IDrive drive, ISteering steering)
		{
			_drive = drive;
			_steering = steering;
		}

		public virtual string Name()
		{
			return "Toyota Corolla sports";
		}

		public virtual void Accelerate(int kph)
		{
			_drive.Accelerate(kph);
		}

		public virtual void TurnLeft(int degrees)
		{
			_steering.TurnLeft(degrees);
		}

		public virtual void TurnRight(int degrees)
		{
			_steering.TurnRight(degrees);
		}
	}
}