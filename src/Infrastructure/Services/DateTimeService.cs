using myapp.Application.Common.Interfaces;

namespace myapp.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
