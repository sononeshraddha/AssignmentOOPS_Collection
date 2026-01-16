using System;
using System.Text;

namespace HRLib
{
    public class ConfirmEmployee :Employee
    {
		private double basic;

		public double Basic
		{
			get { return basic; }
			set {

                
                    if (value < 5000)
                        throw new ArgumentOutOfRangeException(nameof(Basic), value,
                            "Basic salary must be at least 5000.");
                    basic = value;
                
                }
		}

		private string designation;

		public string Designation
		{
			get { return designation; }
			set { designation = value; }
		}

        public ConfirmEmployee() : base()
        {
            Basic = 5000;           
            Designation = "Associate";
        }
        public ConfirmEmployee(string name, string address, double basic, string designation)
                  : base(name, address)
           
        {
            
                Basic = basic;
			Designation = designation;
        }


        public sealed override double CalculateSalary()
        {
            double hra, conv, pf;

            if (Basic >= 30000)
            {
                hra = Basic * 0.30;


                conv = Basic * 0.30;
                pf = Basic * 0.10;
            }
            else if (Basic >= 20000)
            {
                hra = Basic * 0.20;
                conv = Basic * 0.20;
                pf = Basic * 0.10;

            }
            else
            {
                hra = Basic * 0.10;
                conv = Basic * 0.10;
                pf = Basic * 0.10;
            }

            double net = Basic + hra + conv - pf;
            return net;

        }

        public override string ToString()
        {
            return base.ToString()+ $" Designation: {Designation}, Basic: {Basic:F2}";
        }




    }
}
