using System;
using System.Text;

namespace HRLib
{
   public class Trainee:Employee
    {
		public int no_of_days;

		public int No_Of_Days
		{
			get { return no_of_days; }
			set { no_of_days = value; }
		}

		public double rate_per_day;

		public double Rate_Per_Day
		{
			get { return rate_per_day; }
			set { rate_per_day = value; }
		}

		public Trainee() :base()
		{

		}


        public Trainee(string name, string address, int noOfDays, double rate)
         : base(name, address)
        {
            No_Of_Days = noOfDays;
            Rate_Per_Day = rate;
        }


        public sealed override double CalculateSalary()
        {
            return No_Of_Days * Rate_Per_Day;
        }

        public override string ToString()
        {
            return base.ToString() + $"u Days: {No_Of_Days}, Rate/Day: {Rate_Per_Day:F2}";
        }


    }
}
