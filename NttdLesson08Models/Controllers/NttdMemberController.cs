using Microsoft.AspNetCore.Mvc;
using NttdLesson08Models.Models;

namespace NttdLesson08Models.Controllers
{
    public class NttdMemberController : Controller
    {
        // Mock data - NttdMember
        private static List<NttdMember> _members = new List<NttdMember>()
        {
            new NttdMember
            {
                NttdMemberId = Guid.NewGuid().ToString(),
                NttdUserName = "DatTv",
                NttdPassword = "Password123!",
                NttdFullName = "Nguyễn Trần Thành Đạt",
                NttdEmail = "thanhthanh15061999@gmail.com"
            },
            new NttdMember
            {
                NttdMemberId = Guid.NewGuid().ToString(),
                NttdUserName = "tranthib",
                NttdPassword = "SecurePass456#",
                NttdFullName = "Trần Thị B",
                NttdEmail = "tranthib@outlook.com"
            },
            new NttdMember
            {
                NttdMemberId = Guid.NewGuid().ToString(),
                NttdUserName = "levanc",
                NttdPassword = "MyPassword789$",
                NttdFullName = "Lê Văn C",
                NttdEmail = "levanc@company.com"
            }
        };
        // GET: Danh sách thành viên
        public IActionResult Index()
        {
            return View(_members);
        }
        [HttpGet]
        public IActionResult NttdCreate()
        {
            var member = new NttdMember();
            return View(member);
        }
        [HttpPost]
        public IActionResult NttdCreate(NttdMember nttdMember)
        {
            nttdMember.NttdMemberId = Guid.NewGuid().ToString();
            _members.Add(nttdMember);

            return RedirectToAction("Index");
            //return View(nttdMember);
        }

        [HttpGet]
        public IActionResult NttdEdit(string id)
        {
            var member = _members.Where(x => x.NttdMemberId.Equals(id)).FirstOrDefault();
            return View(member);
        }

        [HttpPost]
        public IActionResult NttdEdit(string id, NttdMember nttdMember)
        {
            // var member = _members.Where(x => x.NttdMemberId.Equals(id)).FirstOrDefault();
            for (int i = 0; i < _members.Count; i++)
            {
                if (_members[i].NttdMemberId == id)
                {
                    _members[i].NttdUserName = nttdMember.NttdUserName;
                    _members[i].NttdPassword = nttdMember.NttdPassword;
                    _members[i].NttdFullName = nttdMember.NttdFullName;
                    _members[i].NttdEmail = nttdMember.NttdEmail;

                    return RedirectToAction("Index");
                }

            }
            return View();
        }

        [HttpGet]
        public IActionResult NttdDetails(string id)
        {
            var member = _members.Where(x => x.NttdMemberId.Equals(id)).FirstOrDefault();
            return View(member);
        }

        [HttpGet]
        public IActionResult NttdDelete(string id)
        {
            var member = _members.Where(x => x.NttdMemberId.Equals(id)).FirstOrDefault();
            return View(member);
        }
        [HttpPost]
        public IActionResult NttdDeleted(string id)
        {
            foreach (var item in _members)
            {
                if (item.NttdMemberId.Equals(id))
                {
                    _members.Remove(item);
                    return RedirectToAction("Index");
                }
            }
            return View("NttdDelete");
        }
    }
}

     
