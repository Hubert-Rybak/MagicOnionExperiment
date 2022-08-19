using System.Runtime.CompilerServices;
using MessagePack;
using MessagePack.Resolvers;

namespace Shared;

public static class ModuleInit
{
    [ModuleInitializer]
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