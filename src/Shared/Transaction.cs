using MessagePack;

namespace Shared;

[MessagePackObject(true)]
public record Transaction(Guid Id, string Name, decimal Amount, DateTimeOffset CreatedAt);