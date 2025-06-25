using PersonalAgendaAPI.DTOs;
using PersonalAgendaAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace PersonalAgendaAPI.Controllers
{
    [ApiController]
    [Route("api/post-category")]
    public class PostCategoryController : ControllerBase
    {
        private readonly PostCategoryService _service;

        public PostCategoryController(PostCategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostCategoryVM>>> GetAll()
        {
            try
            {
                var categories = await _service.GetAll();
                return Ok(categories);
            }
            catch
            {
                return StatusCode(500, "Something went wrong");
            }
        }
    }
}
