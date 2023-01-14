using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class EFAraclarRepository : IAraclarRepository
    {
        private readonly IWebHostEnvironment _hostEnvironment;
        private DatabaseContext context;
        public EFAraclarRepository(DatabaseContext ctx, IWebHostEnvironment hostEnvironment)
        {
            context = ctx;
            _hostEnvironment = hostEnvironment;
        }

        public IQueryable<Araclar> Araclars => context.araclars;

        public void CreateAraclar(Araclar a)
        {
            try
            {
                context.Add(a);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteAraclar(Araclar a)
        {
            context.Remove(a);
            context.SaveChanges();
        }

        public void SaveAraclar(Araclar a)
        {
            context.Entry(a).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
