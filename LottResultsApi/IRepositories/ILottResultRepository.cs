using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LottResultsApi.Models;

namespace LottResultsApi.IRepositories
{
    public interface ILottResultRepository
    {
        IQueryable<LottResult> GetAll();
        LottResult GetById(int id);
        LottResult GetByName(string name);
        void Add(LottResult lottResult);
        bool Delete(int id);
        void Update(LottResult lottResult);
    }
}
