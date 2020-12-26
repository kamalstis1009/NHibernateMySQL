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
                var response = await session.Query<Products>().ToListAsync();
                if (response != null)
                {
                    return Ok(response);
                }
                return NotFound();
            }
        }
    }
}
