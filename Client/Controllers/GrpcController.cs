using Microsoft.AspNetCore.Mvc;
using Shared;
using Shared.Contracts;
using System.Threading.Tasks;

[ApiController]
[Route("api/grpc")]
public class GrpcController(IGreeterService greeterService) : ControllerBase
{
    [HttpGet("say-hello")]
    public async Task<IActionResult> SayHello(string name)
    {
        var response = await greeterService.SayHelloAsync(new Request { Name = name });
        return Ok(response);
    }
}
