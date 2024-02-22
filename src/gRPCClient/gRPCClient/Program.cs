// See https://aka.ms/new-console-template for more information
using Grpc.Net.Client;
using GrpcClient;

Console.WriteLine("Press any key to send request");
Console.ReadLine();

using var channel = GrpcChannel.ForAddress("http://localhost:5005");
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(new HelloRequest { Name = "Priyesh" });
Console.WriteLine($"Greetings: {reply.Message}");
Console.WriteLine("Press any key to exit");
Console.ReadLine();
