using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Practice.Services
{
    class PaypalPaymentService : IMensalPayment
    {
        public List<double> MensalPayment(double value, int quotes)
        {
            double quotesValues = value / quotes;
            double result = 0;
            List<double> results = new List<double>();

            for (int i = 1; i <= quotes; i++)
            {
                result = quotesValues + (quotesValues * (0.01 * i));
                result += result * 0.02;
                results.Add(result);
            }

            return results;
        }
    }
}
