using Microsoft.AspNetCore.Mvc;
using DreamJournal.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DreamJournal.Controllers
{
    public class EntriesController : Controller
    {
        private DreamJournalContext db = new DreamJournalContext();

        public IActionResult Index()
        {
            List<Entry> model = db.Entries.ToList();
            return View();
        }

        public IActionResult Details(int id)
        {
            Entry thisEntry = db.Entries.FirstOrDefault(entries => entries.EntryId == id);
            return View(thisEntry);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Entry entry)
        {
            db.Entries.Add(entry);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var thisEntry = db.Entries.FirstOrDefault(entries => entries.EntryId == id);
            return View(thisEntry);
        }

        [HttpPost]
        public IActionResult Edit(Entry entry)
        {
            db.Entry(entry).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}