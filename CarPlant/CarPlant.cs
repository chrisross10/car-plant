namespace CarPlant {
	public class CarPlant
	{
		public static string LOG;

		public static Car makeToyotaCorolla()
		{
			return new ToyotaCorolla(MakeWheels());
		}

		public static Car makeToyotaCorollaSports()
		{
			return new ToyotaCorollaSports(MakeWheels());
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
			return new SandBuggyLite(MakeWheels());
		}

		private static Wheels MakeWheels()
		{
			return new Wheels(new Wheel("front left"), new Wheel("front right"), new Wheel("rear left"), new Wheel("rear right"));
		}
	}
}