using MessagePack;

namespace Shared;

[MessagePackObject(true)]
public class Transaction
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public decimal Amount { get; set; }
    public DateTimeOffset CreatedAt { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Amount: {Amount}, CreatedAt: {CreatedAt}";
    }
}