using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_Portfolio_api.Model
{
    public class Command
    {
        //Define properties
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Howto { get; set; }
        [Required]
        public string Line { get; set; }
        [Required]
        public string Platform { get; set; }

    }
}
