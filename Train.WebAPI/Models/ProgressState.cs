using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Train.WebAPI.Models
{   
    /// <summary>
    /// 进程状态
    /// </summary>
    public class ProgressState
    {   
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 总毫秒数
        /// </summary>
        public double TotalProcessorTimeInMillis { get; set; }

        public ProgressState() { }
        public ProgressState(Process proc)
        {
            Id = proc.Id;
            Name = proc.ProcessName;
            TotalProcessorTimeInMillis = proc.TotalProcessorTime.TotalMilliseconds;
        }
    }

    /// <summary>
    /// 进程状态集合对象
    /// </summary>
    public class ProcessCollectionState
    {   
        /// <summary>
        /// 进程状态
        /// </summary>
         public IEnumerable<ProgressState> Processes { get; set; }
    }

}