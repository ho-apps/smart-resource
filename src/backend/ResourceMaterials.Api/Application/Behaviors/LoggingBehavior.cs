using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;

namespace ResourceMaterials.Api.Application.Behaviors
{
    public class LoggingBehavior<TReq, TRes> : IPipelineBehavior<TReq, TRes>
    {
        private readonly ILogger<LoggingBehavior<TReq, TRes>> _logger;

        public LoggingBehavior(ILogger<LoggingBehavior<TReq, TRes>> logger)
        {
            _logger = logger;
        }

        public async Task<TRes> Handle(TReq request, CancellationToken cancellationToken, RequestHandlerDelegate<TRes> next)
        {
            _logger.LogInformation($"Handling {typeof(TReq).Name}");

            TRes res = await next();

            _logger.LogInformation($"Handled {typeof(TRes).Name}");

            return res;
        }
    }

}