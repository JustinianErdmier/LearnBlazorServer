//  ---------------------------------------------------------------------------------------------------------------------------------
//  Copyright (c) Lieberman Technologies, LLC.  All rights reserved.
//  Copyright file: CounterModel.cs  Copyright project: LearnBlazorServer
//  ---------------------------------------------------------------------------------------------------------------------------------

namespace BlazorApp.Data;

public class CounterModel
{
    // private readonly ILogger _logger;
    //
    // public CounterModel(ILogger logger) => _logger = logger;

    public int CurrentCount { get; set; }

    public void IncrementCount()
    {
        CurrentCount++;
    }
}
