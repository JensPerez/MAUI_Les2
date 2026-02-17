using Microsoft.Extensions.Logging;
using Les2.ViewModel;

namespace Les2
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
            builder.Services.AddScoped<PersoonVM>();
            builder.Services.AddScoped<View>();
            
            builder.Services.AddScoped<Oefening2VM>();
            builder.Services.AddScoped<Oefening2>();
            
            builder.Services.AddScoped<NamenViewModel>();
            builder.Services.AddScoped<NamenPage>();


            return builder.Build();


        }
    }
}
