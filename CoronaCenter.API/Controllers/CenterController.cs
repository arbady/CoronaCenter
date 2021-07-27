using CoronaCenter.Model.Entities;
using CoronaCenter.Model.Forms;
using CoronaCenter.Model.Models;
using CoronaCenter.Services.Services;
using CoronaCenter.Services.Services.Bases;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaCenter.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CenterController : ControllerBase
    {
        private readonly IBase<Center, CenterModel, CenterForm> centerService;
        private readonly IBase<Vaccine, VaccineModel, VaccineForm> vaccineService;

        public CenterController(IBase<Center, CenterModel, CenterForm> centerService, 
                                IBase<Vaccine, VaccineModel, VaccineForm> vaccineService)
        {
            this.centerService = centerService;
            this.vaccineService = vaccineService;

            //centerService.GetEntity(1).Vaccines.Append(vaccineService.GetEntity(1));
            //centerService.Save();
        }

        /// <summary>
        /// Trouver l'ensemble des centres de vaccination
        /// </summary>
        /// <returns>ensemble des centres</returns>
        //GET: api/<CenterController>
        [HttpGet]
        public ActionResult<IEnumerable<CenterModel>> GetAll()
        {
            try
            {
                return Ok(centerService.GetAll());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    Method = "Get",
                    Message = ex.Message
                });
            }
        }

        /// <summary>
        /// Afficher les détails d'un centre
        /// </summary>
        /// <param name="id">id d'un centre</param>
        /// <returns>infos d'un centre</returns>
        // GET api/<CenterController>/2
        [Authorize(Roles = "Staff")]
        [HttpGet("{id:int}")]
        public ActionResult<CenterModel> GetById(int id)
        {
            try
            {
                return Ok(centerService.GetById(id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    Method = "Get",
                    Message = ex.Message
                });
            }
        }
    }
}
