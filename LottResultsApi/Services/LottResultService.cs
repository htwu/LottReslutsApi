using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LottResultsApi.IRepositories;
using LottResultsApi.IServices;
using LottResultsApi.Models;

namespace LottResultsApi.Services
{
    public class LottResultService:ILottResultService
    {
        private readonly ILottResultRepository _lottResultRepository;

        public LottResultService(ILottResultRepository lottResultRepository)
        {
            _lottResultRepository = lottResultRepository;
        }
        public IQueryable<LottResult> GetAll()
        {
            return _lottResultRepository.GetAll();
        }

        public LottResult GetByName(string name)
        {
            return _lottResultRepository.GetByName(name);
        }
    }
}