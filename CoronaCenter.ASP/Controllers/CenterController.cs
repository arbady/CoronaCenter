using CoronaCenter.Model.Entities;
using CoronaCenter.Model.Forms;
using CoronaCenter.Model.Models;
using CoronaCenter.Services.Services;
using CoronaCenter.Services.Services.Bases;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaCenter.ASP.Controllers
{
    public class CenterController : Controller
    {
        private readonly IBase<Center, CenterModel, CenterForm> _serviceCenter;
        private readonly IBase<Address, AddressModel, AddressForm> _serviceAddress;
        private readonly IBase<Staff, StaffModel, StaffForm> _serviceStaff;

        public CenterController(IBase<Center, CenterModel, CenterForm> serviceCenter, 
                                IBase<Address, AddressModel, AddressForm> serviceAddress, 
                                IBase<Staff, StaffModel, StaffForm> serviceStaff)
        {
            _serviceCenter = serviceCenter;
            _serviceAddress = serviceAddress;
            _serviceStaff = serviceStaff;
        }

        public IActionResult Index()
        {
            IEnumerable<CenterModel> model = _serviceCenter.GetAll();
            return View(model);
        }

        //Affichage du formulaire
        public IActionResult Create()
        {
            return View();
        }

        //Traitement du formulaire
        [HttpPost]
        public IActionResult Create(CenterForm form)
        {
            //Correct ?
            //Si oui
            if (ModelState.IsValid)
            {
                //Service
                _serviceCenter.Insert(form);

                //On affiche une notification
                TempData["success"] = "Insertion OK";

                //En suite, on fait une redirection
                return RedirectToAction("Index");
            }
            else
            {
                //Si non
                //Réafficher la vue avec le form et les erreurs
                return View(form);
            }
        }

        //Affiche de la modification avec un [HttpGet] mais on n'est pas obligé de l'ecrire
        public IActionResult Update([FromRoute] int id)
        {
            CenterModel form = _serviceCenter.GetById(id);

            if (form == null)
            {
                //Dans le cas où la page n'est pas trouvée
                return NotFound();
            }

            return View(form);
        }

        //Traitement de la modification avec un [HttpPost]
        [HttpPost]
        public IActionResult Update(int id, CenterForm form)
        {
            if (ModelState.IsValid)
            {
                _serviceCenter.Update(id, form);
                TempData["success"] = "Modification OK";
                return RedirectToAction("Index");
            }
            else
            {
                return View(form);
            }
        }
        public IActionResult Delete([FromRoute] int id)
        {
            CenterModel m = _serviceCenter.GetById(id);

            return View(m);
        }

        [HttpPost, ActionName("Delete")]//Eviter ActionName pour la maintenabilité
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            try
            {
                _serviceCenter.Delete(id);
                //Notification : suppression ok
                TempData["success"] = "Suppression OK";

                return RedirectToAction("Index");
            }
            catch
            {
                //Notification : suppression pas ok
                TempData["error"] = "La suppresion n'a pas fonctionné !";
                return RedirectToAction("Index");
            }
        }

        //public IActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return BadRequest();
        //    }
        //    CenterModel model = _serviceCenter.GetById((int)id);


        //    if (model == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(model);
        //}


        //public IActionResult Detail([FromRoute] int id)
        //{
        //    CenterModel model = new CenterModel();

        //    model.Address = (_serviceAddress as AddressService).GetById(id);
        //    model.Responsible = (_serviceStaff as StaffService).GetById(id);

        //    return View(model);
        //}
    }
}
