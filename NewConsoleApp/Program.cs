using System;

namespace NewConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the nominal of the trade:");
            string inputNominal = Console.ReadLine();
            double nominal = double.Parse(inputNominal);
            if (nominal <= 0)
            {
                throw new ArgumentException("Nominal should be positive");
            }

            Console.WriteLine("Input the price of the trade:");
            string inputPrice = Console.ReadLine();
            double price = double.Parse(inputPrice);
            if (price <= 0)
            {
                throw new ArgumentException("Price should be positive");
            }

            Console.WriteLine("Input the type of the trade:");
            string inputType = Console.ReadLine();
            var trcType = (TransactionType) Enum.Parse(typeof(TransactionType), inputType, true);

            // Different approach
            var currentValue = new CurrentValueCalc();
            var trcValue = currentValue.Calculation(nominal, price, trcType);

            // Standard approach
            //var currentValue = nominal * price;
            //var trcValue = trcType == TransactionType.Buy ? currentValue : (currentValue * -1);

            Console.WriteLine($"Current value of the transaction is {trcValue}");

        }
    }
}
