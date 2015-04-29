namespace PghTechFest.Www.Models.Domain
{
    public class ScheduleEntry
    {
        public int SessionId { get; set; }

        public int SpeakerId { get; set; }

        public string SpeakerFirstName { get; set; }

        public string SpeakerLastName { get; set; }

        public string Title { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public string Room { get; set; }
    }
}