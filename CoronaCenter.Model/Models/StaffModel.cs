using CoronaCenter.Model.Entities;
using CoronaCenter.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.Model.Models
{
    //public class StaffModel // Ici on utilise un systeme de Wrapping qui veut dire qu'on englobe l'entité
    //                        // et on recupère rien que les informations qu'on a besoin
    //{
    //    private Staff _entity; // Correspond à notre modèle de base des données (DTO) => qui est mon EF
    //    public int Id => _entity.Id; // Les propriétés autocalculé me permet d'avoir accès aux informations
    //    public StaffModel(Staff staff) 
    //    {
    //        _entity = staff;
    //    }
    //    public Grade Grade { get => _entity.Grade; set => _entity.Grade = value; }
    //}

    public class StaffModel : StaffLiteModel
    {
        public int UserId { get; set; }
        public virtual Center Center { get; set; }
        public virtual UserProfile User { get; set; }
    }
}
