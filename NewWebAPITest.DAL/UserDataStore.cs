using NewWebAPITest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWebAPITest.DAL
{
    public class UserDataStore
    {
        private UserContext _context = new UserContext();
        public IEnumerable<User> GetUsers()
        {
            return _context.User.ToList();
            //return new string[] { "value1", "value2" };
        }

        public bool CreateUser(User user)
        {
            bool retVal = true;
            try
            {
                _context.User.Add(user);
                _context.SaveChanges();                 
                retVal = true;
            }
            catch (Exception ex)
            {
                retVal = false;
            }
            return retVal;
        }
    }
}
