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
            string inputPriceTrade = Console.ReadLine();
            double priceTrade = double.Parse(inputPriceTrade);
            if (priceTrade <= 0)
            {
                throw new ArgumentException("Price should be positive");
            }

            Console.WriteLine("Input the type of the trade:");
            string inputType = Console.ReadLine();
            var trcType = (TransactionType) Enum.Parse(typeof(TransactionType), inputType, true);

            if (trcType == TransactionType.Sell)
            {
                Console.WriteLine("Input the price of the original trade:");
                string inputPriceOriginal = Console.ReadLine();
                double priceOriginal = double.Parse(inputPriceOriginal);
                if (priceOriginal <= 0)
                {
                    throw new ArgumentException("Price should be positive");
                }

                var currentValueSell = new Calculator();
                var profitLossValue = currentValueSell.ProfitLossCalculation(priceTrade, priceOriginal, nominal);
                var trcValueSell = currentValueSell.CurrentValueCalculation(nominal, priceTrade, trcType);

                Console.WriteLine($"Current value of the transaction is {trcValueSell}");
                Console.WriteLine($"Profit and Loss of the transaction is {profitLossValue}");
            }
            else
            {
                var currentValueBuy = new Calculator();
                var trcValueBuy = currentValueBuy.CurrentValueCalculation(nominal, priceTrade, trcType);

                Console.WriteLine($"Current value of the transaction is {trcValueBuy}");
            }
        }
    }
}
