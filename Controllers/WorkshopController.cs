using Microsoft.AspNetCore.Mvc;

namespace DockerWorkshop.Controllers
{
    [Route("api/v0/workshops")]
    [ApiController]
    public class WorkshopController : ControllerBase
    {

        const string yourTheFuture = @"
 _   _             __       _                    _                         
| |_| |__   ___   / _|_   _| |_ _   _ _ __ ___  (_)___   _   _  ___  _   _ 
| __| '_ \ / _ \ | |_| | | | __| | | | '__/ _ \ | / __| | | | |/ _ \| | | |
| |_| | | |  __/ |  _| |_| | |_| |_| | | |  __/ | \__ \ | |_| | (_) | |_| |
 \__|_| |_|\___| |_|  \__,_|\__|\__,_|_|  \___| |_|___/  \__, |\___/ \__,_|
                                                         |___/             
";

        [HttpGet]
        public IActionResult GetWorkshop()
        {
            return Ok(yourTheFuture);
        }

    }
}
