namespace GettingStarted.Consumers;

using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

using Contracts;
using MassTransit;

public class GettingStartedConsumer : IConsumer<GettingStarted>
{
    private readonly ILogger<GettingStartedConsumer> _logger;

    public GettingStartedConsumer(ILogger<GettingStartedConsumer> logger)
    {
        _logger = logger;
    }

    public Task Consume(ConsumeContext<GettingStarted> context)
    {
        _logger.LogInformation("Received Text: {Text}", context.Message.Value);
        
        return Task.CompletedTask;
    }
}
