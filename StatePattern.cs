using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		TrafficLight lt = new TrafficLight();
		lt.light = new RedLight();
		while(true){
			lt.GetState();
			lt.SetState();
		}
	}
}

public interface ITrafficLight
{
	void GetLight();
	void SetLight(TrafficLight light);
}

public class TrafficLight
{
	public ITrafficLight light {get; set;}
	
	public void GetState()
	{
		light.GetLight();
	}
	
	public void SetState()
	{
		light.SetLight(this);
	}
}

public class GreenLight : ITrafficLight
{
	public void GetLight()
	{
		Console.WriteLine("Green Light");
	}
	
	public void SetLight(TrafficLight light)
	{
		light.light = new YellowLight();
	}
}

public class YellowLight : ITrafficLight
{
	public void GetLight()
	{
		Console.WriteLine("Yellow Light");
	}
	
	public void SetLight(TrafficLight light)
	{
		light.light = new RedLight();
	}
}

public class RedLight : ITrafficLight
{
	public void GetLight()
	{
		Console.WriteLine("Red Light");
	}
	
	public void SetLight(TrafficLight light)
	{
		light.light = new GreenLight();
	}
}
