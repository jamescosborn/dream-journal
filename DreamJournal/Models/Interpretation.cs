using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamJournal.Models
{
    [Table("Interpretations")]
    public class Interpretation
    {
        [Key]
        public int InterpretationId { get; set; }
        public string Author { get; set; }
        public string Body { get; set; }
        public virtual Entry entry { get; set; }
    }
}
