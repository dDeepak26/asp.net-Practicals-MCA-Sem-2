using Microsoft.AspNetCore.Mvc;
using Practical_12_LINQ.Models;

namespace Practical_12_LINQ.Controllers
{
    public class prac12controller : Controller
    {
        public IActionResult Index()
        {
            List<friend> friends = new List<friend>
            {
             new friend{ Id = 1,Name="Deepak",Middlename ="N.",Lastname="Durgam",Rollno=06,Address="Ghatkopar"},
             new friend{ Id = 3,Name="Sarvesh",Middlename ="A",Lastname="Sonavne",Rollno=45,Address="Byculla"},
             new friend{ Id = 2,Name="Aftab",Middlename ="B",Lastname="saikh",Rollno=37,Address="Vidyavihar"}
            };
            var fs = friends.Where(x => x.Id != 0).OrderBy(a => a.Rollno).ToList();
            return View(fs);

        }
    }
}
