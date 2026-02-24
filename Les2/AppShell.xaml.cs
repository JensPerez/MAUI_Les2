namespace Les2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Als we een pagina niet in de hamburger willen of kunnen hebben, (bv. een detailpagina van een product op bol.com)
            // moeten we het op deze manier registreren. Altijd registratie in AppShell.
            Routing.RegisterRoute(nameof(NavigationPage), typeof(NavigationPage));
        }
    }
}
