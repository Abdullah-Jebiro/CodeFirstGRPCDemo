using ProtoBuf.Grpc;
using Shared.Contracts;

public class GreeterService : IGreeterService
{
    //public Task<Response> SayHelloAsync(Request request, CallContext context = default)
    //{
    //    return Task.FromResult(
    //            new Response
    //            {
    //                Message = $"Hello {request.Name}"
    //            });
    //}

    public Task<Response> SayHelloAsync(Request request)
    {
        return Task.FromResult(
                new Response
                {
                    Message = $"Hello {request.Name.ToUpper()}"
                });
    }
}