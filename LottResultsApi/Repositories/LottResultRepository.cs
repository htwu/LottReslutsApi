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
    public class LottResultRepository:ILottResultRepository, IDisposable
    {
        protected LottResultContext db = new LottResultContext();
        public IQueryable<LottResult> GetAll()
        {
            return db.LottResults;
        }

        public LottResult GetById(int id)
        {
            return db.LottResults.FirstOrDefault(l => l.Id == id);
        }

        public LottResult GetByName(string name)
        {
            return db.LottResults.FirstOrDefault(l => l.Name == name);
        }

        public void Add(LottResult lottResult)
        {
            db.LottResults.Add(lottResult);
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var deletedItem = db.LottResults.FirstOrDefault(u => u.Id == id);
            if (deletedItem != null)
            {
                db.LottResults.Remove(deletedItem);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Update(LottResult lottResult)
        {
            db.Entry(lottResult).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}