using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using LottResultsApi.DAL;
using LottResultsApi.IRepositories;
using LottResultsApi.Models;

namespace LottResultsApi.Repositories
{
    public class LottResultDetailRepository:ILottResultDetailRepository
    {
        protected LottResultContext db = new LottResultContext();
        public IQueryable<LottResultDetail> GetAll()
        {
            return db.LottResultDetails;
        }

        public LottResultDetail GetById(int id)
        {
            return db.LottResultDetails.FirstOrDefault(l => l.Id == id);
        }

        public void Add(LottResultDetail lottResultDetail)
        {
            db.LottResultDetails.Add(lottResultDetail);
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var deletedItem = db.LottResultDetails.FirstOrDefault(u => u.Id == id);
            if (deletedItem != null)
            {
                db.LottResultDetails.Remove(deletedItem);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Update(LottResultDetail lottResultDetail)
        {
            db.Entry(lottResultDetail).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}