using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioAPI.Data;
using PortfolioAPI.Models;


[Route("api/[controller]")]
[ApiController]

public class SkillsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SkillsController (ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Skill>>> GetSkill()
        {
            return await _context.Skills.ToListAsync();
        }
        
    [HttpPost]
    public async Task<ActionResult<Skill>> PostSkill(Skill skill)
    {
        // Ensure the ID is not set manually
        skill.Id = 0;

        _context.Skills.Add(skill);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetSkill), new { id = skill.Id }, skill);
    }

}
