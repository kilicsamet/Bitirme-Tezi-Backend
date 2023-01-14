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
using Azure.Storage.Blobs;

namespace WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AraclarController : ControllerBase
    {
        private readonly IWebHostEnvironment _env;
        private IAraclarRepository repository;
        private string _connectionString = "DefaultEndpointsProtocol=https;AccountName=photoswebapi;AccountKey=VEdRdEiuH3gBJXFivYFgNealoGGYn4OyDD7os0+c4yEmebJjy7FFi012GCi+VDjrMP+S6TtZp+pE+ASt9Su12A==;EndpointSuffix=core.windows.net";
        public AraclarController(IAraclarRepository repo, IWebHostEnvironment env)
        {
            repository = repo;
            _env = env;
        }
        [HttpGet]
        public IEnumerable<Araclar> Get()
        {
            return repository.Araclars;
        }     

        [HttpPost]
        public async Task<IActionResult> Post([FromForm] Araclar arac, IList<IFormFile> files)
        {
            BlobContainerClient blobContainerClient = new BlobContainerClient(_connectionString, "pics");
            foreach (IFormFile file in files)
            {
                using (var stream = new MemoryStream())
                {
                    await file.CopyToAsync(stream);
                    stream.Position = 0;
                    await blobContainerClient.UploadBlobAsync(file.FileName, stream);
                }
            }
            arac.AraclarURL = files[0].FileName;
            repository.CreateAraclar(arac);
            return Ok("Yuklendi !");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromForm] Araclar a,int id, IList<IFormFile> files)
        {
            BlobContainerClient blobContainerClient = new BlobContainerClient(_connectionString, "pics");
            foreach (IFormFile file in files)
            {
                using (var stream = new MemoryStream())
                {
                    await file.CopyToAsync(stream);
                    stream.Position = 0;
                    await blobContainerClient.UploadBlobAsync(file.FileName, stream);
                }
            }
            Araclar arac  = repository.Araclars.Where(d => d.AraclarID == id).FirstOrDefault();
            arac.AraclarName = a.AraclarName;
            arac.AraclarHiz = a.AraclarHiz;
            arac.AraclarSeri = a.AraclarSeri;
            arac.AraclarDurum = a.AraclarDurum;
            arac.AraclarYil = a.AraclarYil;
            arac.AraclarRenk= a.AraclarRenk;
            arac.AraclarModel = a.AraclarModel;
            arac.AraclarYakit = a.AraclarYakit;
            arac.AraclarFiyat = a.AraclarFiyat;

            if(files.Count != 0)
            {
                arac.AraclarURL = files[0].FileName;
            }
            repository.SaveAraclar(arac);
            return new JsonResult("Araç Başarılı Bir Şekilde Güncellendi.");

        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Araclar arac = repository.Araclars.Where(d => d.AraclarID == id).FirstOrDefault();
            repository.DeleteAraclar(arac);
            return new JsonResult("Araç Başarılı Bir Şekilde Silindi.");
        }

        [HttpGet("{id}")]
        public IEnumerable<Araclar> Get(int id)
        {
            yield return repository.Araclars.Where(d => d.AraclarID == id).FirstOrDefault();
        }
    }
}
