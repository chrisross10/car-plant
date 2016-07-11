namespace CarPlant
{
	class MitsubishiTriton : Car
	{
		private readonly Wheels _wheels;
		private readonly FourWheelDrive _drive;

		public MitsubishiTriton(Wheels wheels, FourWheelDrive drive)
		{
			_wheels = wheels;
			_drive = drive;
		}

		public override string Name()
		{
			return "Mitsubishi Triton";
		}

		public override void Accelerate(int kph)
		{
			_drive.Accelerate(kph);
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