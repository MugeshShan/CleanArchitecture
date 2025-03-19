using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Extensions.Logging;

namespace SampleProject.Infrastructure;

public static class SerilogExtensions
{
    public static readonly LoggerProviderCollection loggerProviderCollection = new LoggerProviderCollection();

    public static ILogger ConfigureSerilog() => new LoggerConfiguration().CreateLogger();

    public static IHostBuilder UseSerilog(this IHostBuilder hostBuilder) =>
        return builder.UseSerilog(providers: loggerProviderCollection);
}
