using elektros_kalkuliatorius_csharp;

namespace CalculatorTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestWattsToKilowattsConversion()
        {
            // Arrange
            double watts = 360;
            // Act
            try
            {
                double kilowatts = new Calculator().WattsToKilowatts(watts);
                // Assert
                Assert.AreEqual(0.36, kilowatts);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
