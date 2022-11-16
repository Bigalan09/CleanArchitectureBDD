using CleanArchitectureBDD.Application.Common.Interfaces;

namespace CleanArchitectureBDD.Infrastructure.Services;

internal class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
