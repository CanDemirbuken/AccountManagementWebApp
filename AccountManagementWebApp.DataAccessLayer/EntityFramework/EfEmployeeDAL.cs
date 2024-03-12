using AccountManagementWebApp.DataAccessLayer.Abstract;
using AccountManagementWebApp.DataAccessLayer.Concrete;
using AccountManagementWebApp.DataAccessLayer.Repositories;
using AccountManagementWebApp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementWebApp.DataAccessLayer.EntityFramework
{
    public class EfEmployeeDAL : GenericRepository<Employee>, IEmployeeDAL
    {
        public EfEmployeeDAL(Context context) : base(context)
        {
        }
    }
}
