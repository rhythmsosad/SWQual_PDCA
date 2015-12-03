using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PDCA.Models
{
    public class _DatatableResponseModel
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<Object> data { get; set; }
        public string error { get; set; }
    }
}