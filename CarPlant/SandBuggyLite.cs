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
	}
}