using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LottResultsApi.Models;

namespace LottResultsApi.IRepositories
{
    public interface ILottResultDescRepository
    {

        IQueryable<LottResultDesc> GetAll();
        LottResultDesc GetById(int id);
        void Add(LottResultDesc lottResultDesc);
        bool Delete(int id);

        void Update(LottResultDesc lottResultDesc);
    }
}
