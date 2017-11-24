using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Train.WebAPI.Models;

namespace Train.WebAPI.Controllers
{
    public class GreetingController : ApiController
    {
        public static List<Greeting> _greetings = new List<Greeting>();

        public Greeting HelloGreeting(string greeting)
        {
            //_greetings.Add(greeting);
            //var greetingLocation = new Uri(this.Request.RequestUri,"greeting/" + greeting.Name);
            var response = this.Request.CreateResponse(HttpStatusCode.Created);
            //response.Headers.Location = greetingLocation;
            var gre = new Greeting()
            {
                 Message = "测试消息",
                 Name = "测试名称"
            };
            return gre;
        }

        public string GetGreeting(string id)
        {
            var greeting = _greetings.FirstOrDefault(x => x.Name == id);
            if(greeting == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return greeting.Message;
        }

        //public string GetGreeting()
        //{
        //    return "Hello world! 你好！";
        //}

        //// GET api/<controller>
        ////public IEnumerable<string> Get()
        ////{
        ////    return new string[] { "value1", "value2" };
        ////}

        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}