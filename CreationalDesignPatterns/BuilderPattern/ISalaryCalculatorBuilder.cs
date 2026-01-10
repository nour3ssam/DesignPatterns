using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal interface ISalaryCalculatorBuilder
    {
        ISalaryCalculatorBuilder AddTaxes(int taxesPercentage);
        ISalaryCalculatorBuilder AddBonus(int bonusPercentage);
        ISalaryCalculatorBuilder AddTransportation(int amount); 
        ISalaryCalculatorBuilder AddEducationPackage(int amount);
        SalaryCalculator Build();

    }
}
