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
    public class LottResultDescRepository:ILottResultDescRepository
    {
        protected LottResultContext db=new LottResultContext();
        public IQueryable<LottResultDesc> GetAll()
        {
            return db.LottResultDescs;
        }

        public LottResultDesc GetById(int id)
        {
            return db.LottResultDescs.FirstOrDefault(l => l.Id == id);
        }

        public void Add(LottResultDesc lottResultDesc)
        {
            db.LottResultDescs.Add(lottResultDesc);
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var deletedItem = db.LottResultDescs.FirstOrDefault(u => u.Id == id);
            if (deletedItem != null)
            {
                db.LottResultDescs.Remove(deletedItem);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Update(LottResultDesc lottResultDesc)
        {
            db.Entry(lottResultDesc).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}