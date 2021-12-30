using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Cameca.CustomAnalysis.Interface.CustomAnalysis;
using Cameca.CustomAnalysis.Interface.IonData;
using Cameca.CustomAnalysis.Interface.View;

namespace Cameca.CustomAnalysis.DrawFunction
{
	internal class DrawFunctionAnalysis : ICustomAnalysisWithCode<DrawFunctionAnalysisOptions, IFunction>
	{
		public IIonData Run(IIonData ionData, IAnalysisTreeNode parentNode, DrawFunctionAnalysisOptions options, IViewBuilder viewBuilder, IFunction code)
		{

			var x = new List<float>();
			var y = new List<float>();
			for (float i = options.Start; i <= options.Stop; i += options.Step)
			{
				x.Add(i);
				y.Add(code.GetValue(i));
			}

			IChart2D chart2D = viewBuilder.AddChart2D(code.Title);
			chart2D.AddLine(x.ToArray(), y.ToArray(), Colors.Red);
			chart2D.AddHistogram(x.ToArray(), y.ToArray(), Colors.Blue);

			return ionData;
		}
	}
}
