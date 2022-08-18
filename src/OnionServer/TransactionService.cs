using MagicOnion;
using MagicOnion.Server;
using Shared;

namespace OnionServer;

public class TransactionService : ServiceBase<ITransactionService>, ITransactionService
{
    public async Task<ServerStreamingResult<Transaction>> GetTransactions()
    {
        var stream = GetServerStreamingContext<Transaction>();

        for (var i = 0; i < 10; i++)
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            
            await stream.WriteAsync(new Transaction
            {
                Id = Guid.NewGuid(),
                Amount = Decimal.Zero + i,
                Name = $"Transaction {i}",
                CreatedAt = DateTimeOffset.Now
            });
        }

        return stream.Result();
    }
}