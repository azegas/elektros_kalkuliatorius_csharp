using elektros_kalkuliatorius_csharp;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string watts = textBox1.Text;

            if (double.TryParse(watts, out double wattsInDouble))
            {
                // Parsing was successful
                Calculator calculator = new Calculator();
                double kilowatts = calculator.WattsToKilowatts(wattsInDouble);
                MessageBox.Show($"Result: {kilowatts} kWh");
            }
            else
            {
                // Parsing failed: the entered text is not a valid double
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
