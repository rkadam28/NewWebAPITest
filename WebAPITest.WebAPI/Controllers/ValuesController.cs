using NewWebAPITest.DAL;
using NewWebAPITest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace WebAPITest.WebAPI.Controllers
{

    public class ValuesController : ApiController
    {
        private UserDataStore _store = new UserDataStore();
        // GET api/values
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _store.GetUsers();
        }
        //POST api/values
        [HttpPost]
        public User Post([FromBody]List<string> values)
        {
            try
            {

                User user = new User();

                user.UserName = values[0];
                user.Password = values[1];
                user.FirstName = values[2];
                user.LastName = values[3];
                user.DateOfBirth = Convert.ToDateTime(values[4]);
                _store.CreateUser(user);
                return user;
            }
            catch (Exception)
            {
               return null;
            }
        }
        //[HttpPost]
        //public void Post([FromBody]User user)
        //{
        //    try
        //    {

        //        //User user = new User();

        //        //user.UserName = values[0];
        //        //user.Password = values[1];
        //        //user.FirstName = values[2];
        //        //user.LastName = values[3];
        //        //user.DateOfBirth = Convert.ToDateTime(values[4]);
        //        _store.CreateUser(user);
        //        //return user;
        //    }
        //    catch (Exception)
        //    {
        //        //return null;
        //    }
        //}
    }
}
