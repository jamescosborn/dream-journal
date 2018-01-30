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
    }
}