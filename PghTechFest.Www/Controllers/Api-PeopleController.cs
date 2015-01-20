using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using PghTechFest.Www.Models;
using PghTechFest.Www.Models.Domain;

namespace PghTechFest.Www.Controllers
{
    public class PeopleController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Person> Get()
        {
            var context = new DatabaseContext();
            return context.People.ToArray();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}