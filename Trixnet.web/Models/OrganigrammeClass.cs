using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Trixnet.web.Models
{
    public class OrganigrammeClass
    {
        [Key]
        public int id { get; set; }

        public string v { get; set; }
        public string f { get; set; }
        public string fonction { get; set; }
        public string superieur { get; set; }

    }
}
