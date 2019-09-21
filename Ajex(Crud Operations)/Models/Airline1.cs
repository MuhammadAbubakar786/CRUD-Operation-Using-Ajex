using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ajex_Crud_Operations_.Models
{
    public partial class Airline1
    {
        [Required]
        public int Id { get; set; }
        [MaxLength(5)]
        public string Name { get; set; }
        public string Country { get; set; }
        public string Status { get; set; }
        public string ShortCode { get; set; }
        public DateTime? Date { get; set; }
    }
}
