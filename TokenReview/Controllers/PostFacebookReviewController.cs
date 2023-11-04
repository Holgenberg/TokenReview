using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TokenReview;

namespace TokenReview.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class PostFacebookReviewController : ControllerBase
	{
		[HttpGet]
		public async Task<IActionResult> PostFacebookReviewAsync()
		{
			string review = await ReviewGeneration.GenerateReview();
			return Ok(new { message = review });
		}
	}

}
