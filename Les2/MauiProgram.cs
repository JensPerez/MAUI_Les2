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
            // dit maakt een object aan elke keer als het aangevraagd word.

            builder.Services.AddScoped<PersoonVM>();
            builder.Services.AddScoped<View>();
            
            builder.Services.AddScoped<Oefening2VM>();
            builder.Services.AddScoped<Oefening2>();
            
            builder.Services.AddScoped<NamenViewModel>();
            builder.Services.AddScoped<NamenPage>();

            builder.Services.AddScoped<WerknemerViewModel>();
            builder.Services.AddScoped<WerknemerPage>();

            builder.Services.AddScoped<IWerknemerRepo, WerknemerRepo>();
            builder.Services.AddScoped<IFunctieRepo, FunctieRepo>();

            builder.Services.AddScoped<NavigationViewModel>();
            builder.Services.AddScoped<NavigationPage>();




            return builder.Build();


        }
    }
}
