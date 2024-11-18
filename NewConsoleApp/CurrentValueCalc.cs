
namespace NewConsoleApp
{
    public class CurrentValueCalc
    {
        private double Nominal { get; set;}
        private double Price { get; set; }
        private TransactionType TransactionType { get; set; }

        /// <summary>
        /// Calculates the current value of a transaction.
        /// </summary>
        /// <param name="nominal"></param>
        /// <param name="price"></param>
        /// <param name="trcType"></param>
        /// <returns></returns>
        public double Calculation(double nominal, double price, TransactionType trcType)
        {
            Nominal = nominal;
            Price = price;
            TransactionType = trcType;

            double value = nominal * price;

            if (trcType == TransactionType.Buy)
            {
                return value;
            }
            if (trcType == TransactionType.Sell)
            {
                value *= -1;
            }

            return value;
        }
    }
}
