using P21.Extensions.BusinessRule;

namespace P21Custom.Entity.Services
{
    public interface ILoggingService
    {
        Rule CurrentRule { get; set; }
    }
}