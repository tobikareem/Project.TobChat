using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Project.TobChat.BackEnd.Data;
using Project.TobChat.BackEnd.Model;

namespace Project.TobChat.WebMvc.Controllers
{
    public class PeopleController : Controller
    {
        private readonly TobChatDbContext _db = new TobChatDbContext();

        // GET: People
        public ActionResult Index()
        {
            var people = _db.People.Include(p => p.Instructor).Include(p => p.Student);
            return View(people.ToList());
        }

        // GET: People/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person person = _db.People.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // GET: People/Create
        public ActionResult Create()
        {
            //ViewBag.Id = new SelectList(_db.Instructors, "Id", "Speciality");
            //ViewBag.Id = new SelectList(_db.Students, "Id", "Major");
            return View();
        }

        // POST: People/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,MiddleName,Email,Password")] Person person)
        {
            if (ModelState.IsValid)
            {
                _db.People.Add(person);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            //ViewBag.Id = new SelectList(_db.Instructors, "Id", "Speciality", person.Id);
            //ViewBag.Id = new SelectList(_db.Students, "Id", "Major", person.Id);
            return View(person);
        }

        // GET: People/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person person = _db.People.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            //ViewBag.Id = new SelectList(_db.Instructors, "Id", "Speciality", person.Id);
            //ViewBag.Id = new SelectList(_db.Students, "Id", "Major", person.Id);
            return View(person);
        }

        // POST: People/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,MiddleName,Email,Password")] Person person)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(person).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            //ViewBag.Id = new SelectList(_db.Instructors, "Id", "Speciality", person.Id);
            //ViewBag.Id = new SelectList(_db.Students, "Id", "Major", person.Id);
            return View(person);
        }

        // GET: People/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person person = _db.People.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // POST: People/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Person person = _db.People.Find(id);
            if (person != null) _db.People.Remove(person);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
