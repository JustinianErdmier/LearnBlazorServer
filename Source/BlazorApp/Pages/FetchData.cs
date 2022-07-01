//  ---------------------------------------------------------------------------------------------------------------------------------
//  Copyright (c) Lieberman Technologies, LLC.  All rights reserved.
//  Copyright file: FetchData.cs  Copyright project: LearnBlazorServer
//  ---------------------------------------------------------------------------------------------------------------------------------

using BlazorApp.Data;

using Microsoft.AspNetCore.Components;

namespace BlazorApp.Pages;

public partial class FetchData
{
    [ Inject ]
    public WeatherForecastService ForecastService { get; set; } = null!;

    private WeatherForecast[]? forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }
}
