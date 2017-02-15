using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Gap.DAL;
using Gap.Models;

namespace Gap.Controllers
{
    public class ApiStoreController : ApiController
    {
        private GapContext db = new GapContext();

        [Route("services/stores")]
        public ApiStores GetStores()
        {
            ApiStores result = new ApiStores();

            try
            {
                var stores = db.Stores;

                result.success = true;
                result.totalElements = stores.Count();
                result.stores = stores.ToList();
            }
            catch (Exception e)
            {
                result.success = false;
                result.stores = new List<Store>();
                result.totalElements = 0;
                result.errorMsg = e.Message;
                result.errorCode = 400;
            }

            return result;
        }

        // GET: api/ApiStores/5
        [Route("services/articles/stores/{id}")]
        [ResponseType(typeof(ApiStoreSingle))]
        public ApiStoreSingle GetStore(int id)
        {
            ApiStoreSingle result = new ApiStoreSingle();

            try
            {
                Store store = db.Stores.Find(id);
                if (store == null)
                {
                    result.errorCode = 404;
                    result.success = false;
                    result.errorMsg = "Record not Found";
                }
                else {
                    result.success = true;
                    result.totalElements = store.Articles.Count();
                    result.articles = store.Articles.Select(a => new ApiArticle {
                        id = a.id,
                        description = a.description,
                        name = a.name,
                        price = a.price,
                        totalInShelf = a.totalInShelf,
                        totalInVault = a.totalInVault,
                        storeName = store.name
                    }).ToList();
                }
            }
            catch (Exception e)
            {
                result.success = false;
                result.articles = new List<ApiArticle>();
                result.totalElements = 0;
                result.errorMsg = e.Message;
                result.errorCode = 400;
            }

            return result;
        }

        // PUT: api/ApiStores/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutStore(int id, Store store)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != store.id)
            {
                return BadRequest();
            }

            db.Entry(store).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoreExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/ApiStores
        [ResponseType(typeof(Store))]
        public IHttpActionResult PostStore(Store store)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Stores.Add(store);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = store.id }, store);
        }

        // DELETE: api/ApiStores/5
        [ResponseType(typeof(Store))]
        public IHttpActionResult DeleteStore(int id)
        {
            Store store = db.Stores.Find(id);
            if (store == null)
            {
                return NotFound();
            }

            db.Stores.Remove(store);
            db.SaveChanges();

            return Ok(store);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StoreExists(int id)
        {
            return db.Stores.Count(e => e.id == id) > 0;
        }
    }
}