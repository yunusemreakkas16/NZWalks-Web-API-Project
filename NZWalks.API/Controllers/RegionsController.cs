using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;
using NZWalks.API.Models.DTO;

namespace NZWalks.API.Controllers
{
    // https://localhost:7280/api/regionDomain
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly NZWalksDbContext dbContext;

        public RegionsController(NZWalksDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET ALL REGIONS
        // GET: https://localhost:portnumber/api/regionDomain
        [HttpGet]
        public IActionResult GetAll()
        {
            // Get Data From Database - Domain models
            var regionDomain = dbContext.Regions.ToList();

            // Map Domain Models to DTOs
            var regionsDto = new List<RegionDto>();
            foreach (var region in regionDomain)
            {
                regionsDto.Add(new RegionDto()
                {
                    Id = region.Id,
                    Code = region.Code,
                    Name = region.Name,
                    RegionImageUrl = region.RegionImageUrl,
                });
            }

            // Return DTOs
            return Ok(regionsDto);
        }

        // GET SINGLE REGION (Get Region By ID)
        // GET: https://localhost:7280/api/regionDomain/{id}
        [HttpGet]
        [Route("{id:Guid}")]
        public IActionResult GetById(Guid id)
        {
            //  var regionDomain = dbContext.Regions.Find(id);
            // Get Data From Database - Domain models
            var regionDomain = dbContext.Regions.FirstOrDefault(r => r.Id == id);
            if (regionDomain == null)
            {
                return NotFound();
            }

            // Map/ Convert Region Domain Model to Region DTO
            var regionDto = new RegionDto()
            {
                Id = regionDomain.Id,
                Code = regionDomain.Code,
                Name = regionDomain.Name,
                RegionImageUrl = regionDomain.RegionImageUrl,
            };
            return Ok(regionDto);
        }
    }
}
