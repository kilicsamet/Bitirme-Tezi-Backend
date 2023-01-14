using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public interface IUrunlerRepository
    {
        IQueryable<Urunler> Urunlers { get; }
        void SaveUrunler(Urunler u);
        void CreateUrunler(Urunler u);
        void DeleteUrunler(Urunler u);
    }
}
