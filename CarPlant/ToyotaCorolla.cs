namespace CarPlant
{
	class ToyotaCorolla : Car
	{
		public Wheel _frontLeft;
		public Wheel _frontRight;
		public Wheel _rearLeft;
		public Wheel _rearRight;

		public ToyotaCorolla()
		{
			_frontLeft = new Wheel("front left");
			_frontRight = new Wheel("front right");
			_rearLeft = new Wheel("rear left");
			_rearRight = new Wheel("rear right");
		}

		public override string Name()
		{
			return "Toyota Corolla";
		}

		public override void Accelerate(int kph)
		{
			_frontLeft.rotate(kph);
			_frontRight.rotate(kph);
		}

		public override void TurnLeft(int degrees)
		{
			_frontLeft.turnLeft(degrees);
			_frontRight.turnLeft(degrees);
		}

		public override void TurnRight(int degrees)
		{
			_frontLeft.turnRight(degrees);
			_frontRight.turnRight(degrees);
		}
	}
}