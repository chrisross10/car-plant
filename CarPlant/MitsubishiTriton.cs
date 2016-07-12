namespace CarPlant
{
	class Car : ICar
	{
		protected readonly ISteering Steering;
		protected readonly IDrive Drive;
		protected readonly string _name;

		public Car(string name, IDrive drive, ISteering steering)
		{
			Steering = steering;
			Drive = drive;
			_name = name;
		}

		public void TurnLeft(int degrees)
		{
			Steering.TurnLeft(degrees);
		}

		public void TurnRight(int degrees)
		{
			Steering.TurnRight(degrees);
		}

		public void Accelerate(int kph)
		{
			Drive.Accelerate(kph);
		}

		public string Name()
		{
			return _name;
		}
	}
}