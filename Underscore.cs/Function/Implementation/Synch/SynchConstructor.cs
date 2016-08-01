using System;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
namespace Underscore.Function
{
	public partial class SynchComponent: ISynchComponent
	{
		private readonly ICompactComponent _fnCompact;
		private readonly Utility.ICompactComponent _utilCompact;
		private readonly Utility.IMathComponent _math;
		
		public SynchComponent(ICompactComponent fnCompact , Utility.ICompactComponent utilCompact , Utility.IMathComponent mathComponent)
		{
			_fnCompact = fnCompact;
			_utilCompact = utilCompact;
			_math = mathComponent;
		}
	}
}
