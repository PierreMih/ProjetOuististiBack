using Microsoft.EntityFrameworkCore;
using ProjetOuististiDomain.Calcul;
using ProjetOuististiDomain.Calculs;
using ProjetOuististiDomain.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetOuististiEntityFramework.Repositories
{
    public class CalculRepository : ICalculRepository
    {
        public void Add(CalculAbstract calc)
        {
            using (var db = new ProjetOuististiDbContext())
            {
                db.Calculs.Add(calc);
                db.SaveChanges();
            }
        }

        public IEnumerable<CalculAbstract> GetAll()
        {
            using (var db = new ProjetOuististiDbContext())
            {
                return db.Calculs.ToList();
            }
        }

        public Result GetResultFromCalcul(Guid calcul)
        {
            using (var db = new ProjetOuististiDbContext())
            {
                return db.Calculs.Where(c => c.Id == calcul).FirstOrDefault().GetResult();
            }
        }

        public Result Update(CalculAbstract calcul)
        {
            throw new NotImplementedException();
        }

        void ICalculRepository.Delete(Guid calcul)
        {
            using (var db = new ProjetOuististiDbContext())
            {
                var calc = db.Calculs.Where(c => c.Id.Equals(calcul));
                foreach(CalculAbstract c in calc)
                {
                    db.Calculs.Remove(c);
                }
                db.SaveChanges();
            }
        }
    }
}
