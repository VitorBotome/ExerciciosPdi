using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers;


public class DeviceController : MyApiBaseController
{
    [HttpGet]
    public IActionResult Get()
    {
        var key = GetCustomKey();
        
        return Ok(key);
    }
}
