using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Practice.Services
{
    interface IMensalPayment
    {
        public List<double> MensalPayment(double value, int quotes);
    }
}
