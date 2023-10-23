using ProtoBuf.Grpc;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Shared.Contracts;

[DataContract]
public class Response
{
    [DataMember(Order = 1)]
    public string Message { get; set; }
}

[DataContract]
public class Request
{
    [DataMember(Order = 1)]
    public string Name { get; set; }
}

[ServiceContract]
public interface IGreeterService
{
    [OperationContract]
    Task<Response> SayHelloAsync(Request request);
}