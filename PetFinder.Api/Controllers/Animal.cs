using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PetFinder.Api.Controllers
{
	[Route("api/animal")]
	[ApiController]
	public class Animal : ControllerBase
	{
		[HttpGet]
		public string GetString()
		{
			return "Hello, garotão!";
		}
	}
}
