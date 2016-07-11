namespace CarPlant
{
	class ToyotaCorollaSports : Car
	{
		private readonly Wheels _wheels;

		public ToyotaCorollaSports(Wheels wheels)
		{
			_wheels = wheels;
		}

		public override string Name()
		{
			return "Toyota Corolla sports";
		}

		public override void Accelerate(int kph)
		{
			_wheels.RearLeft.rotate(kph);
			_wheels.RearRight.rotate(kph);
		}

		public override void TurnLeft(int degrees)
		{
			_wheels.FrontLeft.turnLeft(degrees);
			_wheels.FrontRight.turnLeft(degrees);
		}

		public override void TurnRight(int degrees)
		{
			_wheels.FrontLeft.turnRight(degrees);
			_wheels.FrontRight.turnRight(degrees);
		}
	}
}