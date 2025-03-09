using System.ServiceModel;

namespace Shared.Contracts;

[ServiceContract]
public interface IGreeterService
{
    [OperationContract]
    Task<Response> SayHelloAsync(Request request);
}