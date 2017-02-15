using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gap.Models
{
    public class Article
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public int totalInShelf { get; set; }
        public int totalInVault { get; set; }
        public int storeId { get; set; }

        public virtual bool ShouldSerializestoreId()
        {
            return true;
        }
    }
}