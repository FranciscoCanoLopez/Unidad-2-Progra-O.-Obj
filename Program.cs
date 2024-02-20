using physics_problem
;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculate the speed of a car");
        Console.WriteLine("Enter the distance traveled (in meters)");
        double distance = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter time (in seconds)");
        double time = Convert.ToDouble(Console.ReadLine());

        physical physical = new physical();
        double speed = physical.Calculate_Speed(distance, time);

        Console.WriteLine("The speed of the car is: " + speed + " meters per second.");
    }
}