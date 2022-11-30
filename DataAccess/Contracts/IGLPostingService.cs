using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.DTO;
using System.Threading.Tasks;

namespace DataAccess.Contracts
{
    public interface IGLPostingService
    {
        Task<List<GL_Posting>> GetAllGL_Postings();
        GL_Posting GetGL_Posting(int id);
        List<GLPS_Data> GetGLPS_Datas(int id);
        List<TransactionSummary> GetTransactionsSummary(List<int> ids);
        
        // filter
        List<string> GetSources();
        List<GL_Posting> GetFilterGL_Postings(GL_Postings_Filter_Data filterData);

    }
}
