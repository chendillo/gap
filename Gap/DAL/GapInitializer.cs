using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Gap.Models;

namespace Gap.DAL
{
    public class GapInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<GapContext>
    {
        protected override void Seed(GapContext context)
        {
            var stores = new List<Store>
            {
                new Store { name="storeTest1", address="adress 1" },
                new Store { name="storeTest2", address="adress 2" },
                new Store { name="storeTest3", address="adress 3" },
                new Store { name="storeTest4", address="adress 4" },
                new Store { name="storeTest5", address="adress 5" },
                new Store { name="storeTest6", address="adress 6" },
                new Store { name="storeTest7", address="adress 7" }
            };

            stores.ForEach(s => context.Stores.Add(s));
            context.SaveChanges();

            var articles = new List<Article>
            {
                new Article { name="zapato01", description="descripción zapato01", price=5300.1, totalInShelf=1, totalInVault=5, storeId=1 },
                new Article { name="zapato02", description="descripción zapato02", price=2300.9, totalInShelf=0, totalInVault=66, storeId=1 },
                new Article { name="zapato03", description="descripción zapato03", price=18600.6, totalInShelf=3, totalInVault=23, storeId=1 },
                new Article { name="zapato04", description="descripción zapato04", price=55300.3, totalInShelf=5, totalInVault=93, storeId=2 },
                new Article { name="zapato05", description="descripción zapato05", price=59600.5, totalInShelf=12, totalInVault=67, storeId=2 },
                new Article { name="zapato06", description="descripción zapato06", price=34300.2, totalInShelf=12, totalInVault=2, storeId=2 },
                new Article { name="zapato07", description="descripción zapato07", price=12700.0, totalInShelf=14, totalInVault=67, storeId=3 },
                new Article { name="zapato08", description="descripción zapato08", price=98500.2, totalInShelf=10, totalInVault=74, storeId=3 },
                new Article { name="zapato09", description="descripción zapato09", price=73600.1, totalInShelf=13, totalInVault=20, storeId=3 },
                new Article { name="zapato10", description="descripción zapato10", price=37500.8, totalInShelf=9, totalInVault=34, storeId=3 },
                new Article { name="zapato11", description="descripción zapato11", price=23400.9, totalInShelf=5, totalInVault=23, storeId=4 },
                new Article { name="zapato12", description="descripción zapato12", price=58300.6, totalInShelf=17, totalInVault=54, storeId=4 },
                new Article { name="zapato13", description="descripción zapato13", price=52500.3, totalInShelf=3, totalInVault=20, storeId=4 },
                new Article { name="zapato14", description="descripción zapato14", price=17600.2, totalInShelf=0, totalInVault=18, storeId=4 },
                new Article { name="zapato15", description="descripción zapato15", price=86700.5, totalInShelf=10, totalInVault=9, storeId=4 },
                new Article { name="zapato16", description="descripción zapato16", price=65400.8, totalInShelf=19, totalInVault=11, storeId=4 },
                new Article { name="zapato18", description="descripción zapato18", price=75200.5, totalInShelf=3, totalInVault=34, storeId=4 },
                new Article { name="zapato18", description="descripción zapato18", price=74800.1, totalInShelf=4, totalInVault=89, storeId=4 },
                new Article { name="zapato19", description="descripción zapato19", price=32500.3, totalInShelf=12, totalInVault=101, storeId=5 },
                new Article { name="zapato20", description="descripción zapato20", price=12800.2, totalInShelf=11, totalInVault=32, storeId=5 },
                new Article { name="zapato21", description="descripción zapato21", price=96500.4, totalInShelf=14, totalInVault=5, storeId=5 },
                new Article { name="zapato22", description="descripción zapato22", price=84100.5, totalInShelf=11, totalInVault=62, storeId=6 },
                new Article { name="zapato23", description="descripción zapato23", price=45800.8, totalInShelf=6, totalInVault=60, storeId=6 },
                new Article { name="zapato24", description="descripción zapato24", price=42600.7, totalInShelf=1, totalInVault=30, storeId=6 },
                new Article { name="zapato25", description="descripción zapato25", price=25400.5, totalInShelf=0, totalInVault=10, storeId=6 },
                new Article { name="zapato26", description="descripción zapato26", price=38900.4, totalInShelf=10, totalInVault=87, storeId=6 },
                new Article { name="zapato27", description="descripción zapato27", price=27300.7, totalInShelf=17, totalInVault=81, storeId=7 },
                new Article { name="zapato28", description="descripción zapato28", price=35100.9, totalInShelf=15, totalInVault=15, storeId=7 },
                new Article { name="zapato29", description="descripción zapato29", price=15400.8, totalInShelf=19, totalInVault=21, storeId=7 },
                new Article { name="zapato30", description="descripción zapato30", price=18900.6, totalInShelf=14, totalInVault=20, storeId=7 }
            };

            articles.ForEach(a => context.Articles.Add(a));
            context.SaveChanges();
        }
    }
}
