using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using PghTechFest.Www.Models;
using PghTechFest.Www.Models.Domain;

namespace PghTechFest.Www.Controllers
{
    public class ScheduleController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<ScheduleEntryDetail> Get()
        {
            var context = new DatabaseContext();

            var schedules = context.Schedules
                .OrderBy(s => s.TimeSlot.Id * 1000 + s.Room.Id)
                .Select(e => new ScheduleEntryDetail()
                {
                    SessionId = e.Session.Id,
                    Title = e.Session.Title,
                    SpeakerId = e.Session.Speaker.Id,
                    SpeakerFirstName = e.Session.Speaker.FirstName,
                    SpeakerLastName = e.Session.Speaker.LastName,
                    StartTime = e.TimeSlot.StartTime,
                    EndTime = e.TimeSlot.EndTime,
                    Room = e.Room.Name,
                    Description = e.Session.Description,
                    SpeakerBio = e.Session.Speaker.Bio,
                    Twitter = e.Session.Speaker.TwitterUserName
                });

            return schedules;
        }

        public ScheduleEntryDetail Get(int id)
        {
            var context = new DatabaseContext();

            var schedule = context.Schedules.Where(e => e.Session.Id == id)
                .Select(e => new ScheduleEntryDetail()
                {
                    SessionId = e.Session.Id,
                    Title = e.Session.Title,
                    SpeakerId = e.Session.Speaker.Id,
                    SpeakerFirstName = e.Session.Speaker.FirstName,
                    SpeakerLastName = e.Session.Speaker.LastName,
                    StartTime = e.TimeSlot.StartTime,
                    EndTime = e.TimeSlot.EndTime,
                    Room = e.Room.Name,
                    Description = e.Session.Description,
                    SpeakerBio = e.Session.Speaker.Bio,
                    Twitter = e.Session.Speaker.TwitterUserName
                }).FirstOrDefault();

            return schedule;
        }
    }
}