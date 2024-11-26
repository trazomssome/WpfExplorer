using WpfExplorer.Properties;

namespace WpfExplorer
{
    internal class Stater
    {
        [STAThread]
        private static void Main(string[] args)
        {
            _ = new App()
                .AddInversionModule<HelperModules>()
                .AddWireDataContext<WireDataContext>()
                .Run();
        }
    }
}
