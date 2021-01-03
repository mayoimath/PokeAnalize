using BattleAnalisys.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace BattleAnalisys
{
	/// <summary>
	/// 選出分析
	/// </summary>
	public class BattleAnalisysModule : IModule
	{
		public void OnInitialized(IContainerProvider containerProvider)
		{
			var regiMan = containerProvider.Resolve<IRegionManager>();
			regiMan.RegisterViewWithRegion("BattleAnalisys", typeof(Views.BattleAnalisys));
		}

		public void RegisterTypes(IContainerRegistry containerRegistry)
		{
		}
	}
}