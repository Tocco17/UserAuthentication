using Microsoft.AspNetCore.Mvc;
using UserAuthentication.api.Models;

namespace UserAuthentication.api.Controllers
{
	[ApiController]
	[Route("api/user")]
	public class UserController : ControllerBase
	{
		[HttpGet("fromemail/{email}")]
		public async Task<ActionResult<UserWithoutPasswordDto>> GetUserFromEmail(string email)
		{
			return Ok(email);
		}
	}
}
