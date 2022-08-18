using MagicOnion;

namespace Shared;

public interface ITransactionService : IService<ITransactionService>
{
    Task<ServerStreamingResult<Transaction>> GetTransactions();
}