//using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeProject;
using EmployeeProject.Models;

using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestLibrary
{
    [TestFixture]
    public class EmployeeTests
    {
        //private IEmployeeReader _employeeReader;
        //[UnitOfWork_StateUnderTest_ExpectedBehavior]
        //[Test]
        //public void SampleEmployeeTest_ToCheckTheLibrary_DryRun()
        //{
        //    //Assert.AreEqual(0, 0);
        //    Assert.That(0, Is.EqualTo(0));
        //}
        //[SetUp]
        //public void Setup()
        //{
        //   var employeeReader = new Mock<IEmployeeReader>();
        //}
       
        [Test]
        public void ListEmployee_FetchingAllEmployees_ShouldReadEmployeeReader()
        {
            var employeeReader = new Mock<IEmployeeReader>();
            var employeeOperations = new EmployeeOperations(employeeReader.Object);
            employeeOperations.GetExistingEmployees();
            employeeReader.Verify(e => e.GetAllEmployees());
           //we need to test 1. list of empl, 2. any exceptions, 3. browse throught the list and find the attributes of employee.
        }

        private IEmployeeReader GetListofAllEmployees()
        {
            var mockObject = new Mock<IEmployeeReader>();
            var listOfEmployees = new List<Employee>
            {
                new Employee(1,"Tony Stark","CKPalle","Tirupati"),
                new Employee(2,"Bruce Banner","Chinamadula","Ananthapur"),
                new Employee(3,"Peter Parker","USA","Queens"),
                new Employee(4,"Thor","USA","Asgard"),
                new Employee(5,"Natasha","USA","NewYork"),
                new Employee(6,"Nick Fury","USA","Washington")
            };
            var results = mockObject.Setup(m => m.GetAllEmployees()).Returns(listOfEmployees);
            return mockObject.Object;
        }
        [Test]
        public void ListEmployee_FetchingAllEmployees_ShouldListAllEmployees()
        {

            IEmployeeReader employeeReader = this.GetListofAllEmployees();
            Assert.IsTrue(employeeReader.GetAllEmployees().Count > 0);
            //we need to test 1. list of empl, 2. any exceptions, 3. browse throught the list and find the attributes of employee.
        }
    }
}
