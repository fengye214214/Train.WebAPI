using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Train.WebAPI.Common
{
    public class JsonResponse<T>
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// 返回的消息
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 返回的数据
        /// </summary>
        public T data { get; set; }
    }
}