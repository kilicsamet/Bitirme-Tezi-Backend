using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;
using WebAPI.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;

namespace WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UrunlerController : ControllerBase
    {
        private readonly IWebHostEnvironment _env;
        private IUrunlerRepository repository;
        public UrunlerController(IUrunlerRepository repo, IWebHostEnvironment env)
        {
            repository = repo;
            _env = env;
        }
        [HttpGet]
        public IEnumerable<Urunler> Get()
        {
            return repository.Urunlers;
        }

        [HttpPost]
        public JsonResult Post(Urunler urun)
        {
            repository.CreateUrunler(urun);
            return new JsonResult("Ürün Başarılı Bir Şekilde Eklendi");
        }

        [HttpPut("{id}")]
        public JsonResult Put(Urunler u, int id)
        {
            Urunler urun = repository.Urunlers.Where(d => d.UrunlerID == id).FirstOrDefault();
            urun.UrunlerName = u.UrunlerName;
            urun.MusteriIsim = u.MusteriIsim;
            urun.MusteriSoyisim = u.MusteriSoyisim;
            urun.MusteriAdres = u.MusteriAdres;
            urun.PanelMetrekare = u.PanelMetrekare;
            urun.Fiyat = u.Fiyat;
            repository.SaveUrunler(urun);
            return new JsonResult("Panel Siparisi Başarılı Bir Şekilde Güncellendi.");
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Urunler urun = repository.Urunlers.Where(d => d.UrunlerID == id).FirstOrDefault();
            repository.DeleteUrunler(urun);
            return new JsonResult("Ürün Başarılı Bir Şekilde Silindi.");
        }

        [HttpGet("{id}")]
        public IEnumerable<Urunler> Get(int id)
        {
            yield return repository.Urunlers.Where(d => d.UrunlerID == id).FirstOrDefault();
        }
    }
}
