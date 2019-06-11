using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class EmployeeModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime JoiningDate { get; set; }
        public double Salary { get; set; }

        EmployeeModel(string Id, String Name, DateTime JoiningDate, double Salary)
        {
            this.Id = Id;
            this.Name = Name;
            this.JoiningDate = JoiningDate;
            this.Salary = Salary;
        }
        
    }
}
