using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using Train.WebAPI.Common;
using Train.WebAPI.Models;

namespace Train.WebAPI.Controllers
{
    public class IssueController : ApiController
    {
        /// <summary>
        /// 异步获取数据
        /// </summary>
        /// <returns></returns>
        [Route("api/Issue/GetAsync")]
        public async Task<JsonResponse<IEnumerable<Issue>>> GetAsync()
        {   
            var resultList = new JsonResponse<IEnumerable<Issue>>();
            //await Task.Delay(TimeSpan.FromSeconds(10));
            await Task.Run(() =>
            {
                var issueList = new List<Issue>();
                var model = new Issue()
                {
                    Id = "1",
                    Title = "问题一",
                    Description = "问题一详细描述",
                };
                var model1 = new Issue()
                {
                    Id = "2",
                    Title = "问题二",
                    Description = "问题二详细描述",
                };
                issueList.Add(model);
                issueList.Add(model1);
                resultList.data = issueList;
                resultList.Success = true;
                resultList.Message = "获取消息列表成功!";
            });
            return resultList;
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            Thread.Sleep(TimeSpan.FromSeconds(10));
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