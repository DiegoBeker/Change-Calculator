namespace change_calculator
{
    public class ChangeCalculator
    {
        public static List<int> CalculateChange(int total, int payment)
        {
            int Change = payment - total;

            int[] availableValues = {100, 50, 20, 10, 5, 2, 1};
            List<int> ChangeDetailed = new List<int>();

            foreach (int value in availableValues)
            {
                while (Change >= value)
                {
                    ChangeDetailed.Add(value);
                    Change -= value;
                }
            }

            return ChangeDetailed;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int total = 10;
            int payment = 100;

            List<int> Change = ChangeCalculator.CalculateChange(total, payment);

            Console.WriteLine("Change: ");
            foreach (int value in Change)
            {
                Console.WriteLine($"{value}");
            }
        }
    }
}
