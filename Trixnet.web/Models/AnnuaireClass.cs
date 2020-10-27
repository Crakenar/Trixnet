using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Trixnet.web.Models
{
    public class AnnuaireClass
    {
        [Key]
        public string Nom { get; set; }

        public string Prenom { get; set; }
        public string Tel  { get; set; }
        public string Email { get; set; }
        public string Fonction { get; set; }
        public string Secteur { get; set; }
        public string Statut { get; set; }
        public string Description_job { get; set; }
        public string Description_divers { get; set; }
        public string AnneeArrivee { get; set; }
        public Boolean Photographie { get; set; }
    }
}
