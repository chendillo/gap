using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace Gap.Models
{
    public class ApiArticle: Article
    {
        public string storeName { get; set; }

        public override bool ShouldSerializestoreId()
        {
            return false;
        }
    }
}