using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AngularForMVC.Models;

namespace AngularForMVC.Controllers
{
    public class EmployeeWebApiController : ApiController
    {
        // GET: api/EmployeeWebApi
        public IEnumerable<EmployeeVM> Get()
        {
            List<EmployeeVM> list = new List<EmployeeVM>()
            {
                new EmployeeVM()
                {
                    FullName = "Milton Waddams"
                },
                new EmployeeVM()
                {
                    FullName = "Andy Bernard"
                }
            }; 

            return list;
        }

        // GET: api/EmployeeWebApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/EmployeeWebApi
        public HttpResponseMessage Post([FromBody]EmployeeVM employee)
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK);
            response.Content = new StringContent("12345");

            return response;
        }

        // PUT: api/EmployeeWebApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/EmployeeWebApi/5
        public void Delete(int id)
        {
        }
    }
}
