using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class EFUrunlerRepository : IUrunlerRepository
    {
        private readonly IWebHostEnvironment _hostEnvironment;
        private DatabaseContext context;
        public EFUrunlerRepository(DatabaseContext ctx, IWebHostEnvironment hostEnvironment)
        {
            context = ctx;
            _hostEnvironment = hostEnvironment;
        }

        public IQueryable<Urunler> Urunlers => context.urunlers;

        public void CreateUrunler(Urunler u)
        {
            try
            {
                context.Add(u);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteUrunler(Urunler u)
        {
            context.Remove(u);
            context.SaveChanges();
        }

        public void SaveUrunler(Urunler u)
        {

            context.Entry(u).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
