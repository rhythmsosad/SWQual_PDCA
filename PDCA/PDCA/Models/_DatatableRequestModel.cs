using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PDCA.Models
{
    public class _DatatableRequestModel
    {
        public int draw { get; set; }
        public int start { get; set; }
        public int length { get; set; }
        public _DatatableRequestModel_Search search { get; set; }
        public _DatatableRequestModel_Order[] order { get; set; }
        public _DatatableRequestModel_Column[] columns { get; set; }
    }

    /* Supporing Classes */
    public class _DatatableRequestModel_Search
    {
        public bool regex { get; set; }
        public string value { get; set; }
    }

    public class _DatatableRequestModel_Order
    {
        public int column { get; set; }
        public string dir { get; set; }
    }

    public class _DatatableRequestModel_Column
    {
        public string data { get; set; }
        public string name { get; set; }
        public bool searchable { get; set; }
        public bool orderable { get; set; }
        public _DatatableRequestModel_Search search { get; set; }
    }
}