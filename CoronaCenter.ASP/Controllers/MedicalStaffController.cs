using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaCenter.ASP.Controllers
{
    public class MedicalStaffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
