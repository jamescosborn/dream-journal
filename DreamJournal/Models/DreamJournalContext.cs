using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DreamJournal.Models
{
    public class DreamJournalContext : DbContext
    {

        public DreamJournalContext()
        {
            
        }

        public DbSet<Entry> Entries { get; set; }
        public DbSet<Interpretation> Interpretations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"Server=localhost;Port=8889;database=DreamJournal;uid=root;pwd=root;");


            public DreamJournalContext(DbContextOptions<DreamJournalContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
