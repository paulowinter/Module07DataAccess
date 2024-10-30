using Microsoft.Extensions.Logging;

namespace Module07DataAccess
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
                    fonts.AddFont("Nunito-VariableFont_wght.ttf", "Nunito");
                    fonts.AddFont("Nunito-Italic-VariableFont_wght.ttf", "NunitoItalic");
                    fonts.AddFont("Quicksand-VariableFont_wght.ttf", "Quicksand");
                    fonts.AddFont("Raleway-Italic-VariableFont_wght.ttf", "RalewayItalic");
                    fonts.AddFont("Raleway-VariableFont_wght.ttf", "Raleway");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
