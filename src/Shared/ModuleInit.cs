using System.Runtime.CompilerServices;
using MessagePack;
using MessagePack.Resolvers;

namespace Shared;

public static class ModuleInit
{
#pragma warning disable CA2255
    [ModuleInitializer]
#pragma warning restore CA2255
    public static void Init()
    {
        StaticCompositeResolver.Instance.Register(
            MessagePack.Resolvers.GeneratedResolver.Instance,
            StandardResolver.Instance
        );

        MessagePackSerializer.DefaultOptions = MessagePackSerializer.DefaultOptions
                                                                    .WithResolver(StaticCompositeResolver.Instance);
    }
}