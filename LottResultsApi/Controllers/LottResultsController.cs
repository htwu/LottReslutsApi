using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using LottResultsApi.IServices;
using LottResultsApi.Models;

namespace LottResultsApi.Controllers
{
    public class LottResultsController : ApiController
    {
        private readonly ILottResultService _lottResultService;

        public LottResultsController(ILottResultService lottResultService)
        {
            _lottResultService = lottResultService;
        }

        // GET: api/LottResults
        public IQueryable<LottResult> GetLottResults()
        {
            //no lazy loading to avoid multi data reader
//            try
//            {
                return _lottResultService.GetAll().Include(lr => lr.LottResultDesc)
                    .Include(lr => lr.LottResultDetails);
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e.Message);
//                return null;
//            }
        }

        // GET: api/LottResults/
        [ResponseType(typeof(LottResult))]
        public IHttpActionResult GetLottResult(string name)
        {
            LottResult lottResult = _lottResultService.GetByName(name);
            if (lottResult == null)
            {
                return NotFound();
            }

            return Ok(lottResult);
        }
    }
}