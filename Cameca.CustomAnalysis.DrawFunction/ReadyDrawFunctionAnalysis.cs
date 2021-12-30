using System.Collections.Generic;
using System.Windows.Media;
using Cameca.CustomAnalysis.Interface.CustomAnalysis;
using Cameca.CustomAnalysis.Interface.IonData;
using Cameca.CustomAnalysis.Interface.View;

namespace Cameca.CustomAnalysis.DrawFunction
{
	internal class ReadyDrawFunctionAnalysis : ICustomAnalysis<DrawFunctionAnalysisOptions>
	{
		public IIonData Run(IIonData ionData, IAnalysisTreeNode parentNode, DrawFunctionAnalysisOptions options, IViewBuilder viewBuilder)
		{
			var x = new List<float>();
			var y = new List<float>();
			IFunction code = new Function();
			for (float i = options.Start; i <= options.Stop; i += options.Step)
			{
				x.Add(i);
				y.Add(code.GetValue(i));
			}

			viewBuilder.AddChart2D("Function").AddLine(x.ToArray(), y.ToArray(), Colors.Red);
			return ionData;
		}
	}
}
