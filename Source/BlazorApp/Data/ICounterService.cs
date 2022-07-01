//  ---------------------------------------------------------------------------------------------------------------------------------
//  Copyright (c) Lieberman Technologies, LLC.  All rights reserved.
//  Copyright file: ICounterService.cs  Copyright project: LearnBlazorServer
//  ---------------------------------------------------------------------------------------------------------------------------------

namespace BlazorApp.Data;

public interface ICounterService
{
    int CurrentCount { get; }

    void IncrementCount();
}
