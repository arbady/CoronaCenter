using CoronaCenter.Model.Forms;
using CoronaCenter.Model.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CoronaCenter.Model.Models;
using CoronaCenter.Services.Services.Bases;

namespace CoronaCenter.ASP.Controllers
{
    public class MakerController : Controller
    {
        private readonly IService<MakerModel, MakerForm> _service;

        public MakerController(IService<MakerModel, MakerForm> service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            IEnumerable<MakerModel> model = _service.GetAll();
            return View(model);
        }

        //Affichage du formulaire
        public IActionResult Create()
        {
            return View();
        }

        //Traitement du formulaire
        [HttpPost]
        public IActionResult Create(MakerForm form)
        {
            //Correct ?
            //Si oui
            if (ModelState.IsValid)
            {
                //Service
                _service.Insert(form);

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
            MakerModel form = _service.GetById(id);

            if (form == null)
            {
                //Dans le cas où la page n'est pas trouvée
                return NotFound();
            }

            return View(form);
        }

        //Traitement de la modification avec un [HttpPost]
        [HttpPost]
        public IActionResult Update(int id, MakerForm form)
        {
            if (ModelState.IsValid)
            {
                _service.Update(id, form);
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
            MakerModel m = _service.GetById(id);

            return View(m);
        }

        [HttpPost, ActionName("Delete")]//Eviter ActionName pour la maintenabilité
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            try
            {
                _service.Delete(id);
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

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            MakerModel form = _service.GetById((int)id);


            if (form == null)
            {
                return NotFound();
            }
            return View(form);
        }
    }
}
