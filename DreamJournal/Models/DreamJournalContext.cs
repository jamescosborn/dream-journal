using System;
using Microsoft.EntityFrameworkCore;

namespace DreamJournal.Models
{
    public class DreamJournalContext : DbContext
    {
        public DbSet<Entry> Entries { get; set; }
        public DbSet<Interpretation> Interpretations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"Server=localhost;Port=8889;database=DreamJournal;uid=root;pwd=root;");
    }
}
