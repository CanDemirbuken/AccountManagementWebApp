using AccountManagementWebApp.BusinessLayer.Abstract;
using AccountManagementWebApp.DataAccessLayer.Abstract;
using AccountManagementWebApp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementWebApp.BusinessLayer.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private readonly IEmployeeDAL _employeeDAL;

        public EmployeeManager(IEmployeeDAL employeeDAL)
        {
            _employeeDAL = employeeDAL;
        }

        public void TAdd(Employee t)
        {
            _employeeDAL.Add(t);
        }

        public void TDelete(Employee t)
        {
            _employeeDAL.Delete(t);
        }

        public List<Employee> TGetAll()
        {
            return _employeeDAL.GetAll();
        }

        public Employee TGetByID(int id)
        {
            return _employeeDAL.GetByID(id);
        }

        public void TUpdate(Employee t)
        {
            _employeeDAL.Update(t);
        }
    }
}
