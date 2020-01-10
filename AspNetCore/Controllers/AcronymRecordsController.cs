using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AcronymRecordsController : ControllerBase
  {
    private readonly ApplicationDbContext _dbContext;

    public AcronymRecordsController(ApplicationDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    // GET api/acronymrecords
    [HttpGet]
    public async Task<ActionResult<List<AcronymRecord>>> Get()
    {
      return await _dbContext.AcronymRecords.ToListAsync();
    }

    // GET api/acronymrecords/5
    [HttpGet("{id}")]
    public async Task<ActionResult<AcronymRecord>> Get(string id)
    {
      return await _dbContext.AcronymRecords.FindAsync(id);
    }

    // POST api/acronymrecords
    [HttpPost]
    public async Task Post(AcronymRecord model)
    {
      await _dbContext.AddAsync(model);
      
      await _dbContext.SaveChangesAsync();
    }

    // PUT api/acronymrecords/5
    [HttpPut("{id}")]
    public async Task<ActionResult> Put(string id, AcronymRecord model)
    {
      var exists = await _dbContext.AcronymRecords.AnyAsync(f => f.Id == id);
      if (!exists)
      {
        return NotFound();
      }

      _dbContext.AcronymRecords.Update(model);
      
      await _dbContext.SaveChangesAsync();

      return Ok();

    }

    // DELETE api/acronymrecords/5
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(string id)
    {
      var entity = await _dbContext.AcronymRecords.FindAsync(id);

      _dbContext.AcronymRecords.Remove(entity);
      
      await _dbContext.SaveChangesAsync();
      
      return Ok();
    }
  }
}