using Interfaces_Practice.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Practice.Services
{
    class PaymentService
    {
        private IMensalPayment _payment;

        public PaymentService(IMensalPayment payment)
        {
            _payment = payment;
        }

        public void ProcessPayment(Contract contract, int installments)
        {
            List<double> resultados = _payment.MensalPayment(contract.ContractValue, installments);

            for (int i = 0; i < installments; i++)
            {
                Console.Write(contract.ContractDate.AddMonths(i).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) + " - ");
                for (int j = i; j == i; j++)
                {
                    Console.Write(resultados[i] + "\n");
                }
            }

        }
    }
}
