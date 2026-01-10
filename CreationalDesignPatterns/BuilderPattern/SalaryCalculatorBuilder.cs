using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class SalaryCalculatorBuilder : ISalaryCalculatorBuilder
    {
        private int _taxesPercentage;
        private int _bonusPercentage;
        private int _transportationAllowance;
        private int _educationPackage;
        public ISalaryCalculatorBuilder AddTaxes(int taxesPercentage)
        {
            _taxesPercentage = taxesPercentage;
            return this;
        }

        public ISalaryCalculatorBuilder AddBonus(int bonusPercentage)
        {
            _bonusPercentage = bonusPercentage;
            return this;
        }

        public ISalaryCalculatorBuilder AddTransportation(int amount)
        {
            _transportationAllowance = amount;
            return this;
        }

        public ISalaryCalculatorBuilder AddEducationPackage(int amount)
        {
            _educationPackage = amount;
            return this;
        }

        public SalaryCalculator Build()
        {
            return new SalaryCalculator(
                _taxesPercentage,
                _bonusPercentage,
                _transportationAllowance,
                _educationPackage
            );
        }
    }
}
