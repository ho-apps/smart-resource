using Prism.Ioc;
using Serilog;
using Serilog.Events;
using System.Windows;

namespace ResourceMaterials.Desktop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public sealed partial class App
    {
        private readonly ILogger _logger;
        public App()
        {
            Log.Logger = new LoggerConfiguration().WriteTo.RollingFile("logs/{HalfHour}.log",
                    outputTemplate: "[{Timestamp:HH:mm:ss:fff} {Level}] {Message}{NewLine}{Exception}",
                    restrictedToMinimumLevel: LogEventLevel.Debug)
                .Enrich
                .FromLogContext()
                .CreateLogger();
            _logger = Log.Logger;
        }

        protected override void RegisterTypes(IContainerRegistry container)
        {
            container.Register<ShellUI>();
        }

        protected override Window CreateShell()
        {
            return this.CreateContainerExtension().Resolve<ShellUI>();
        }
    }
}
