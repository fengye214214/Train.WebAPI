using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Train.WebAPI.Models;

namespace Train.WebAPI.Controllers
{
    public class ProcessesController : ApiController
    {   
        public ProcessCollectionState Get(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return new ProcessCollectionState
            {
                Processes = Process
                        .GetProcessesByName(name)
                        .Select(p => new ProgressState(p))
            };
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
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