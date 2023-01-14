using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private string _connectionString = "DefaultEndpointsProtocol=https;AccountName=photoswebapi;AccountKey=VEdRdEiuH3gBJXFivYFgNealoGGYn4OyDD7os0+c4yEmebJjy7FFi012GCi+VDjrMP+S6TtZp+pE+ASt9Su12A==;EndpointSuffix=core.windows.net";

        [HttpPost("action")]
        public async Task<IActionResult> UploadFilesToStorage(IList<IFormFile> files)
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
            return Ok("Yuklendi !");
        }

    }
}