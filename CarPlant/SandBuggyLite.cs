namespace CarPlant
{
	class SandBuggyLite : ICar
	{
		private readonly ISteering _steering;
		private readonly IDrive _drive;

		public SandBuggyLite(ISteering steering, IDrive drive)
		{
			_steering = steering;
			_drive = drive;
		}

		public virtual string Name()
		{
			return "Sand Buggy Lite";
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