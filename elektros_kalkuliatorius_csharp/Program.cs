using System.Runtime.ConstrainedExecution;
public class Calculator
{

    // Assume the cost of electricity is 0.22 euro cents per kWh
    double cost_per_kwh = 0.22;
    public void Greeting()
    {
        Console.WriteLine("Hello, this is elektros kalkuliatorius\n");
    }
    public double GetWatts()
    {
        Console.WriteLine("Enter watts of your device:");
        string? input = Console.ReadLine();
        if (input == null)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return 0;
        }
        bool isParsed = double.TryParse(input, out double watts);
        if (!isParsed)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return 0;
        }
        Console.WriteLine($"You entered: {watts} watts");
        return watts;
    }

    public double GetKiloWatts(double watts)
    {
        double kilowatts = watts / 1000;
        return kilowatts;
    }

    public double GetKiloWattsPerDay(double kilowatts)
    {
        double kwh_per_day = kilowatts * 24;
        return kwh_per_day;
    }

    public double GetHourlyCost(double kilowatts)
    {
        double hourly_cost = kilowatts * cost_per_kwh;
        return hourly_cost;
    }

    public double GetDailyCost(double hourly_cost)
    {
        double daily_cost = hourly_cost * 24;
        return daily_cost;
    }

    public double GetWeeklyCost(double daily_cost)
    {
        double weekly_cost = daily_cost * 7;
        return weekly_cost;
    }

    public double GetMonthlyCost(double daily_cost)
    {
        double monthly_cost = daily_cost * 30;
        return monthly_cost;
    }

    public double GetYearlyCost(double daily_cost)
    {
        double yearly_cost = daily_cost * 365;
        return yearly_cost;
    }

}

public class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        // step 0: Greet the user
        calculator.Greeting();

        // step 1: Get the power consumption in watts (W) from the user
        double watts = calculator.GetWatts();

        // step 2: Convert watts to kilowatts (1 kW = 1000 W)
        double kilowatts = calculator.GetKiloWatts(watts);

        // step 3: Calculate the energy consumption in kilowatt-hours (kWh) assuming the device runs 24 hours a day
        double kwh_per_day = calculator.GetKiloWattsPerDay(kilowatts);

        // step 4: Calculate the cost of running the device for 1 hour, 24 hours daily, weekly, and monthly
        double hourly_cost = calculator.GetHourlyCost(kilowatts);
        double daily_cost = calculator.GetDailyCost(hourly_cost);
        double weekly_cost = calculator.GetWeeklyCost(daily_cost);
        double monthly_cost = calculator.GetMonthlyCost(daily_cost);
        double yearly_cost = calculator.GetYearlyCost(daily_cost);

        // Step 6: Print the results to the user
        Console.WriteLine($"Device power consumption: {kilowatts} kilowatts (kW)");
        Console.WriteLine($"Device hourly cost of running: {hourly_cost} eur");
        Console.WriteLine($"Device daily cost of running: {daily_cost} eur");
        Console.WriteLine($"Device monthly cost of running: {monthly_cost} eur");
        Console.WriteLine($"Device yearly cost of running: {yearly_cost} eur");
    }
}
