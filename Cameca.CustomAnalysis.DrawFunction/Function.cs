using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cameca.CustomAnalysis.DrawFunction
{
	internal class Function : IFunction
	{
		public string Title => "Sqrt";

		public float GetValue(float x) => (float)Math.Sqrt(x);
	}
}
