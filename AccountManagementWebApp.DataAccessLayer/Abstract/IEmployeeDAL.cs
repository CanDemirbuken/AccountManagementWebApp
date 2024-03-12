using AccountManagementWebApp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementWebApp.DataAccessLayer.Abstract
{
    public interface IEmployeeDAL : IGenericDAL<Employee>
    {
    }
}
