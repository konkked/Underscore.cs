using System;
using System.Threading.Tasks;

namespace Underscore.Action
{
	public partial class SynchComponent : ISynchComponent
	{
		public Func<Task> Debounce(System.Action action, int milliseconds)
		{
			return _fnSynch.Debounce(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T, Task> Debounce<T>(Action<T> action, int milliseconds)
		{
			return _fnSynch.Debounce(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, Task> Debounce<T1, T2>(Action<T1, T2> action, int milliseconds)
		{
			return _fnSynch.Debounce(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, Task> Debounce<T1, T2, T3>(Action<T1, T2, T3> action, int milliseconds)
		{
			return _fnSynch.Debounce(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, Task> Debounce<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, int milliseconds)
		{
			return _fnSynch.Debounce(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, Task> Debounce<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, int milliseconds)
		{
			return _fnSynch.Debounce(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, T6, Task> Debounce<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, int milliseconds)
		{
			return _fnSynch.Debounce(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, Task> Debounce<T1, T2, T3, T4, T5, T6, T7>(System.Action<T1, T2, T3, T4, T5, T6, T7> action, int milliseconds)
		{
			return _fnSynch.Debounce(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, int milliseconds)
		{
			return _fnSynch.Debounce(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, int milliseconds)
		{
			return _fnSynch.Debounce(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, int milliseconds)
		{
			return _fnSynch.Debounce(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, int milliseconds)
		{
			return _fnSynch.Debounce(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, int milliseconds)
		{
			return _fnSynch.Debounce(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, int milliseconds)
		{
			return _fnSynch.Debounce(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, int milliseconds)
		{
			return _fnSynch.Debounce(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, int milliseconds)
		{
			return _fnSynch.Debounce(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, int milliseconds)
		{
			return _fnSynch.Debounce(_actionConvert.ToFunction(action), milliseconds);
		}
	}
}
