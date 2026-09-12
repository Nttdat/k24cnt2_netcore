using Microsoft.AspNetCore.Mvc;
using NttdLesson07Models.Models.DataModels;

namespace NttdLesson07Models.Controllers
{
    public class NttdMemberController : Controller
    {
        protected static List<NttdMember> _members = new List<NttdMember>
        {
            //mock data

             new NttdMember
            {
                NttdMemberId = Guid.NewGuid().ToString(),
                NttdUserName = "Nttdtv",
                NttdPassword = "123456",
                NttdFullName = "Nguyễn Trần Thành Đạt",
                NttdEmail = "thanhthanh15061999@example.com"
            },
            new NttdMember
            {
                NttdMemberId = Guid.NewGuid().ToString(),
                NttdUserName = "tranthicuc",
                NttdPassword = "123456",
                NttdFullName = "Trần Thị Cúc",
                NttdEmail = "tranthicuc@example.com"
            },
            new NttdMember
            {
                NttdMemberId = Guid.NewGuid().ToString(),
                NttdUserName = "levanhung",
                NttdPassword = "123456",
                NttdFullName = "Lê Văn Hùng",
                NttdEmail = "levanhung@example.com"
            },
            new NttdMember
            {
                NttdMemberId = Guid.NewGuid().ToString(),
                NttdUserName = "phamthiduyen",
                NttdPassword = "123456",
                NttdFullName = "Phạm Thị Duyên",
                NttdEmail = "phamthiduyen@example.com"
            },
            new NttdMember
            {
                NttdMemberId = Guid.NewGuid().ToString(),
                NttdUserName = "hoangminhduc",
                NttdPassword = "123456",
                NttdFullName = "Hoàng Minh Đức",
                NttdEmail = "hoangminhduc@example.com"
            }
        };
        public IActionResult Index()
        {
            return View(_members);
        }
        public IActionResult GetMember()
        {
            var member = new NttdMember
            {
                NttdMemberId = Guid.NewGuid().ToString(),
                NttdUserName = "dattv",
                NttdPassword = "password123",
                NttdFullName = "Nguyễn Trần Thành Đạt",
                NttdEmail = "thanhthanh15061999@gmail.com"
            };
            //ViewBag.Member = member;
            return View(member);
        }
        // Đưa dữ liệu dạng List ra View
        public IActionResult GetMembers()
        {
            // Lấy từ mock data
            ViewBag.Members = _members;
            return View();

        }
        // GET: Create member
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Create member
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(NttdMember member)
        {
            if (ModelState.IsValid)
            {
                member.NttdMemberId = Guid.NewGuid().ToString();
                _members.Add(member);
                return RedirectToAction(nameof(Index));
            }
            return View(member);

        }
    }
}
