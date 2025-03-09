using Shared.Contracts;
namespace Server;
public class GreeterService : IGreeterService
{
    public Task<Response> SayHelloAsync(Request request)
    {
        var responseMessage = GenerateGreeting(request.Name);
        return Task.FromResult(new Response { Message = responseMessage });
    }

    private string GenerateGreeting(string name)
    {
        return $"Hello {name.ToUpper()}";
    }
}