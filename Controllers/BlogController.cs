using BlogApi.BLL.Interfaces;
using BlogApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IPostService _postService;

        public BlogController(IUserService userService, IPostService postService)
        {
            _userService = userService;
            _postService = postService;
        }

        [HttpGet("users")]
        public async Task<ActionResult<IEnumerable<UserModel>>> GetUsers()
        {
            var users = _userService.GetAllUser();
            return Ok(users);
        }

        //[HttpGet("posts")]
        //public async Task<IActionResult> GetPosts()
        //{
        //    var posts = await _postService.GetAllAsync();
        //    return Ok(posts);
        //}
    }
}
