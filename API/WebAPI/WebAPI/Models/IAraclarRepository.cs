using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public interface IAraclarRepository
    {
        IQueryable<Araclar> Araclars { get; }
        void SaveAraclar(Araclar a);
        void CreateAraclar(Araclar a);
        void DeleteAraclar(Araclar a);
    }
}
