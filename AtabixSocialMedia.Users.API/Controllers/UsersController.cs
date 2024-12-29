using AtabixSocialMedia.Users.Application.Commands.SingUpUser;
using AtabixSocialMedia.Users.Application.Commands.UpdateUser;
using AtabixSocialMedia.Users.Application.Queries.GetUserById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtabixSocialMedia.Users.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id) 
        { 
            var query = new GetUserByIdQuery(id);

            var result = await _mediator.Send(query);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(SignUpUserCommand command) 
        { 
            var result = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = result.Data }, command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(UpdateUserCommand command) 
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }
    }
}
