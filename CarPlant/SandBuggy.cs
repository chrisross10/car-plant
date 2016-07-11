namespace CarPlant
{
	public class SandBuggy : Car
	{
		private readonly Wheels _wheels;

		public SandBuggy(Wheels wheels)
		{
			_wheels = wheels;
		}

		public override string Name()
		{
			return "Sand Buggy";
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
			_wheels.RearLeft.turnRight(degrees);
			_wheels.RearRight.turnRight(degrees);
		}

		public override void TurnRight(int degrees)
		{
			_wheels.FrontLeft.turnRight(degrees);
			_wheels.FrontRight.turnRight(degrees);
			_wheels.RearLeft.turnLeft(degrees);
			_wheels.RearRight.turnLeft(degrees);
		}
	}
}