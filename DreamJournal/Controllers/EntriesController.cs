using Microsoft.AspNetCore.Mvc;
using DreamJournal.Models;
using System.Linq;

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
    }
}