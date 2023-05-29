using Grpc.Net.Client;
using SumClientApp;
 
// создаем канал для обмена сообщениями с сервером
// параметр - адрес сервера gRPC
using var channel = GrpcChannel.ForAddress("http://localhost:5102");
// создаем клиент
var client = new SumClientApp.SumService.SumServiceClient(channel);

var nn = new NumbersRequest();
nn.Number1=Int32.Parse(Console.ReadLine());
nn.Number2=Int32.Parse(Console.ReadLine());

var reply = client.Summing(nn);
Console.WriteLine($"Відповідь: {reply.Sum}");

