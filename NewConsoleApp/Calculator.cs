
namespace NewConsoleApp
{
    public class Calculator
    {
        /// <summary>
        /// Calculates the current value of a transaction.
        /// </summary>
        /// <param name="nominal"></param>
        /// <param name="priceTrade"></param>
        /// <param name="trcType"></param>
        /// <returns></returns>
        public double CurrentValueCalculation(double nominal, double priceTrade, TransactionType trcType)
        {
            double value = nominal * priceTrade;

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

        /// <summary>
        /// Calculates the profit and loss of a transaction.
        /// </summary>
        /// <param name="priceTrade"></param>
        /// <param name="priceOriginal"></param>
        /// <param name="nominal"></param>
        /// <returns></returns>
        public double ProfitLossCalculation(double priceTrade, double priceOriginal, double nominal)
        {
            double profitLoss = (priceTrade - priceOriginal) * nominal;

            return profitLoss;
        }
    }
}
