using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementWebApp.DataAccessLayer.Abstract
{
    public interface IGenericDAL<T> where T : class
    {
        void Add(T t);
        void Update(T t);
        void Delete(T t);
        List<T> GetAll();
        T GetByID(int id);
    }
}
