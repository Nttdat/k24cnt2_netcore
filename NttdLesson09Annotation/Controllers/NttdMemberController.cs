using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NttdLesson09Annotation.Models.DataModels;
using NttdLesson09Annotation.Models.DataViewModels;

namespace NttdLesson09Annotation.Controllers
{
    public class NttdMemberController : Controller
    {
        private static List<NttdMember> _nttdMembers = new List<NttdMember>();
        private object _context;

        // GET: NttdMemberController
        public ActionResult Index()
        {

            return View();
        }

        // GET: NttdMemberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NttdMemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NttdMemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NttdMemberRegister nttdMember)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(nttdMember);
                }
                
            }
            catch
            {
                return View();
            }
        }

        // GET: NttdMemberController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NttdMemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NttdMemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NttdMemberController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
