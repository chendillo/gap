using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace Gap.Models
{
    public class Store
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }

        [JsonIgnore]
        public virtual ICollection<Article> Articles { get; set; }
    }
}