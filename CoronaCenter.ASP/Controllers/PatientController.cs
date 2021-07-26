using CoronaCenter.Model.Forms;
using CoronaCenter.Services.Services.Bases;
using CoronaCenter.Model.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CoronaCenter.Services.Services;
using CoronaCenter.Model.Models;

namespace CoronaCenter.ASP.Controllers
{
    public class PatientController : Controller
    {
        private readonly IBase<PatientModel, PatientForm> _service;

        public PatientController(IBase<PatientModel, PatientForm> service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            IEnumerable<PatientModel> model = _service.GetAll();
            return View(model);
        }
    }
}
