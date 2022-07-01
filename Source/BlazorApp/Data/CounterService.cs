//  ---------------------------------------------------------------------------------------------------------------------------------
//  Copyright (c) Lieberman Technologies, LLC.  All rights reserved.
//  Copyright file: CounterModel.cs  Copyright project: LearnBlazorServer
//  ---------------------------------------------------------------------------------------------------------------------------------

namespace BlazorApp.Data;

public class CounterService
    : ICounterService
{
    private readonly ILogger<CounterService> _logger;

    public CounterService(ILogger<CounterService> logger) => _logger = logger;

    public int CurrentCount { get; private set; }

    public void IncrementCount()
    {
        _logger.LogInformation("Current Count: {CurrentCount}", CurrentCount);
        CurrentCount += 1;
        _logger.LogInformation("New Count: {NewCount}", CurrentCount);
    }
}
