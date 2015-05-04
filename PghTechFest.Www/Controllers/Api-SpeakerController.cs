using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using PghTechFest.Www.Models;
using PghTechFest.Www.Models.Domain;

namespace PghTechFest.Www.Controllers
{
    public class SpeakerController : ApiController
    {
        public IEnumerable<Speaker> Get()
        {
            var context = new DatabaseContext();

            var speakers = context.People
                .OrderBy(s => s.LastName)
                .Select(e => new Speaker()
                {
                    Id = e.Id,
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    Bio = e.Bio,
                    TwitterUserName = e.TwitterUserName
                });

            return speakers;
        }

        public Speaker Get(int id)
        {
            var context = new DatabaseContext();

            var speaker = context.People.Where(e => e.Id == id)
                .Select(e => new Speaker()
                {
                    Id = e.Id,
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    Bio = e.Bio,
                    TwitterUserName = e.TwitterUserName
                }).FirstOrDefault();

            return speaker;
        }
    }
}