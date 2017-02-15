using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gap.Models
{
    public class ApiArticles
    {
        public bool success { get; set; }
        public int totalElements { get; set; }
        public List<Article> articles { get; set; }
        public string errorMsg { get; set; }
        public int errorCode { get; set; }
    }
}