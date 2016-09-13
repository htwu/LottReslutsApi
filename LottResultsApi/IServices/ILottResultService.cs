using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LottResultsApi.Models;

namespace LottResultsApi.IServices
{
    public interface ILottResultService
    {
        IQueryable<LottResult> GetAll();
        LottResult GetByName(string name);
    }
}
