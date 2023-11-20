using Fast_typing_App;
using Fast_typing_Kernel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Back_fast_typing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TargetTextController : ControllerBase
    {
        private readonly ILogger<TargetTextController> _logger;
        public readonly Facade _app;

        public TargetTextController(ILogger<TargetTextController> logger, IConfiguration conf)
        {
            _logger = logger;
            Uri path = conf.GetSection("DataSettings").GetValue<Uri>("FilePath");
            _app = new Facade(path);
        }

        // GET: api/<ValuesController>
        [HttpGet]
        [Route("text/{id_text}")]
        public async Task<TargetTextData> GetTargetTextDataAsync(string id_text)
        {
            return await _app.GetTargetTextDataAsync(id_text);
        }

    }
}
