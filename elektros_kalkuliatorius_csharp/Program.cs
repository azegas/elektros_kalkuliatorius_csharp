public class Calculator
{
    public void Calculate()
    {
        Console.WriteLine("Enter watts:");

        // Step 1: Get the power consumption in watts (W) from the user
        string? input = Console.ReadLine();

        if (input == null)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        bool isParsed = double.TryParse(input, out double watts);

        if (!isParsed)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        Console.WriteLine($"You entered: {watts} watts");

        // Step 2: Convert watts to kilowatts (1 kW = 1000 W)
        double kilowatts = watts / 1000;

        // Step 3: Calculate the energy consumption in kilowatt-hours (kWh) assuming the device runs 24 hours a day
        double kwh_per_day = kilowatts * 24;

        // Step 4: Assume the cost of electricity is 0.22 euro cents per kWh
        double cost_per_kwh = 0.22;

        // Step 5: Calculate the cost for running the device for 24 hours daily, weekly, and monthly  

        double hourly_cost = kilowatts * cost_per_kwh;
        double daily_cost = hourly_cost * 24;
        double weekly_cost = daily_cost * 7;
        double monthly_cost = daily_cost * 30;  // Assuming 30 days in a month  
        double yearly_cost = daily_cost * 365;

        // Step 6: Print the results to the user
        Console.WriteLine($"Device power consumption: {kilowatts} kilowatts (kW)");
        Console.WriteLine($"Device hourly cost of running: {hourly_cost} eur");
        Console.WriteLine($"Device daily cost of running: {daily_cost} eur");
        Console.WriteLine($"Device monthly cost of running: {monthly_cost} eur");
        Console.WriteLine($"Device yearly cost of running: {yearly_cost} eur");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        calculator.Calculate();
    }
}
