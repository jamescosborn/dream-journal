using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamJournal.Models
{
    [Table("Entries")]
    public class Entry
    {
        public Entry()
        {
            this.Interpretations = new HashSet<Interpretation>();
        }

        [Key]
        public int EntryId { get; set; }
        public string Title { get; set; }
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
        public virtual ICollection<Interpretation> Interpretations { get; set; }

    }
}
