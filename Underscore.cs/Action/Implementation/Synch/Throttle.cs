using System;
using System.Threading.Tasks;

namespace Underscore.Action
{
	public class ThrottleComponent : IThrottleComponent
	{
        private Function.IThrottleComponent _fnThrottle;
        private IConvertComponent _actionConvert;

        public ThrottleComponent(Function.IThrottleComponent fnThrottle, IConvertComponent actionConvert)
        {
            _fnThrottle = fnThrottle;
            _actionConvert = actionConvert;
        }

		public Func<Task> Throttle(System.Action action, int milliseconds)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<Task> Throttle(System.Action action, int milliseconds, bool leading)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds, leading);
		}

		public Func<T, Task> Throttle<T>(Action<T> action, int milliseconds)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T, Task> Throttle<T>(Action<T> action, int milliseconds, bool leading)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds, leading);
		}

		public Func<T1, T2, Task> Throttle<T1, T2>(Action<T1, T2> action, int milliseconds)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, Task> Throttle<T1, T2>(Action<T1, T2> action, int milliseconds, bool leading)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds, leading);
		}

		public Func<T1, T2, T3, Task> Throttle<T1, T2, T3>(Action<T1, T2, T3> action, int milliseconds)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, Task> Throttle<T1, T2, T3>(Action<T1, T2, T3> action, int milliseconds, bool leading)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds, leading);
		}

		public Func<T1, T2, T3, T4, Task> Throttle<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, int milliseconds)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, Task> Throttle<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, int milliseconds, bool leading)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds, leading);
		}

		public Func<T1, T2, T3, T4, T5, Task> Throttle<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, int milliseconds)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, Task> Throttle<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, int milliseconds, bool leading)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds, leading);
		}

		public Func<T1, T2, T3, T4, T5, T6, Task> Throttle<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, int milliseconds)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, T6, Task> Throttle<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, int milliseconds, bool leading)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds, leading);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, Task> Throttle<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, int milliseconds)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, Task> Throttle<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, int milliseconds, bool leading)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds, leading);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, int milliseconds)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, int milliseconds, bool leading)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds, leading);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, int milliseconds)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, int milliseconds, bool leading)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds, leading);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, int milliseconds)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, int milliseconds, bool leading)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds, leading);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, int milliseconds)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, int milliseconds, bool leading)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds, leading);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, int milliseconds)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, int milliseconds, bool leading)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds, leading);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, int milliseconds)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, int milliseconds, bool leading)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds, leading);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, int milliseconds)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, int milliseconds, bool leading)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds, leading);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, int milliseconds)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, int milliseconds, bool leading)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds, leading);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, int milliseconds)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, int milliseconds, bool leading)
		{
			return _fnThrottle.Throttle(_actionConvert.ToFunction(action), milliseconds, leading);
		}
	}
}
