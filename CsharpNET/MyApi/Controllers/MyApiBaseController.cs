using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers;

[Route("vitor/[controller]")]
[ApiController]
public class MyApiBaseController : ControllerBase
{
    public string Author { get; set; } = "Vitor Lindo";

    protected string GetCustomKey()
    {
        return Request.Headers["Mykey"].ToString();
    }
    
}
