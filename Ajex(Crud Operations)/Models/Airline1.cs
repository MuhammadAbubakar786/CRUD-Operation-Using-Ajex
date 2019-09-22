using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ajex_Crud_Operations_.Models
{
    public partial class Airline1
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "please enter name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        public string Name { get; set; }
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$")]
        public string Country { get; set; }
        public string Status { get; set; }
        [DisplayFormat(NullDisplayText = "Null name")]
        public string ShortCode { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
