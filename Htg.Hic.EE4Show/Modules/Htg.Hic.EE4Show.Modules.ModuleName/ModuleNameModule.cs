using Htg.Hic.EE4Show.Core;
using Htg.Hic.EE4Show.Modules.ModuleName.Views;

namespace Htg.Hic.EE4Show.Modules.ModuleName;

public class ModuleNameModule(IRegionManager regionManager) : IModule
{
	private readonly IRegionManager _regionManager = regionManager;

	public void OnInitialized(IContainerProvider containerProvider)
	{
		_regionManager.RequestNavigate(RegionNames.ContentRegion, "ViewA");
	}

	public void RegisterTypes(IContainerRegistry containerRegistry)
	{
		containerRegistry.RegisterForNavigation<ViewA>();
	}
}