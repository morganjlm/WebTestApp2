using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using MvcApplication2.Models;
using System.Threading.Tasks;

namespace MvcApplication2.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public string Post([FromBody]string value)
        {
            return "Hello from API";
        }

        // PUT api/values/5
        public string PutTest(int id, string value)
        {
            return "Hello from API";
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        [HttpGet]
        public Models.LanguageStrings GetLanguageStrings(string pageName)
        {
            Models.LanguageStrings strings = new Models.LanguageStrings();
            strings.Strings = new Dictionary<string, string>();

            strings.Strings.Add("text1", "test");
            strings.Strings.Add("text2", "test");
            return strings;
        }

        [HttpPost]      
        public string PostTester(Models.Login login)
        {
            //return LoginUser(login.Username, login.Password);
            return "got it";


        }

        private string LoginUser(string username, string password)
        {
            return "Ok()";
        }

        [HttpPut]
        public string CreateUserAccount([FromBody]Models.User user)
        {
            return CreateUserAccount2(user.Email, user.Password, user.FirstName, user.LastName);
        }

        private string CreateUserAccount2(string email, string password, string firstName, string lastName)
        {
            return "true";
        }

   



    }
}