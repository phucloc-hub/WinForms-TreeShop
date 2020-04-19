using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeTop.DLL;

namespace TreeTop.Business_Logic
{
    public class CategoryBLL
    {
        CategoryDAO dao = new CategoryDAO();
        public DataTable getAll()
        {
            return dao.getAll();
        }
        public bool insertTo(string id,string name)
        {
            return dao.insertTO(id, name);
        }
        public bool Update(string id,string name)
        {
            return dao.Update(id, name);
        }
        public bool Delete(string id)
        {
            return dao.Delete(id);
        }
    }
}
