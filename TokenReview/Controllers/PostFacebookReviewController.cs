using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TokenReview.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class PostFacebookReviewController : ControllerBase
	{
		[HttpGet]
		public IActionResult PostFacebookReview()
		{
			// Your C# code to be executed goes here
			// You can return a response if needed
			return Ok(new { message = "C# code executed successfully" });
		}
	}

}
