using Grpc.Core;

namespace EireGrpcService.Services
{
    public class GreeterService : Greeter.GreeterBase
    {
        public override Task<HelloReply> SayHello(HelloRequest request,
            ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello from Ireland, " + request.Name
            });
        }
    }
}
