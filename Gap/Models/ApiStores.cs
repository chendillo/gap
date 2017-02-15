using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gap.Models
{
    public class ApiStores
    {
        public bool success { get; set; }
        public int totalElements { get; set; }
        public List<Store> stores { get; set; }
        public string errorMsg { get; set; }
        public int errorCode { get; set; }
    }
}