using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class SalaryCalculator
    {
       public int TaxesPercentage { get; }
        public int BonusPercentage { get; }
        public int TransportationAllowance { get; }
        public int EducationPackage { get; }
        internal SalaryCalculator(
           int taxes,
           int bonus,
           int transportation,
           int education)
            {
                TaxesPercentage = taxes;
                BonusPercentage = bonus;
                TransportationAllowance = transportation;
                EducationPackage = education;
            }

        public decimal Calculate(decimal baseSalary)
        {
            decimal salary = baseSalary;
            salary += baseSalary * BonusPercentage / 100;
            salary -= baseSalary * TaxesPercentage / 100;
            salary += TransportationAllowance;
            salary += EducationPackage;

            return salary;
        }
    }
}
