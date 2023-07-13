using DryIoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeProject.App_Start
{
    public class DependencyConfiguration
    {
        public static void Register(IContainer container)
        {
            container.Register<IEmployeeOperations, EmployeeOperations>();
            container.Register<IEmployeeReader, EmployeeReader>();

        }
    }
}