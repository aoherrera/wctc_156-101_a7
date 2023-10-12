using System;
using System.Globalization;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Utils;

namespace StringInterpolationTemplate.Services;

public class StringInterpolationService : IStringInterpolationService
{
    private readonly ISystemDate _date;
    private readonly ILogger<IStringInterpolationService> _logger;

    public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
    {
        _date = date;
        _logger = logger;
        _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
    }

    CultureInfo usa = new CultureInfo("en-US");
    double pi = Math.PI;

    //1. January 22, 2019 (right aligned in a 40 character field)
    public string Number01()
    {
        var date = _date.Now.ToString("MMMM dd, yyyy");
        var answer = $"{date,40}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number02()
    {
        var answer = $"{_date.Now.ToString("yyyy.MM.dd", usa)}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number03()
    {
        var answer = $"Day {_date.Now.Day} of {_date.Now.ToString("MMMM, yyyy")}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number04()
    {
        var answer = $"Year: {_date.Now.Year}, Month: {_date.Now.ToString("MM")}, Day: {_date.Now.Day}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number05()
    {
        var answer = $"{_date.Now.DayOfWeek,10}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number06()
    {
        var answer = $"{_date.Now.ToString("hh:ss tt", usa),10}" + $"{_date.Now.DayOfWeek,10}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number07()
    {
        var answer = $"h:{_date.Now.ToString("hh")}, m:{_date.Now.ToString("mm")}, s:{_date.Now.ToString("ss")}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number08()
    {
        var answer = $"{_date.Now.ToString("yyyy.MM.dd", usa)}.{_date.Now.ToString("hh.mm.ss")}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number09()
    {
        var answer = pi.ToString("C", usa);
        Console.WriteLine(answer);

        return answer;
    }

    public string Number10()
    {
        var answer = $"{pi,10:0.###}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number11()
    {
        var answer = $"{_date.Now.Year:X2}";

        return answer;
    }

    //2.2019.01.22
}
