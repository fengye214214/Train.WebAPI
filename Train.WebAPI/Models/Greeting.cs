using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Train.WebAPI.Models
{   
    /// <summary>
    /// 问候类
    /// </summary>
    public class Greeting
    {   
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 消息
        /// </summary>
        public string Message { get; set; }
    }
}