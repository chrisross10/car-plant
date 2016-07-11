using System;

namespace CarPlant
{
	public interface ICar : ISteering, IDrive
	{
		string Name();
	}
}