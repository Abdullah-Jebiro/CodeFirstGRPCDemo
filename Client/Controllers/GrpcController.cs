using Microsoft.AspNetCore.Mvc;
using Shared;
using Shared.Contracts;
using System.Threading.Tasks;

[ApiController]
[Route("api/grpc")]
public class GrpcController : ControllerBase
{
    private readonly IGreeterService _greeterService;

    public GrpcController(IGreeterService greeterService)
    {
        _greeterService = greeterService;
    }

    [HttpGet("say-hello")]
    public async Task<IActionResult> SayHello(string name)
    {
        var response = await _greeterService.SayHelloAsync(new Request { Name = name });
        return Ok(response);
    }
}
