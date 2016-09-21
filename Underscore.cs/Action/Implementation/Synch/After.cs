using System;
using System.Threading.Tasks;

namespace Underscore.Action
{
	public class AfterComponent : IAfterComponent
	{
        private Function.IAfterComponent _fnAfter;
        private IConvertComponent _actionConvert;

        public AfterComponent(Function.IAfterComponent fnAfter, IConvertComponent actionConvert)
        {
            _fnAfter = fnAfter;
            _actionConvert = actionConvert;
        }

		public Func<Task> After(System.Action action, int count)
		{
			return _fnAfter.After(_actionConvert.ToFunction(action), count);
		}

		public Func<T, Task> After<T>(Action<T> action, int count)
		{
			return _fnAfter.After(_actionConvert.ToFunction(action), count);
		}

		public Func<T1, T2, Task> After<T1, T2>(Action<T1, T2> action, int count)
		{
			return _fnAfter.After(_actionConvert.ToFunction(action), count);
		}

		public Func<T1, T2, T3, Task> After<T1, T2, T3>(Action<T1, T2, T3> action, int count)
		{
			return _fnAfter.After(_actionConvert.ToFunction(action), count);
		}

		public Func<T1, T2, T3, T4, Task> After<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, int count)
		{
			return _fnAfter.After(_actionConvert.ToFunction(action), count);
		}

		public Func<T1, T2, T3, T4, T5, Task> After<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, int count)
		{
			return _fnAfter.After(_actionConvert.ToFunction(action), count);
		}

		public Func<T1, T2, T3, T4, T5, T6, Task> After<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, int count)
		{
			return _fnAfter.After(_actionConvert.ToFunction(action), count);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, Task> After<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, int count)
		{
			return _fnAfter.After(_actionConvert.ToFunction(action), count);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> After<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, int count)
		{
			return _fnAfter.After(_actionConvert.ToFunction(action), count);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, int count)
		{
			return _fnAfter.After(_actionConvert.ToFunction(action), count);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, int count)
		{
			return _fnAfter.After(_actionConvert.ToFunction(action), count);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, int count)
		{
			return _fnAfter.After(_actionConvert.ToFunction(action), count);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, int count)
		{
			return _fnAfter.After(_actionConvert.ToFunction(action), count);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, int count)
		{
			return _fnAfter.After(_actionConvert.ToFunction(action), count);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, int count)
		{
			return _fnAfter.After(_actionConvert.ToFunction(action), count);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, int count)
		{
			return _fnAfter.After(_actionConvert.ToFunction(action), count);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, int count)
		{
			return _fnAfter.After(_actionConvert.ToFunction(action), count);
		}
	}
}
