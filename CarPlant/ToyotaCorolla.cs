namespace CarPlant
{
	class ToyotaCorolla : FrontWheelDriveCar
	{
		public override string Name()
		{
			return "Toyota Corolla";
		}

		public override void Accelerate(int kph)
		{
			_frontLeft.rotate(kph);
			_frontRight.rotate(kph);
		}
	}
}