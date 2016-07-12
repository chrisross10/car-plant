namespace CarPlant {
	public class CarPlant
	{
		public static string LOG;

		public static ICar makeToyotaCorolla()
		{
			var wheels = MakeWheels();
			return new Car("Toyota Corolla", new FrontWheelDrive(wheels), new FrontWheelSteering(wheels));
		}

		public static ICar makeToyotaCorollaSports()
		{
			return new Car("Toyota Corolla sports", new RearWheelDrive(MakeWheels()), new FrontWheelSteering(MakeWheels()));
		}

		public static ICar makeMitsubishiTriton()
		{
			var wheels = MakeWheels();
			return new Car("Mitsubishi Triton", new FourWheelDrive(wheels), new FrontWheelSteering(wheels));
		}

		public static ICar makeSandBuggy()
		{
			var wheels = MakeWheels();
			return new Car("Sand Buggy", new FourWheelDrive(wheels), new FourWheelSteering(wheels));
		}

		public static ICar makeSandBuggyLite()
		{
			var wheels = MakeWheels();
			return new Car("Sand Buggy Lite", new RearWheelDrive(wheels), new FourWheelSteering(MakeWheels()));
		}

		private static Wheels MakeWheels()
		{
			return new Wheels(new Wheel("front left"), new Wheel("front right"), new Wheel("rear left"), new Wheel("rear right"));
		}
	}
}