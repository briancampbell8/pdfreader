using Microsoft.AspNetCore.Mvc;

namespace YourProject.Controllers
{
    [Route("[controller]")]
    public class OAuthController : Controller
    {
        // This endpoint will handle the OAuth redirect from Zoom.
        // The 'code' parameter contains the authorization code returned by Zoom.
        [HttpGet("redirect")]
        public IActionResult RedirectHandler([FromQuery] string code)
        {
            // Here you might exchange the code for an access token if needed.
            // For now, just return a simple confirmation message.
            return Content("Redirect successful. You may close this window.");
        }
    }
}
