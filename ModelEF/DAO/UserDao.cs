using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelEF.Model;


namespace ModelEF.DAO
{
    public class UserDao
    {
        NgoThanhTuanContext db = null;

        public UserDao()
        {
            db = new NgoThanhTuanContext();
        }
        public bool Delete(string id)
        {
            try
            {
                var user = (UserAccount) db.UserAccounts.Find(id);
                db.UserAccounts.Remove(user);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
