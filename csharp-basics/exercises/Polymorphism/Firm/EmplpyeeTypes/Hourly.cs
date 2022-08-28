namespace Firm.EmplpyeeTypes
{
    public class Hourly : Employee
    {
        protected int hoursWorked;

        //-----------------------------------------------------------------
        // Sets up this hourly employee using the specified information.
        //-----------------------------------------------------------------
        public Hourly(string eName, string eAddress, string ePhone, string socSecNumber, double rate) : base(eName,
            eAddress, ePhone, socSecNumber, rate)
        {
            hoursWorked = 0;
        }

        //-----------------------------------------------------------------
        // Adds the specified number of hours to this employee's
        // accumulated hours.
        //-----------------------------------------------------------------
        public void AddHours(int moreHours)
        {
            hoursWorked += moreHours;
        }

        //-----------------------------------------------------------------
        // Computes and returns the pay for this hourly employee.
        //-----------------------------------------------------------------
        public override double Pay() { 

            var payment = payRate * hoursWorked;
        hoursWorked = 0;
            return payment;
        }

        //-----------------------------------------------------------------
        // Returns information about this hourly employee as a string.
        //-----------------------------------------------------------------
        public override string ToString()
        {
            var result = base.ToString();
            result += "\nCurrent hours: " + hoursWorked;
            return result;
        }
    }
}