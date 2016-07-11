namespace CarPlant
{
	class ToyotaCorollaSports : RearWheelDriveCar
	{
		public override string Name()
		{
			return "Toyota Corolla sports";
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
		}

		public override void TurnRight(int degrees)
		{
			_frontLeft.turnRight(degrees);
			_frontRight.turnRight(degrees);
		}
	}
}