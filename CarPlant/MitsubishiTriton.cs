namespace CarPlant
{
	class MitsubishiTriton : Car
	{
		private readonly Wheels _wheels;

		public MitsubishiTriton(Wheels wheels)
		{
			_wheels = wheels;
		}

		public override string Name()
		{
			return "Mitsubishi Triton";
		}

		public override void Accelerate(int kph)
		{
			_wheels.FrontLeft.rotate(kph);
			_wheels.FrontRight.rotate(kph);
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