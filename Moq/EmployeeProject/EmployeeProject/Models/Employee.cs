using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeProject.Models
{
    public class Employee
    {
        public Employee()
        {

        }
        public Employee(int id, string name, string country, string city)
        {
            this.EmployeeId = id;
            this.Name = name;
            this.Country = country;
            this.City = city;
        }
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    }
}