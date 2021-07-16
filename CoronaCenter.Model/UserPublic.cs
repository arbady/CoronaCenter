using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.DataBase.Entities
{
    public class UserPublic
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(64)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(64)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(256)]
        public string Email { get; set; }
        public string Token { get; set; }

        //2 methodes static de mapping (dans une classe mapper)
        //qui reuni tous les mapping de la base des donées
        //qui permet de traduire le user de la db vers le public et inversement
    }
}
