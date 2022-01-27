using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class MovieResponse
    {
        [Key]
        [Required]
        public int movieID { get; set; }
        [Required]
        public string category { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string year { get; set; }
        [Required]
        public string director { get; set; }
        [Required]
        public string rating { get; set; } //maybe a different type
        public bool edited { get; set; }
        public string lentto { get; set; }
        [MaxLength(25)]
        public string notes { get; set; }
    }
}
