namespace CarPlant {
	public class CarPlant
	{
		public static string LOG;

		public static Car makeToyotaCorolla()
		{
			return new ToyotaCorolla(new Wheels(new Wheel("front left"), new Wheel("front right"), new Wheel("rear left"), new Wheel("rear right")));
		}

		public static Car makeToyotaCorollaSports()
		{
			return new ToyotaCorollaSports(new Wheels(new Wheel("front left"), new Wheel("front right"), new Wheel("rear left"), new Wheel("rear right")));
		}

		public static Car makeMitsubishiTriton()
		{
			return new MitsubishiTriton(new Wheels(new Wheel("front left"), new Wheel("front right"), new Wheel("rear left"), new Wheel("rear right")));
		}

		public static Car makeSandBuggy()
		{
			return new SandBuggy(new Wheels(new Wheel("front left"), new Wheel("front right"), new Wheel("rear left"), new Wheel("rear right")));
		}

		public static Car makeSandBuggyLite()
		{
			return new SandBuggyLite(new Wheels(new Wheel("front left"), new Wheel("front right"), new Wheel("rear left"), new Wheel("rear right")));
		}
	}
}