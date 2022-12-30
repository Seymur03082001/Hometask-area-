using Hometask_Area_.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Hometask_Area_.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Team()
        {
            List<Employee> employee= new List<Employee>();
            employee.Add(new Employee { Name="Walter", Surname="White", Position="Ceo", ImgUrl="img/team/team-1.jpg"});
            employee.Add(new Employee { Name = "Sarah", Surname = "Jonson", Position = "Product Manager", ImgUrl = "img/team/team-2.jpg" });
            employee.Add(new Employee { Name = "William", Surname = "Anderson", Position = "CTO", ImgUrl = "img/team/team-3.jpg" });
            employee.Add(new Employee { Name = "Amanda", Surname = "Jepson", Position = "Accountant", ImgUrl = "img/team/team-4.jpg" });
            return View();
        }
    }
}
