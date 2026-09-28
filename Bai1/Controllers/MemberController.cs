using Bai1.Models;
using Microsoft.AspNetCore.Mvc;


namespace Bai1.Controllers
{
    public class MemberController : Controller
    {
        private static List<Member> members = new List<Member>();
        public IActionResult Index()
        {
            return View(members);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Member member)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(member);
                }
                members.Add(member);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
