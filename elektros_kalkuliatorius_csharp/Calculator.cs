namespace elektros_kalkuliatorius_csharp
{
    class Calculator
    {
        private const double CostPerKWh = 0.22; // Use const for values that don't change.  Make it private.

        public double WattsToKilowatts(double watts)
        {
            return watts / 1000;
        }

        public double CalculateDailyKWh(double kilowatts, double hoursPerDay)
        {
            return kilowatts * hoursPerDay;
        }

        public double CalculateCost(double kwh)
        {
            return kwh * CostPerKWh;
        }
    }
}
