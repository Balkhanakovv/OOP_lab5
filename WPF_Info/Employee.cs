using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Info
{
    class Employee
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        private int _Age;

        public int Age
        {
            get { return _Age; }

            set
            {
                if (value > 17)
                    _Age = value;
            }
        }

        public string Company { get; set; }

        public Employee() {}

        public Employee(string Name, string Surname, int Age, string Company)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
            this.Company = Company;
        }
    }
}
