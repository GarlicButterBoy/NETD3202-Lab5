using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NETD3202_Lab5.Models
{
    public class Prompts
    {
        [Key]
        public int p_id { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string prompt { get; set; }


    }
}
