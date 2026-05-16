using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApi.Communication.Requests;
using MyApi.Communication.Response;

namespace MyApi.Controllers
{
    
    public class AdmController : MyApiBaseController
    {
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IActionResult Get(int id)
        {
            var response = new User
            {
                Id = 1,
                name = "vitor",
                age = 7
                
            };
            return Ok(response);
        }

        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterUser), StatusCodes.Status201Created)]
        public IActionResult CreateUser([FromBody] RequestRegisterUser request)
        {
            var response = new ResponseRegisterUser
            {
                id = 1,
                name = request.Name,
            };

            return Created(string.Empty, response);
        }
        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult UpdateUser(
            [FromRoute] int id,
            [FromBody] RequestUpdateUser request)
        {
            //var update = new RequestUpdateUser;
            return NoContent();
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult DeleteUser()
        {
            return NoContent();
        }


        [HttpGet]
        [ProducesResponseType(typeof(List<User>), StatusCodes.Status200OK)]
        public IActionResult GetAll()
        {
            var response = new List<User>()
            {
                new User {Id = 1, name = "vitor", age = 7},
                new User {Id = 2, name = "joao", age = 9}
            };
            var key = GetCustomKey();
                
            
            return Ok(key);
        }

    }
}
