using lilgobguides.Data;
using lilgobguides.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace lilgobguides.Pages.Posts;

public class SkillingModel(AppDbContext db) : CategoryPageModel(db)
{
    public override async Task OnGet()
    {
        Posts = await _db.Posts.Where(p => p.Categorization.Skilling == true)
                        .AsNoTracking().ToListAsync();
    }
}