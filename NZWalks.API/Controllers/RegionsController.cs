using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NZWalks.API.CustomActionFilters;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;
using NZWalks.API.Models.DTO;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers
{
    // https://localhost:7280/api/regionDomain
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly NZWalksDbContext dbContext;
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;

        public RegionsController(NZWalksDbContext dbContext, IRegionRepository regionRepository, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }

        // GET ALL REGIONS
        // GET: https://localhost:portnumber/api/regionDomain
        [HttpGet]
        [Authorize(Roles = "Reader")]
        public async Task<IActionResult> GetAll()
        {
            
            // Get Data From Database - Domain models 
                                                                            
            var regionDomain = await regionRepository.GetAllAsync();

            /*
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
            */

            // Return DTOs
            return Ok(mapper.Map<List<RegionDto>>(regionDomain)); 
        }

        // GET SINGLE REGION (Get Region By ID)
        // GET: https://localhost:7280/api/regionDomain/{id}
        [HttpGet]
        [Route("{id:Guid}")]
        [Authorize(Roles = "Reader")]
        public async  Task<IActionResult> GetById(Guid id)
        {
            //  var regionDomain = dbContext.Regions.Find(id);
            // Get Data From Database - Domain models
            var regionDomain = await regionRepository.GetByIdAsync(id);
            if (regionDomain == null)
            {
                return NotFound();
            }

            //Return DTO back to client
            return Ok(mapper.Map<RegionDto>(regionDomain));
        }

        // POST To Create New Region
        // POST: https://localhost:7280/api/regions
        [HttpPost]
        [ValidateModel]
        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> Create([FromBody] AddRegionRequestDto addRegionRequestDto)
        {


            // Map or Convert DTO to Domain Model
            var regionDomainModel = mapper.Map<Region>(addRegionRequestDto);

            // Use Domain Model to create Region
            regionDomainModel = await regionRepository.CreateAsync(regionDomainModel);

            var regionDto = mapper.Map<RegionDto>(regionDomainModel);

            return CreatedAtAction(nameof(GetById), new { id = regionDto.Id }, regionDto);
        }

        // Update Region
        // PUT: https://localhost:7270/api/regions/{id}
        [HttpPut]
        [Route("{id:Guid}")]
        [ValidateModel]
        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateRegionRequestDto updateRegionRequestDto)
        {
            // Map DTO to Domain Model
            var regionDomainModel = mapper.Map<Region>(updateRegionRequestDto);

            //Check if region exist
            regionDomainModel = await regionRepository.UpdateAsync(id, regionDomainModel);

            if (regionDomainModel == null)
            {
                return NotFound();
            }
            // Convert Domain Model to DTO and return it

            return Ok(mapper.Map<RegionDto>(regionDomainModel));

        }
        // Delete Region
        // DELETE: https://localhost:7270/api/regions/{id}
        [HttpDelete]
        [Route("{id:Guid}")]
        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> Delete([FromRoute] Guid id) 
        {
            var regionDomainModel = await regionRepository.DeleteAsync(id);

            if(regionDomainModel == null)
            {
                return NotFound();
            }

            // return deleted Region back
            // map Domain model to DTO
            return Ok(mapper.Map<RegionDto>(regionDomainModel));
        }

    }
}
