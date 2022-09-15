using System;
using System.Collections.Generic;
using System.Text;

namespace Firm.EmplpyeeTypes
{
    internal class Commission : Hourly
    {
        private double _totSales;
        private double _comissionRate;

        //-----------------------------------------------------------------
        // Sets up this comissions employee using the specified information.
        //---------
        public Commission(string eName, string eAddress, string ePhone,
            string socSecNumber, double hourlyRate, double comissionRate)
            :base(eName, eAddress, ePhone, socSecNumber, hourlyRate)
        {
            _totSales = 0;
            _comissionRate = comissionRate;
        }

        //-----------------------------------------------------------------
        // Computes and returns the pay for this hourly employee.
        //-----------------------------------------------------------------
        public override double Pay()
        {
            var payment = base.Pay();
            payment += _totSales * _comissionRate;
            return payment;
        }

        public void addSales(double totalSales) 
        { 
            _totSales += totalSales;
        }

        //-----------------------------------------------------------------
        // Returns information about this comission employee as a string.
        //-----------------------------------------------------------------
        public override string ToString()
        {
            var result = base.ToString();
            result += "\nTotalSales: " + _totSales;
            return result;
        }
    }
}
