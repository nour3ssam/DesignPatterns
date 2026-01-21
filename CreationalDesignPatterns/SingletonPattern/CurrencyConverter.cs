using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class CurrencyConverter
    {
        private IEnumerable<ExchangeRate> _rates;
        private CurrencyConverter()
        {
            LoadExchangeRates();
        }
        private static object _lock = new object();
        private static CurrencyConverter instance;
        public static CurrencyConverter Instance
        {
            get
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new CurrencyConverter();
                    }
                    return instance;
                }
            }
        }





        private void LoadExchangeRates()
        {
            Thread.Sleep(4000);
            _rates = new List<ExchangeRate>()
            {
               new ExchangeRate(baseCurrency: "USD" , targetCurrency: "EGP",rate : 47.38m),
               new ExchangeRate(baseCurrency: "SAR" , targetCurrency: "USD",rate : 0.27m),
               new ExchangeRate(baseCurrency: "SAR" , targetCurrency: "EGP",rate : 12.63m)
            };
        }


        public decimal Convert(string baseCurrency, string targetCurrency, decimal amount)
        {
            var exchangeRate = _rates.FirstOrDefault(b => b.BaseCurrency == baseCurrency
            && b.TargetCurrency == targetCurrency);

            return amount * exchangeRate.Rate;


        }
    }
}
