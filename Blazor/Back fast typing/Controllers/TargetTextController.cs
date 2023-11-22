using Fast_typing_App;
using FastTypingKernel;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Back_fast_typing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TargetTextController : ControllerBase
    {
        private readonly ILogger<TargetTextController> _logger;
        public static readonly Facade _app = new(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)));

        public TargetTextController(ILogger<TargetTextController> logger, IConfiguration conf)
        {
            _logger = logger;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        [Route("text/{id_text}")]
        public async Task<TargetText> GetTargetTextAsync(string id_text)
        {
            _app.Initialise();
            return  _app.data.all_texts.First(element => element.id_text == id_text);
        }

    }
}
