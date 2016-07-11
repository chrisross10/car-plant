namespace CarPlant {
	public class CarPlant
	{
		public static string LOG;

		public static Car makeToyotaCorolla()
		{
			Wheels wheels = MakeWheels();
			return new ToyotaCorolla(new FrontWheelDrive(wheels), new FrontWheelSteering(wheels));
		}

		public static Car makeToyotaCorollaSports()
		{
			return new ToyotaCorollaSports(new RearWheelDrive(MakeWheels()), new FrontWheelSteering(MakeWheels()));
		}

		public static Car makeMitsubishiTriton()
		{
			Wheels wheels = MakeWheels();
			return new MitsubishiTriton(new FourWheelDrive(wheels), new FrontWheelSteering(wheels));
		}

		public static Car makeSandBuggy()
		{
			var wheels = MakeWheels();
			return new SandBuggy(new FourWheelDrive(wheels), new FourWheelSteering(wheels));
		}

		public static Car makeSandBuggyLite()
		{
			var wheels = MakeWheels();
			return new SandBuggyLite(new FourWheelSteering(MakeWheels()), new RearWheelDrive(wheels));
		}

		private static Wheels MakeWheels()
		{
			return new Wheels(new Wheel("front left"), new Wheel("front right"), new Wheel("rear left"), new Wheel("rear right"));
		}
	}
}