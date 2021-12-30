using Prism.Mvvm;

namespace Cameca.CustomAnalysis.DrawFunction
{
	public class DrawFunctionAnalysisOptions : BindableBase
	{
		private float start = 0;
		public float Start
		{
			get => start;
			set => SetProperty(ref start, value);
		}

		private float stop = 100;
		public float Stop
		{
			get => stop;
			set => SetProperty(ref stop, value);
		}

		private float step = 0.1f;
		public float Step
		{
			get => step;
			set => SetProperty(ref step, value);
		}
	}
}
