﻿using DataAccess.Contracts;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.DTO;

namespace DataAccess.Services
{
    public class GLPostingService : IGLPostingService
    {
        private readonly ApplicationDbContext _dbContext;
        public GLPostingService(ApplicationDbContext context)
        {
            _dbContext = context;
        }
     
        public List<GL_Posting> GetAllGL_Postings()
        {
            return _dbContext.GL_Postings.ToList();
        }   
        
        public GL_Posting GetGL_Posting(int id)
        {
            return _dbContext.GL_Postings.Where(x => x.PostingsId == id).FirstOrDefault();
        }

        public List<GLPS_Data> GetGLPS_Datas(int id)
        {
            var datas = _dbContext.GLPS_Datas
                                    .Where(x => x.PostingsId == id);
            if(datas!=null && datas.Count() > 0)
            {
                return datas.ToList();
            }
            else
            {
                return new List<GLPS_Data>();
            }
        }


        /*
            select GLACCTNO, sum(Debit), sum(Credit) 
            from GLPS_Datas
            -- where PostingsId in (1,2,3,4)
            group by GLACCTNO
        */
        public List<TransactionSummary> GetTransactionsSummary(List<int> ids)
        {
            List<TransactionSummary> transactionSummary = new List<TransactionSummary>();

            var results = from p in _dbContext.GLPS_Datas
                          where ids.Contains(p.PostingsId)
                          group p by p.GLACCTNO into g
                          select new TransactionSummary
                          {
                              GLACCTNO = g.Key,
                              TotalCreditAmount = g.Sum(x => x.Credit),
                              TotalDebitAmount = g.Sum(x => x.Debit)
                          };
            if (results != null && results.Count() > 0)
            {
                foreach (var r in results)
                {
                    transactionSummary.Add(new TransactionSummary()
                    {
                        GLACCTNO = r.GLACCTNO,
                        TotalCreditAmount = r.TotalCreditAmount,
                        TotalDebitAmount = r.TotalDebitAmount,
                    });
                }
                return transactionSummary;
            }
            else
                return transactionSummary;
        }

        public List<string> GetSources()
        {
            List<string> sources = new List<string>();
            sources.Add("PJ");
            sources.Add("AB");
            sources.Add("CD");
            sources.Add("EF");
            sources.Add("JH");
            return sources;
        }

        public List<GL_Posting> GetFilterGL_Postings(GL_Postings_Filter_Data filterData)
        {
            List<GL_Posting> filterDatas = new List<GL_Posting>();

            IEnumerable<GL_Posting> dataBySource = _dbContext.GL_Postings
                                            .Where(x=>x.Source==filterData.Source);

            if(dataBySource!=null && dataBySource.Count() > 0)
            {
                filterDatas = dataBySource.ToList();
            }

            return filterDatas;
        }
    }
}
