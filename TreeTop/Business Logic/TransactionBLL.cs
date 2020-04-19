using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeTop.DLL;

namespace TreeTop.Business_Logic
{
    public class TransactionBLL
    {
        TransactionDAO dao = new TransactionDAO();

        public bool CancelOrdering(int IDTrans)
        {
            return dao.CancelOrdering(IDTrans);
        }
        public bool insertTo(string email, float total, string createDate)
        {
            return dao.insertTo(email, total, createDate);
        }
        public int getId()
        {
            return dao.getID();
        }
        public DataTable getAllTrans(string email)
        {
            return dao.getAllTransUser(email);
        }
        public DataTable getAllTrans()
        {
            return dao.getAllTransAdmin();
        }
        public bool SetStatus(string status,int IDTrans)
        {
            return dao.SetStatus(status, IDTrans);
        }

    }
}
