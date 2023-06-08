using Microsoft.EntityFrameworkCore;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    public class ServiceBase<T> where T : class
    {
        BankAccountTypeContext bankAccountTypeContext;
        DbSet<T> dbSet;

        public ServiceBase()
        {
            bankAccountTypeContext = new BankAccountTypeContext();
            dbSet = bankAccountTypeContext.Set<T>();
        }

        public List<T> GetAll()
        {
            return dbSet.ToList();
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
            bankAccountTypeContext.SaveChanges();
        }

        public bool Delete(T entity)
        {
            try
            {
                dbSet.Remove(entity);
                bankAccountTypeContext.SaveChanges();
                return true;
            } catch (Exception)
            {
                return false;
            }
        }

        public void Update(T entity) 
        { 
            var tracker = bankAccountTypeContext.Attach(entity);
            tracker.State = EntityState.Modified;
            bankAccountTypeContext.SaveChanges();
        }
    }
}
