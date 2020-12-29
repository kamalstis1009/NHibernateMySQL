using NHibernate;
using NHibernate.Linq;
using NHibernateMySQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace NHibernateMySQL.Controllers
{
    public class ProductController : ApiController
    {

        //======================================================| GET
        //[Authorize]
        [Route("Api/Product/GetAllProducts")]
        [HttpGet]
        public async Task<IHttpActionResult> GetAllProducts()
        {
            using (ISession session = NHibertnateSession.OpenSession())
            {
                //var response = session.Query<Products>().ToList();
                var response = await session.Query<Product>().ToListAsync();
                if (response != null)
                {
                    return Ok(response);
                }
                return NotFound();
            }
        }

        //[Authorize]
        [Route("Api/Task/GetProductById", Name = "GetProductById")]
        [HttpGet]
        public async Task<IHttpActionResult> GetProductById([FromUri] int id)
        {
            using (ISession session = NHibertnateSession.OpenSession())
            {
                var response = await session.Query<Product>().Where(index => index.Id == id).FirstOrDefaultAsync();
                if (response != null)
                {
                    return Ok(response);
                }
                return NotFound();
            }
        }

        //======================================================| Add
        [Route("Api/Product/Add")]
        [HttpPost]
        public async Task<IHttpActionResult> AddProduct([FromBody] Product item)
        {
            using (var _session = NHibertnateSession.OpenSession())
            {
                using (var _transaction = _session.BeginTransaction())
                {
                    var response = await _session.SaveAsync(item);
                    _transaction.Commit();
                    if (response != null)
                    {
                        return CreatedAtRoute(nameof(GetProductById), new { id = item.Id }, item); //https://www.jasoncavett.com/blog/converting-to-attribute-routing-in-webapi-applications/
                    }
                    return null;  //failure;
                }
            }
        }

        //======================================================| Delete
        //[Authorize]
        [Route("Api/Product/Delete")]
        [HttpDelete]
        public async Task<IHttpActionResult> DeleteProductById([FromUri] int id)
        {
            using (var _session = NHibertnateSession.OpenSession())
            {
                using (var _transaction = _session.BeginTransaction())
                {
                    var model = await _session.Query<Product>().Where(index => index.Id == id).FirstOrDefaultAsync();
                    if (model != null)
                    {
                        var response = _session.DeleteAsync(model);
                        _transaction.Commit();
                        if (response != null)
                        {
                            return Ok(response);
                        }
                        return NotFound();
                    }
                    return NotFound();
                }
            }
        }

        //======================================================| Put/Update
        [Route("Api/Product/Update")]
        [HttpPut]
        public async Task<IHttpActionResult> UpdateProductById([FromUri] int id, [FromBody] Product item)
        {
            using (var _session = NHibertnateSession.OpenSession())
            {
                using (var _transaction = _session.BeginTransaction())
                {
                    var model = await _session.Query<Product>().Where(index => index.Id == id).FirstOrDefaultAsync();
                    if (model != null)
                    {
                        model.Name = item.Name;
                        model.Brand = item.Brand;
                    }
                    var response = _session.SaveOrUpdateAsync(model);
                    _transaction.Commit();
                    if (response != null)
                    {
                        return Ok(response);
                    }
                    return NotFound();
                }
            }
        }



    }
}
