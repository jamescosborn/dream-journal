using System;
namespace DreamJournal.Models
{
    [Table("Entries")]
    public class Entry
    {
        [Key]
        public int EntryId { get; set; }
        public string Author { get; set; }
        public string Body { get; set; }
        public DateTime SleepTime { get; set; }
        public DateTime WakeTime { get; set; }
        public string PreSleepInfo { get; set; }
        public bool CatNap { get; set; }
        public bool WasLucid { get; set; }
        public string LucidMoment { get; set; }
        public string Tags { get; set; }
        public string SelfAnalysis { get; set; }
    }
}
