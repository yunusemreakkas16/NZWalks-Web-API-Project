using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.DTO;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        // POST: /api/Images/Upload
        [HttpPost]
        [Route("Upload")]
        public async Task<IActionResult> Upload([FromForm] ImageUploadRequestDto requestDto)
        {
            ValidateFileUpload(requestDto);

            if(ModelState.IsValid)
            {
                return Ok();
            }

            return BadRequest();
        }
        
        //Validation
        private void ValidateFileUpload (ImageUploadRequestDto requestDto)
        {
            var allowedExtensions = new string[] { ".jpg", ".jpeg", ".png", ".jxr" };

            if (!allowedExtensions.Contains(Path.GetExtension(requestDto.FileName)))
            {
                ModelState.AddModelError("file", "Unsupported file extension");
            }

            if (requestDto.File.Length > 52428800)
            {
                ModelState.AddModelError("file", "File size more than 50MB, please upload smaller size file");
            }
        }
    }
}
