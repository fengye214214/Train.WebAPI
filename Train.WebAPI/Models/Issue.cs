using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Train.WebAPI.Models
{   
    /// <summary>
    /// 问题实体对象
    /// </summary>
    public class Issue
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IssueStatus Status { get; set; }

    }
}