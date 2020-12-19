using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDepartman.Models
{
    public class personal
    {
        [Key]
        public int perid { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string şehir { get; set; }
        public DateTime iseGirisTarihi { get; set; }
        public int yillikizinhakki { get; set; } 

        public departmanlar departmanlar { get; set; }
    }
}
