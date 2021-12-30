using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cameca.CustomAnalysis.DrawFunction
{
	public interface IFunction
	{
		string Title { get; }
		float GetValue(float x);
	}
}
