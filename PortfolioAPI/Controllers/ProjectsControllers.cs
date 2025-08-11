using Microsoft.AspNetCore.Mvc;
using PortfolioAPI.Data;
using PortfolioAPI.Models;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class ProjectsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public ProjectsController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/projects
    [HttpGet]
    public async Task<IActionResult> GetProjects()
    {
        var projects = await _context.Projects.ToListAsync();
        return Ok(projects);
    }

    // POST: api/projects
    [HttpPost]
    public async Task<IActionResult> AddProject(Project project)
    {
        _context.Projects.Add(project);
        await _context.SaveChangesAsync();
        return Ok(project);
    }
}
