using elektros_kalkuliatorius_csharp;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            // Initiate instances of classes
            Calculator calculator = new Calculator();
            Laiskanesys laiskanesys = new Laiskanesys();
            Gatherer gatherer = new Gatherer();

            // Gather user information
            double watts = gatherer.GetWatts();
            double hoursPerDay = gatherer.GetHoursPerDay();

            // Convert watts to kilowatts
            double kilowatts = calculator.WattsToKilowatts(watts);

            // Print user gathered info
            laiskanesys.WriteGatheredInfo(watts, kilowatts, hoursPerDay);

            // Calculate and display daily cost for specified hours
            double specificKwh = calculator.CalculateDailyKWh(kilowatts, hoursPerDay);
            double specificHourCost = calculator.CalculateCost(specificKwh);
            laiskanesys.WriteSpecificCostInfo(specificHourCost, hoursPerDay);

            // Calculate and display daily cost for 24/7
            double dailyKWh = calculator.CalculateDailyKWh(kilowatts, 24);
            double dailyCost = calculator.CalculateCost(dailyKWh);
            laiskanesys.WriteOverallCostInfo(dailyCost);

            Console.ReadKey(); // Keeps the console open until a key is pressed
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}