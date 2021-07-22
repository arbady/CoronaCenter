using CoronaCenter.Model.Forms;
using CoronaCenter.Services.Services.Bases;
using CoronaCenter.Model.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CoronaCenter.Services.Services;

namespace CoronaCenter.ASP.Controllers
{
    public class PatientController : Controller
    {
        private readonly PatientService _service;

        public PatientController(PatientService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            IEnumerable<Patient> model = _service.GetAll();
            return View(model);
        }
    }
}
