using Fast_typing_App;
using FastTypingKernel;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Back_fast_typing.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommonController : ControllerBase
    {

        private readonly ILogger<CommonController> _logger;
        public static readonly Facade _app = new(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)));

        public CommonController(ILogger<CommonController> logger, IConfiguration conf)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("common_data")]
        public async Task<TargetTextData> GetCommonData()
        {
            await _app.Initialise();
            return await _app.GetCommonApplicationDataAsync();
        }
    }
}