namespace CarPlant
{
	public class SandBuggy : FourWheelDriveCar
	{
		public override string Name()
		{
			return "Sand Buggy";
		}

		public override void Accelerate(int kph)
		{
			_frontLeft.rotate(kph);
			_frontRight.rotate(kph);
			_rearLeft.rotate(kph);
			_rearRight.rotate(kph);
		}
	}
}