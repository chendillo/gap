using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gap.Models
{
    public class ApiStoreSingle
    {
        public bool success { get; set; }
        public int totalElements { get; set; }
        public List<ApiArticle> articles { get; set; }
        public string errorMsg { get; set; }
        public int errorCode { get; set; }
    }
}