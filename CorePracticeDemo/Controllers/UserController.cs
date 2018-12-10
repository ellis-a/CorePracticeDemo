using System.Web.Http;
using CorePracticeDemo.Services;
using CorePracticeDemo.Services.Models;

namespace CorePracticeDemo.Controllers
{
    [RoutePrefix("users")]
    public class UserController : ApiController
    {
        private UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet, Route("all")]
        public IHttpActionResult GetAll()
        {
            return Ok(_userService.GetAll());
        }

        [HttpGet, Route("{id}")]
        public IHttpActionResult GetById(int id)
        {
            return Ok(_userService.GetById(id));
        }

        [HttpPost, Route("")]
        public IHttpActionResult CreateUser(User user)
        {
            return Ok(_userService.Create(user));
        }

        [HttpPut, Route("{id}")]
        public IHttpActionResult UpdateUser(int id, User user)
        {
            user.Id = id;

            return Ok(_userService.Update(user));
        }

        [HttpDelete, Route("{id}")]
        public IHttpActionResult DeleteUser(int id, User user)
        {
            user.Id = id;

            return Ok(_userService.Delete(user));
        }
    }
}