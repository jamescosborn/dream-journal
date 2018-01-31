using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DreamJournal.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entries",
                columns: table => new
                {
                    EntryId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    Author = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    CatNap = table.Column<bool>(nullable: false),
                    LucidMoment = table.Column<string>(nullable: true),
                    PreSleepInfo = table.Column<string>(nullable: true),
                    SelfAnalysis = table.Column<string>(nullable: true),
                    SleepTime = table.Column<DateTime>(nullable: false),
                    Tags = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    WakeTime = table.Column<DateTime>(nullable: false),
                    WasLucid = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entries", x => x.EntryId);
                });

            migrationBuilder.CreateTable(
                name: "Interpretations",
                columns: table => new
                {
                    InterpretationId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    Author = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    EntryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interpretations", x => x.InterpretationId);
                    table.ForeignKey(
                        name: "FK_Interpretations_Entries_EntryId",
                        column: x => x.EntryId,
                        principalTable: "Entries",
                        principalColumn: "EntryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Interpretations_EntryId",
                table: "Interpretations",
                column: "EntryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Interpretations");

            migrationBuilder.DropTable(
                name: "Entries");
        }
    }
}
