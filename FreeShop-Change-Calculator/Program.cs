namespace change_calculator
{
    public class ChangeCalculator
    {
        public static List<double> CalculateChange(double totalReais, double paymentReais, double exchangeRate)
        {
            double totalDollars = totalReais / exchangeRate;
            double paymentDollars = paymentReais / exchangeRate;
            double changeDollars = paymentDollars - totalDollars;
            changeDollars = Math.Ceiling(changeDollars * 100) / 100;

            Console.WriteLine($"Total Real: {totalReais} Total Dolar: {totalDollars}");
            Console.WriteLine($"Payment Real: {paymentReais} Payment Dolar: {paymentDollars}");
            Console.WriteLine($"ChangeDollar: {changeDollars}");

            double[] availableValues = [100, 50, 20, 10, 5, 2, 1, 0.5, 0.25, 0.10, 0.05, 0.01];
            List<double> changeDetailedDollars = new List<double>();

            foreach (double value in availableValues)
            {
                while (changeDollars >= value)
                {
                    changeDetailedDollars.Add(value);
                    changeDollars -= value;
                }
            }

            return changeDetailedDollars;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double totalReais = 37;
            double paymentReais = 50; 
            double EXCHANGE_RATE = 5.12;

            Console.WriteLine($"Exchange Rate: {EXCHANGE_RATE}");

            List<double> changeDollars = ChangeCalculator.CalculateChange(totalReais, paymentReais, EXCHANGE_RATE);

            Console.WriteLine("Change in dollars: ");
            foreach (double value in changeDollars)
            {
                Console.WriteLine($"{value}");
            }
        }
    }
}

