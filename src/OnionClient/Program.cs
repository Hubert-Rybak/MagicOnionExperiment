using Grpc.Core;
using Grpc.Net.Client;
using MagicOnion.Client;
using Shared;

var channel = GrpcChannel.ForAddress("https://localhost:7070");

var client = MagicOnionClient.Create<ITransactionService>(channel);
var stream = await client.GetTransactions();

await foreach (var transaction in stream.ResponseStream.ReadAllAsync())
{
    Console.WriteLine(transaction.ToString());
}