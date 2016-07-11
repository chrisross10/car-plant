namespace CarPlant
{
	public class Wheels
	{
		private readonly Wheel _frontLeft;
		private readonly Wheel _frontRight;
		private readonly Wheel _rearLeft;
		private readonly Wheel _rearRight;

		public Wheels(Wheel frontLeft, Wheel frontRight, Wheel rearLeft, Wheel rearRight)
		{
			_frontLeft = frontLeft;
			_frontRight = frontRight;
			_rearLeft = rearLeft;
			_rearRight = rearRight;
		}

		public Wheel FrontLeft
		{
			get { return _frontLeft; }
		}

		public Wheel FrontRight
		{
			get { return _frontRight; }
		}

		public Wheel RearLeft
		{
			get { return _rearLeft; }
		}

		public Wheel RearRight
		{
			get { return _rearRight; }
		}
	}
}