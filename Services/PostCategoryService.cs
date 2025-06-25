using PersonalAgendaAPI.DTOs;
using Microsoft.EntityFrameworkCore;

namespace PersonalAgendaAPI.Services
{
    public class PostCategoryService
    {
        private readonly AppDbContext _context;

        public PostCategoryService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PostCategoryVM>> GetAll()
        {
            try
            {
                var PostCategories = await _context.postCategories
                    .Include(x => x.DisplaySettings)
                    .ToListAsync();

                return PostCategories
                    .Select(x => PostCategoryVM.FromEntity(x, x.DisplaySettings))
                    .ToList();
            }
            catch (Exception ex)
            {
                throw;
            }

        }


    }
}
