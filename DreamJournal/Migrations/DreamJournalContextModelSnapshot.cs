using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using DreamJournal.Models;

namespace DreamJournal.Migrations
{
    [DbContext(typeof(DreamJournalContext))]
    partial class DreamJournalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("DreamJournal.Models.Entry", b =>
                {
                    b.Property<int>("EntryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<string>("Body");

                    b.Property<bool>("CatNap");

                    b.Property<string>("LucidMoment");

                    b.Property<string>("PreSleepInfo");

                    b.Property<string>("SelfAnalysis");

                    b.Property<DateTime>("SleepTime");

                    b.Property<string>("Tags");

                    b.Property<string>("Title");

                    b.Property<DateTime>("WakeTime");

                    b.Property<bool>("WasLucid");

                    b.HasKey("EntryId");

                    b.ToTable("Entries");
                });

            modelBuilder.Entity("DreamJournal.Models.Interpretation", b =>
                {
                    b.Property<int>("InterpretationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<string>("Body");

                    b.Property<int?>("EntryId");

                    b.HasKey("InterpretationId");

                    b.HasIndex("EntryId");

                    b.ToTable("Interpretations");
                });

            modelBuilder.Entity("DreamJournal.Models.Interpretation", b =>
                {
                    b.HasOne("DreamJournal.Models.Entry", "entry")
                        .WithMany("Interpretations")
                        .HasForeignKey("EntryId");
                });
        }
    }
}
