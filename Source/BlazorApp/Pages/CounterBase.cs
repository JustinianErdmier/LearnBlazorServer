//  ---------------------------------------------------------------------------------------------------------------------------------
//  Copyright (c) Lieberman Technologies, LLC.  All rights reserved.
//  Copyright file: CounterBase.cs  Copyright project: LearnBlazorServer
//  ---------------------------------------------------------------------------------------------------------------------------------

using BlazorApp.Data;

using Microsoft.AspNetCore.Components;

namespace BlazorApp.Pages;

public class CounterBase : ComponentBase
{
    [ Inject ]
    public ICounterService CounterService { get; set; } = null!;

    protected int CurrentCount;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        CurrentCount = CounterService.CurrentCount;
    }

    protected void IncrementCount()
    {
        CounterService.IncrementCount();
        CurrentCount = CounterService.CurrentCount;
    }
}
