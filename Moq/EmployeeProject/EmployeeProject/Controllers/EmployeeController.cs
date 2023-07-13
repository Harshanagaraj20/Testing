using EmployeeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeProject.Controllers
{
    
    public class EmployeeController : ApiController
    {
        //List<Employee> _employees;
        private readonly IEmployeeOperations _employeeOperations;

        public EmployeeController(IEmployeeOperations employeeOperations)
        {
            _employeeOperations = employeeOperations;
            //_employeeOperations = new EmployeeOperations(new EmployeeReader());

            //_employees = GetEmployees();
        }
        //public EmployeeController()
        //{

        //    _employeeOperations = new EmployeeOperations(new EmployeeReader());

        //    //_employees = GetEmployees();
        //}
        private List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee(1,"Tony Stark","CKPalle","Tirupati"),
                new Employee(2,"Bruce Banner","Chinamadula","Ananthapur"),
                new Employee(3,"Peter Parker","USA","Queens"),
                new Employee(4,"Thor","USA","Asgard"),
                new Employee(5,"Natasha","USA","NewYork"),
                new Employee(6,"Nick Fury","USA","Washington")
            };
        }

        // GET: api/Employee
        public IEnumerable<Employee> Get()
        {
            return _employeeOperations.GetExistingEmployees();
        }

        // GET: api/Employee/5
        public Employee Get(int id)
        {
            return _employeeOperations.GetSingleEmployee(id);
        }

        // POST: api/Employee
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Employee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Employee/5
        public void Delete(int id)
        {
        }
    }
}
