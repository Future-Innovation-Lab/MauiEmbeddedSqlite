using MauiEmbeddedSqliteExample.Services;
using MauiEmbeddedSqliteExample.ViewModel;
using MauiEmbeddedSqliteExample.Views;
using Microsoft.Extensions.Logging;

namespace MauiEmbeddedSqliteExample
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
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<MusicDatabaseService>();
            builder.Services.AddSingleton<MusicViewModel>();
            builder.Services.AddTransient<MusicView>();

            return builder.Build();
        }
    }
}
