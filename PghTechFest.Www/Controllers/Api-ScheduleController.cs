using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Http;
using PghTechFest.Www.Models;
using PghTechFest.Www.Models.Domain;

namespace PghTechFest.Www.Controllers
{
    public static class StringFormattingExtensions
    {
        public static string ToTitleCase(this string x)
        {
            if (string.IsNullOrEmpty(x))
                return x;
            var textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(x);
        }
    }


    public class ScheduleController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<ScheduleEntryDetail> Get()
        {
            var context = new DatabaseContext();

            var schedules = context.Schedules
                .Select(e => new ScheduleEntryDetail()
                {
                    SessionId = e.Session.Id,
                    Title = e.Session.Title.ToTitleCase(),
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
                    Title = e.Session.Title.ToTitleCase(),
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