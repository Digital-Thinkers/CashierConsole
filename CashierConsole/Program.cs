namespace CashierConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputAmount = GetInputAmount();

            if (inputAmount < 5)
            {
                Console.WriteLine($"Could not dispense cash: {inputAmount} Euro");
                return;
            }

            Dictionary<int, int> denominations = new Dictionary<int, int>()
            {
                { 200, 0 },
                { 100, 0 },
                { 50, 0 },
                { 20, 0 },
                { 10, 0 },
                { 5, 0 }
            };

            CalculateDispensedCash(inputAmount, denominations);

            if (!IsDispenseSuccessful(denominations))
            {
                Console.WriteLine($"Could not dispense cash: {inputAmount} Euro");
                return;
            }

            PrintDispensedCash(denominations);
        }

        private static int GetInputAmount()
        {
            int inputAmount;
            bool validInput = false;

            do
            {
                Console.WriteLine("Please enter the amount to be dispensed:");
                string input = Console.ReadLine();
                validInput = int.TryParse(input, out inputAmount);
            } while (!validInput);

            return inputAmount;
        }

        private static void CalculateDispensedCash(int inputAmount, Dictionary<int, int> denominations)
        {
            int remainingAmount = inputAmount;

            foreach (int denomination in denominations.Keys)
            {
                while (remainingAmount >= denomination)
                {
                    remainingAmount -= denomination;
                    denominations[denomination]++;
                }
            }
        }

        private static bool IsDispenseSuccessful(Dictionary<int, int> denominations)
        {
            return denominations.Values.Sum() > 0;
        }

        private static void PrintDispensedCash(Dictionary<int, int> denominations)
        {
            foreach (KeyValuePair<int, int> denomination in denominations)
            {
                Console.WriteLine($"{denomination.Key} Euro = {denomination.Value}");
            }
        }
    }
}
