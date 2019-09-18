using System;
using System.Collections.Generic;

namespace Ajex_Crud_Operations_.Models
{
    public partial class Airline1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Status { get; set; }
        public string ShortCode { get; set; }
        public DateTime? Date { get; set; }
    }
}
