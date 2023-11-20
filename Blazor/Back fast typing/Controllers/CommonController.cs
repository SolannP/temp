using Fast_typing_App;
using FastTypingKernel;
using Microsoft.AspNetCore.Mvc;

namespace Back_fast_typing.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommonController : ControllerBase
    {

        private readonly ILogger<CommonController> _logger;
        public readonly Facade _app;

        public CommonController(ILogger<CommonController> logger, IConfiguration conf)
        {
            _logger = logger;
            Uri path = conf.GetSection("DataSettings").GetValue<Uri>("FilePath");
            _app = new Facade(path);
        }

        [HttpGet]
        [Route("common_data")]
        public async Task<CommonApplicationData> GetCommonData()
        {
            return await _app.GetCommonApplicationDataAsync();
        }
    }
}