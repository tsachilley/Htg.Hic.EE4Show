using Htg.Hic.EE4Show.Modules.ModuleName;
using Htg.Hic.EE4Show.Services;
using Htg.Hic.EE4Show.Services.Interfaces;
using Htg.Hic.EE4Show.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace Htg.Hic.EE4Show;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App
{
	protected override Window CreateShell()
	{
		return Container.Resolve<MainWindow>();
	}

	protected override void RegisterTypes(IContainerRegistry containerRegistry)
	{
		containerRegistry.RegisterSingleton<IMessageService, MessageService>();
	}

	protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
	{
		moduleCatalog.AddModule<ModuleNameModule>();
	}
}
