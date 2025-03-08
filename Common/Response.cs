using ProtoBuf.Grpc;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Shared.Contracts;

[DataContract]
public class Response
{
    [DataMember(Order = 1)]
    public string Message { get; set; }
}
