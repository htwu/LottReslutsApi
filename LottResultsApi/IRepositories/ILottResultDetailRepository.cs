using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LottResultsApi.Models;

namespace LottResultsApi.IRepositories
{
    public interface ILottResultDetailRepository
    {

        IQueryable<LottResultDetail> GetAll();
        LottResultDetail GetById(int id);
        void Add(LottResultDetail lottResultDetail);
        bool Delete(int id);

        void Update(LottResultDetail lottResultDetail);
    }
}
