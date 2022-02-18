using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MontyHallRESTController.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MontyController : ControllerBase
    {
        [HttpGet("{numberOfSimulations}/{switchDoor}")]
        public string GetQuery(int numberOfSimulations, int switchDoor)
        {

            MontyHallProblem mhp = new();
            var result = mhp.RunGame(numberOfSimulations, switchDoor).ToString();

            string reply = $"You win {result} out of {numberOfSimulations} times!\nTry running the simulation again, but this time switching the door!";

            if (switchDoor == 1)
            {
                reply = $"You win {result} out of {numberOfSimulations} times!\nTry running the simulation again without switching the door!";
            }

            return reply;
        }
    }
}
