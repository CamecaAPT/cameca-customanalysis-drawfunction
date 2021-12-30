using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cameca.CustomAnalysis.DrawFunction.Properties;
using Cameca.CustomAnalysis.Interface.CustomAnalysis;
using Prism.Ioc;
using Prism.Modularity;

namespace Cameca.CustomAnalysis.DrawFunction
{
	[ModuleDependency("IvasModule")]
	public class DrawFunctionModule : IModule
	{
		public void RegisterTypes(IContainerRegistry containerRegistry)
		{
		}

		public void OnInitialized(IContainerProvider containerProvider)
		{
			var customAnalysisService = containerProvider.Resolve<ICustomAnalysisService>();

			customAnalysisService.Register<ReadyDrawFunctionAnalysis, DrawFunctionAnalysisOptions>(
				new CustomAnalysisDescription("DrawSqrtAnalysis", "Draw Sqrt", new Version()));
			customAnalysisService.Register<DrawFunctionAnalysis, DrawFunctionAnalysisOptions, IFunction>(
				new CustomAnalysisDescription("DrawFunctionAnalysis", "Draw Custom Function", new Version()), () => Resources.Function);


		}
	}
}
