using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompaniesAssignment
{
    class Company : IComparable
    {
        private string name;
        private double netincome;
        private double opincome;
        private double totalassests;
        private int employees;
        private string buyers;


       public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Netincome
        {
            get { return netincome; }
            set {  netincome = value; }
        }

        public double Opincome
        {
            get { return opincome; }
            set { opincome = value; }
        }

        public double Totalassests
        {
            get { return totalassests; }
            set {  totalassests = value; }
        }

        public int Employees
        {
            get { return employees; }
            set { employees = value; }
        }

        public string Buyers
        {
            get { return buyers; }
            set { buyers = value; }
        }

        public Company() { }

        public int CompareTo(object other)
        {
            Company temp = (Company)other;
            return name.CompareTo(temp.name);
        }
    }
}
