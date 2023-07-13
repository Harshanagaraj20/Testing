using EmployeeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeProject
{
    public interface IEmployeeReader
    {
        List<Employee> GetAllEmployees();
    }
    public interface IEmployeeOperations
    {
        List<Employee> GetExistingEmployees();
        Employee GetSingleEmployee(int employeeId);
    }

    public class EmployeeOperations : IEmployeeOperations
    {
        private readonly IEmployeeReader _employeeReader;
        public EmployeeOperations(IEmployeeReader employeeReader)
        {
            _employeeReader = employeeReader;
        }
        public List<Employee> GetExistingEmployees()
        {
            return _employeeReader.GetAllEmployees();
        }

        public Employee GetSingleEmployee(int employeeId)
        {
            var listOfEmployees = _employeeReader.GetAllEmployees();
            var emp = listOfEmployees.Where(x => x.EmployeeId == employeeId).FirstOrDefault();
            return emp != null ? emp : new Employee();
        }
    }
    public class EmployeeReader : IEmployeeReader
    {
        public List<Employee> GetAllEmployees()
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
    }
}