namespace HRLib
{
    public abstract class Employee
    {
        private static int counter = 1000;
        public string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public string address;

		public  string Address
		{
			get { return  address; }
			set {  address = value; }
		}

       public Employee()
        {
            counter++;
          
            Name = "NA";
            Address = "NA";
        }

        public Employee(string name,string address)
		{
			this.Name = name;
			this.Address = address;
		}
		public abstract double CalculateSalary();

        public override string ToString()
        {
            return $" Name: {Name}, Address: {Address}";
        }


    }
}
