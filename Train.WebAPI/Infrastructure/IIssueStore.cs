using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Train.WebAPI.Models;

namespace Train.WebAPI.Infrastructure
{   
    /// <summary>
    /// 操作问题的方法定义
    /// </summary>
    public interface IIssueStore
    {
        Task<IEnumerable<Issue>> FindAsnc();
        Task<Issue> FindAsync(string issueId);
        Task<IEnumerable<Issue>> FindAsyncQuery(string searchText);
        Task UpdateAsync(Issue issue);
        Task DeleteAsync(string issueId);
        Task CreateAsync(Issue issue);
    }
}