using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Comp3026Assignment2.Models;
using Comp3026Assignment2.ViewModels;

namespace Comp3026Assignment2.Controllers
{
    public class VApiController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Product> Get()
        {
            //connect
            using (VirtuosoModels db = new VirtuosoModels())
            {
                //make sure json parsing works with the ef object
                db.Configuration.ProxyCreationEnabled = false;

                //query
                var objP = from p in db.Products
                           orderby p.ProductID
                           select p;

                return objP.ToList();
            }

            //return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public Product Get(int id)
        {
            //connect
            using (VirtuosoModels db = new VirtuosoModels())
            {
                db.Configuration.ProxyCreationEnabled = false;

                Product objP = (from p in db.Products
                               where p.ProductID == id
                               select p).FirstOrDefault();

                return objP;

            }


            //return "value";
        }


        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
