using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDepartman.Models
{
    public class departmanlar
    {
        [Key]
        public int id { get; set; }
        public string departmanAd { get; set; }

        public List<personal> personals { get; set; }
    }
}
