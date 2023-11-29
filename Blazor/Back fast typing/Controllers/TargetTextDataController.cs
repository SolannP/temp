using Fast_typing_App;
using FastTypingKernel;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Back_fast_typing.Controllers
{
    [ApiController]
    [Route("api")]
    public class TargetTextDataController : ControllerBase
    {
        private readonly ILogger<TargetTextDataController> _logger;
        public static readonly Facade _app = new();

        public TargetTextDataController(ILogger<TargetTextDataController> logger, IConfiguration conf)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("target_text_data")]
        public async Task<TargetTextData> GetCommonData()
        {
            await _app.Initialise();
            return await _app.GetCommonApplicationDataAsync();
        }

        [HttpGet]
        [Route("target_text_data/{id_text}")]
        public async Task<TargetText> GetTargetTextAsync(string id_text)
        {
            await _app.Initialise();
            return _app.data.all_texts.First(element => element.id_text == id_text);
        }
    }
}