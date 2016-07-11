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
	}
}