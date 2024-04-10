using eSimpleBlob.Domain.Entities.Session;
using eSimpleBlob.Handlers.Requests.Session;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace eSimpleBlob.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {

        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<TokenData?> SetSessionAsync(AuthSimple auth)
        {
            var authData = new AuthData
            {
                Credential = auth.Credential,
                Password = auth.Password,
                SessionStart = DateTime.Now,
                UsedIp = Request.HttpContext.Connection.RemoteIpAddress!.ToString()
            };

            var token = await _mediator.Send(new SetSessionRequest() { AuthData = authData });
            return token;
        }
    }
}

