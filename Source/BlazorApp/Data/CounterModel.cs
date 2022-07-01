//  ---------------------------------------------------------------------------------------------------------------------------------
//  Copyright (c) Lieberman Technologies, LLC.  All rights reserved.
//  Copyright file: CounterModel.cs  Copyright project: LearnBlazorServer
//  ---------------------------------------------------------------------------------------------------------------------------------

namespace BlazorApp.Data;

public class CounterModel
{
    private readonly ILogger<CounterModel> _logger;

    public CounterModel(ILogger<CounterModel> logger) => _logger = logger;

    public int CurrentCount { get; private set; }

    public void IncrementCount()
    {
        _logger.LogInformation("Current Count: {CurrentCount}", CurrentCount);
        CurrentCount++;
        _logger.LogInformation("New Count: {NewCount}", CurrentCount);
    }
}
