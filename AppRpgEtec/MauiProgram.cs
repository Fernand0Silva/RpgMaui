﻿using Microsoft.Extensions.Logging;
//using Microsoft.Maui.Controls.Maps;


namespace AppRpgEtec
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                }).UseMauiMaps();


    		//builder.Logging.AddDebug();


            return builder.Build();
        }
    }
}
