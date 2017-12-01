using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiContrib.CollectionJson;

namespace Train.WebAPI.Models
{   
    /// <summary>
    /// 返回问题集合
    /// </summary>
    public class IssuesStates : IReadDocument
    {
        public IssuesStates()
        {
            Links = new List<Link>();
        }

        public IEnumerable<IssueState> Issues { get; set; }
        public IList<Link> Links { get; private set; }

        public Collection Collection
        {
            get
            {
                var collection = new Collection();

                return collection;
            }
        }
    }
}