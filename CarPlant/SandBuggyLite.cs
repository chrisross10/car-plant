namespace CarPlant
{
	public class SandBuggyLite : RearWheelDriveCar
	{

		public override string Name()
		{
			return "Sand Buggy Lite";
		}

		public override void Accelerate(int kph)
		{
			_rearLeft.rotate(kph);
			_rearRight.rotate(kph);
		}

		public override void TurnLeft(int degrees)
		{
			_frontLeft.turnLeft(degrees);
			_frontRight.turnLeft(degrees);
			_rearLeft.turnRight(degrees);
			_rearRight.turnRight(degrees);
		}

		public override void TurnRight(int degrees)
		{
			_frontLeft.turnRight(degrees);
			_frontRight.turnRight(degrees);
			_rearLeft.turnLeft(degrees);
			_rearRight.turnLeft(degrees);
		}
	}
}