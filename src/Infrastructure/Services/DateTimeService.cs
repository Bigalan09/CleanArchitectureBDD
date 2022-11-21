using CleanArchitectureBDD.Application.Common;

namespace CleanArchitectureBDD.Infrastructure.Services;

internal class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
