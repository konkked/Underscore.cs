using System;
using System.Threading.Tasks;

namespace Underscore.Action
{
    public class SynchComponent : ISynchComponent
    {
        private Function.ISynchComponent _fnSynch;
        private IConvertComponent _atnConvert;
        private Function.IConvertComponent _fnConvert;

        public SynchComponent(Function.ISynchComponent fnSynch, IConvertComponent actionConvert, Function.IConvertComponent fnConvert)
        {
            _fnSynch = fnSynch;
            _atnConvert = actionConvert;
            _fnConvert = fnConvert;
        }



        public Func<Task> Debounce( System.Action action, int milliseconds )
        {
            return _fnSynch.Debounce(_atnConvert.ToFunction(action), milliseconds);
        }


        public Func<T, Task> Debounce<T>( Action<T> action, int milliseconds )
        {
            return _fnSynch.Debounce(_atnConvert.ToFunction(action), milliseconds);
        }

        public Func<T1, T2, Task> Debounce<T1, T2>( Action<T1, T2> action, int milliseconds )
        {
            return _fnSynch.Debounce(_atnConvert.ToFunction(action), milliseconds);
        }


        public Func<T1, T2, T3, Task> Debounce<T1, T2, T3>( Action<T1, T2, T3> action, int milliseconds )
        {
            return _fnSynch.Debounce(_atnConvert.ToFunction(action), milliseconds);
        }


        public Func<T1, T2, T3, T4, Task> Debounce<T1, T2, T3, T4>( Action<T1, T2, T3, T4> action, int milliseconds )
        {
            return _fnSynch.Debounce(_atnConvert.ToFunction(action), milliseconds);
        }


        public Func<T1, T2, T3, T4, T5, Task> Debounce<T1, T2, T3, T4, T5>( Action<T1, T2, T3, T4, T5> action, int milliseconds )
        {
            return _fnSynch.Debounce(_atnConvert.ToFunction(action), milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, Task> Debounce<T1, T2, T3, T4, T5, T6>( Action<T1, T2, T3, T4, T5, T6> action, int milliseconds )
        {
            return _fnSynch.Debounce(_atnConvert.ToFunction(action), milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7,Task> Debounce<T1, T2, T3, T4, T5, T6,T7>(System.Action<T1, T2, T3, T4, T5, T6,T7> action, int milliseconds)
        {
            return _fnSynch.Debounce(_atnConvert.ToFunction(action), milliseconds);
        }


        public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, int milliseconds)
        {
            return _fnSynch.Debounce(_atnConvert.ToFunction(action), milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9,Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, int milliseconds)
        {
            return _fnSynch.Debounce(_atnConvert.ToFunction(action), milliseconds);
        }


        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9,T10, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9,T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9,T10> action, int milliseconds)
        {
            return _fnSynch.Debounce(_atnConvert.ToFunction(action), milliseconds);
        }


        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, int milliseconds)
        {
            return _fnSynch.Debounce(_atnConvert.ToFunction(action), milliseconds);
        }


        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, int milliseconds)
        {
            return _fnSynch.Debounce(_atnConvert.ToFunction(action), milliseconds);
        }


        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, int milliseconds)
        {
            return _fnSynch.Debounce(_atnConvert.ToFunction(action), milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, int milliseconds)
        {
            return _fnSynch.Debounce(_atnConvert.ToFunction(action), milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, int milliseconds)
        {
            return _fnSynch.Debounce(_atnConvert.ToFunction(action), milliseconds);
        }


        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,T16, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,T16> action, int milliseconds)
        {
            return _fnSynch.Debounce(_atnConvert.ToFunction(action), milliseconds);
        }


        public Func<Task> Throttle( System.Action action, int milliseconds )
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds);
        }

        public Func<Task> Throttle( System.Action action, int milliseconds, bool leading )
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds,leading);
        }

        public Func<T, Task> Throttle<T>( Action<T> action, int milliseconds )
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds);
        }

        public Func<T, Task> Throttle<T>( Action<T> action, int milliseconds, bool leading )
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds, leading);
        }

        public Func<T1, T2, Task> Throttle<T1, T2>( Action<T1, T2> action, int milliseconds )
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds);
        }

        public Func<T1, T2, Task> Throttle<T1, T2>( Action<T1, T2> action, int milliseconds, bool leading )
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds, leading);
        }

        public Func<T1, T2, T3, Task> Throttle<T1, T2, T3>( Action<T1, T2, T3> action, int milliseconds )
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds);
        }

        public Func<T1, T2, T3, Task> Throttle<T1, T2, T3>( Action<T1, T2, T3> action, int milliseconds, bool leading )
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds, leading);
        }

        public Func<T1, T2, T3, T4, Task> Throttle<T1, T2, T3, T4>( Action<T1, T2, T3, T4> action, int milliseconds )
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds);
        }

        public Func<T1, T2, T3, T4, Task> Throttle<T1, T2, T3, T4>( Action<T1, T2, T3, T4> action, int milliseconds, bool leading )
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds, leading);
        }

        public Func<T1, T2, T3, T4, T5, Task> Throttle<T1, T2, T3, T4, T5>( Action<T1, T2, T3, T4, T5> action, int milliseconds )
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, Task> Throttle<T1, T2, T3, T4, T5>( Action<T1, T2, T3, T4, T5> action, int milliseconds, bool leading )
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds, leading);
        }

        public Func<T1, T2, T3, T4, T5, T6, Task> Throttle<T1, T2, T3, T4, T5, T6>( Action<T1, T2, T3, T4, T5, T6> action, int milliseconds )
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, Task> Throttle<T1, T2, T3, T4, T5, T6>( Action<T1, T2, T3, T4, T5, T6> action, int milliseconds, bool leading )
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds, leading);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, Task> Throttle<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, int milliseconds)
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, Task> Throttle<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, int milliseconds, bool leading)
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds, leading);
        }


        public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, int milliseconds)
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, int milliseconds, bool leading)
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds, leading);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, int milliseconds)
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, int milliseconds, bool leading)
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds, leading);
        }


        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, int milliseconds)
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, int milliseconds, bool leading)
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds, leading);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, int milliseconds)
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, int milliseconds, bool leading)
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds, leading);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, int milliseconds)
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, int milliseconds, bool leading)
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds, leading);
        }



        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, int milliseconds)
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, int milliseconds, bool leading)
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds, leading);
        }


        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14,  Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, int milliseconds)
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14,  Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, int milliseconds, bool leading)
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds, leading);
        }


        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15 >(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, int milliseconds)
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15 > action, int milliseconds, bool leading)
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds, leading);
        }


        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, int milliseconds)
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, int milliseconds, bool leading)
        {
            return _fnSynch.Throttle(_atnConvert.ToFunction(action), milliseconds, leading);
        }

        public Func<Task> Delay( System.Action action, int milliseconds )
        {
            return _fnSynch.Delay(_atnConvert.ToFunction(action), milliseconds);
        }

        public Func<T, Task> Delay<T>( Action<T> action, int milliseconds )
        {
            return _fnSynch.Delay(_atnConvert.ToFunction(action), milliseconds);
        }

        public Func<T1, T2, Task> Delay<T1, T2>( Action<T1, T2> action, int milliseconds )
        {
            return _fnSynch.Delay(_atnConvert.ToFunction(action), milliseconds);
        }

        public Func<T1, T2, T3, Task> Delay<T1, T2, T3>( Action<T1, T2, T3> action, int milliseconds )
        {
            return _fnSynch.Delay(_atnConvert.ToFunction(action), milliseconds);
        }

        public Func<T1, T2, T3, T4, Task> Delay<T1, T2, T3, T4>( Action<T1, T2, T3, T4> action, int milliseconds )
        {
            return _fnSynch.Delay(_atnConvert.ToFunction(action), milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, Task> Delay<T1, T2, T3, T4, T5>( Action<T1, T2, T3, T4, T5> action, int milliseconds )
        {
            return _fnSynch.Delay(_atnConvert.ToFunction(action), milliseconds);
        }



        public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, int milliseconds)
        {
            return _fnSynch.Delay(_atnConvert.ToFunction(action), milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, int milliseconds)
        {
            return _fnSynch.Delay(_atnConvert.ToFunction(action), milliseconds);
        }





        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, int milliseconds)
        {
            return _fnSynch.Delay(_atnConvert.ToFunction(action), milliseconds);
        }



        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, int milliseconds)
        {
            return _fnSynch.Delay(_atnConvert.ToFunction(action), milliseconds);
        }



        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, int milliseconds)
        {
            return _fnSynch.Delay(_atnConvert.ToFunction(action), milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, int milliseconds)
        {
            return _fnSynch.Delay(_atnConvert.ToFunction(action), milliseconds);
        }


        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, int milliseconds)
        {
            return _fnSynch.Delay(_atnConvert.ToFunction(action), milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, int milliseconds)
        {
            return _fnSynch.Delay(_atnConvert.ToFunction(action), milliseconds);
        }


        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, int milliseconds)
        {
            return _fnSynch.Delay(_atnConvert.ToFunction(action), milliseconds);
        }


        public Func<T1, T2, T3, T4, T5, T6, T7,Task> Delay<T1, T2, T3, T4, T5, T6,T7>(Action<T1, T2, T3, T4, T5, T6,T7> action, int milliseconds)
        {
            return _fnSynch.Delay(_atnConvert.ToFunction(action), milliseconds);
        }


        public Func<T1, T2, T3, T4, T5, T6, Task> Delay<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, int milliseconds)
        {
            return _fnSynch.Delay(_atnConvert.ToFunction(action), milliseconds);
        }

        public System.Action Once( System.Action action )
        {
            return _fnConvert.ToAction( _fnSynch.Once(_atnConvert.ToFunction(action)));
        }

        public Action<T> Once<T>( Action<T> action )
        {
            return _fnConvert.ToAction(_fnSynch.Once(_atnConvert.ToFunction(action)));
        }

        public Action<T1, T2> Once<T1, T2>( Action<T1, T2> action )
        {
            return _fnConvert.ToAction(_fnSynch.Once(_atnConvert.ToFunction(action)));
        }

        public Action<T1, T2, T3> Once<T1, T2, T3>( Action<T1, T2, T3> action )
        {
            return _fnConvert.ToAction(_fnSynch.Once(_atnConvert.ToFunction(action)));
        }

        public Action<T1, T2, T3, T4> Once<T1, T2, T3, T4>( Action<T1, T2, T3, T4> action )
        {
            return _fnConvert.ToAction(_fnSynch.Once(_atnConvert.ToFunction(action)));
        }

        public Action<T1, T2, T3, T4, T5> Once<T1, T2, T3, T4, T5>( Action<T1, T2, T3, T4, T5> action )
        {
            return _fnConvert.ToAction(_fnSynch.Once(_atnConvert.ToFunction(action)));
        }

        public Action<T1, T2, T3, T4, T5, T6> Once<T1, T2, T3, T4, T5, T6>( Action<T1, T2, T3, T4, T5, T6> action )
        {
            return _fnConvert.ToAction(_fnSynch.Once(_atnConvert.ToFunction(action)));
        }

        public Action<T1, T2, T3, T4, T5, T6, T7> Once<T1, T2, T3, T4, T5, T6, T7>( Action<T1, T2, T3, T4, T5, T6, T7> action )
        {
            return _fnConvert.ToAction(_fnSynch.Once(_atnConvert.ToFunction(action)));
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8> Once<T1, T2, T3, T4, T5, T6, T7, T8>( Action<T1, T2, T3, T4, T5, T6, T7, T8> action )
        {
            return _fnConvert.ToAction(_fnSynch.Once(_atnConvert.ToFunction(action)));
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9>( Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action )
        {
            return _fnConvert.ToAction(_fnSynch.Once(_atnConvert.ToFunction(action)));
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>( Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action )
        {
            return _fnConvert.ToAction(_fnSynch.Once(_atnConvert.ToFunction(action)));
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>( Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action )
        {
            return _fnConvert.ToAction(_fnSynch.Once(_atnConvert.ToFunction(action)));
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>( Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action )
        {
            return _fnConvert.ToAction(_fnSynch.Once(_atnConvert.ToFunction(action)));
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>( Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action )
        {
            return _fnConvert.ToAction(_fnSynch.Once(_atnConvert.ToFunction(action)));
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>( Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action )
        {
            return _fnConvert.ToAction(_fnSynch.Once(_atnConvert.ToFunction(action)));
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>( Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action )
        {
            return _fnConvert.ToAction(_fnSynch.Once(_atnConvert.ToFunction(action)));
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>( Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action )
        {
            return _fnConvert.ToAction(_fnSynch.Once(_atnConvert.ToFunction(action)));
        }

        public Func<Task> After(  System.Action action , int count )
        {
            return _fnSynch.After(_atnConvert.ToFunction(action), count);
        }

        public Func<T, Task> After<T>(  Action<T> action , int count )
        {
            return _fnSynch.After(_atnConvert.ToFunction(action),count);
        }

        public Func<T1, T2, Task> After<T1, T2>(  Action<T1, T2> action , int count )
        {
            return _fnSynch.After(_atnConvert.ToFunction(action),count);
        }

        public Func<T1, T2, T3, Task> After<T1, T2, T3>(  Action<T1, T2, T3> action , int count )
        {
            return _fnSynch.After(_atnConvert.ToFunction(action),count);
        }

        public Func<T1, T2, T3, T4, Task> After<T1, T2, T3, T4>(  Action<T1, T2, T3, T4> action , int count )
        {
            return _fnSynch.After(_atnConvert.ToFunction(action),count);
        }

        public Func<T1, T2, T3, T4, T5, Task> After<T1, T2, T3, T4, T5>(  Action<T1, T2, T3, T4, T5> action , int count )
        {
            return _fnSynch.After(_atnConvert.ToFunction(action),count);
        }

        public Func<T1, T2, T3, T4, T5, T6, Task> After<T1, T2, T3, T4, T5, T6>(  Action<T1, T2, T3, T4, T5, T6> action , int count )
        {
            return _fnSynch.After(_atnConvert.ToFunction(action),count);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, Task> After<T1, T2, T3, T4, T5, T6, T7>(  Action<T1, T2, T3, T4, T5, T6, T7> action , int count )
        {
            return _fnSynch.After(_atnConvert.ToFunction(action),count);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> After<T1, T2, T3, T4, T5, T6, T7, T8>(  Action<T1, T2, T3, T4, T5, T6, T7, T8> action , int count )
        {
            return _fnSynch.After(_atnConvert.ToFunction(action),count);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9>(  Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action , int count )
        {
            return _fnSynch.After(_atnConvert.ToFunction(action),count);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(  Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action , int count )
        {
            return _fnSynch.After(_atnConvert.ToFunction(action),count);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(  Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action , int count )
        {
            return _fnSynch.After(_atnConvert.ToFunction(action),count);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(  Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action , int count )
        {
            return _fnSynch.After(_atnConvert.ToFunction(action),count);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(  Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action , int count )
        {
            return _fnSynch.After(_atnConvert.ToFunction(action),count);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(  Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action , int count )
        {
            return _fnSynch.After(_atnConvert.ToFunction(action),count);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(  Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action , int count )
        {
            return _fnSynch.After(_atnConvert.ToFunction(action),count);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(  Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action , int count )
        {
            return _fnSynch.After(_atnConvert.ToFunction(action),count);
        }

        public System.Action Before(  System.Action action , int count )
        {
            return _fnConvert.ToAction(_fnSynch.Before(_atnConvert.ToFunction(action),count));
        }

        public Action<T> Before<T>(  Action<T> action , int count )
        {
            return _fnConvert.ToAction(_fnSynch.Before(_atnConvert.ToFunction(action),count));
        }

        public Action<T1, T2> Before<T1, T2>(  Action<T1, T2> action , int count )
        {
            return _fnConvert.ToAction(_fnSynch.Before(_atnConvert.ToFunction(action),count));
        }

        public Action<T1, T2, T3> Before<T1, T2, T3>(  Action<T1, T2, T3> action , int count )
        {
            return _fnConvert.ToAction(_fnSynch.Before(_atnConvert.ToFunction(action),count));
        }

        public Action<T1, T2, T3, T4> Before<T1, T2, T3, T4>(  Action<T1, T2, T3, T4> action , int count )
        {
            return _fnConvert.ToAction(_fnSynch.Before(_atnConvert.ToFunction(action),count));
        }

        public Action<T1, T2, T3, T4, T5> Before<T1, T2, T3, T4, T5>(  Action<T1, T2, T3, T4, T5> action , int count )
        {
            return _fnConvert.ToAction(_fnSynch.Before(_atnConvert.ToFunction(action),count));
        }

        public Action<T1, T2, T3, T4, T5, T6> Before<T1, T2, T3, T4, T5, T6>(  Action<T1, T2, T3, T4, T5, T6> action , int count )
        {
            return _fnConvert.ToAction(_fnSynch.Before(_atnConvert.ToFunction(action),count));
        }

        public Action<T1, T2, T3, T4, T5, T6, T7> Before<T1, T2, T3, T4, T5, T6, T7>(  Action<T1, T2, T3, T4, T5, T6, T7> action , int count )
        {
            return _fnConvert.ToAction(_fnSynch.Before(_atnConvert.ToFunction(action),count));
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8> Before<T1, T2, T3, T4, T5, T6, T7, T8>(  Action<T1, T2, T3, T4, T5, T6, T7, T8> action , int count )
        {
            return _fnConvert.ToAction(_fnSynch.Before(_atnConvert.ToFunction(action),count));
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9>(  Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action , int count )
        {
            return _fnConvert.ToAction(_fnSynch.Before(_atnConvert.ToFunction(action),count));
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(  Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action , int count )
        {
            return _fnConvert.ToAction(_fnSynch.Before(_atnConvert.ToFunction(action),count));
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(  Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action , int count )
        {
            return _fnConvert.ToAction(_fnSynch.Before(_atnConvert.ToFunction(action),count));
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(  Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action , int count )
        {
            return _fnConvert.ToAction(_fnSynch.Before(_atnConvert.ToFunction(action),count));
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(  Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action , int count )
        {
            return _fnConvert.ToAction(_fnSynch.Before(_atnConvert.ToFunction(action),count));
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(  Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action , int count )
        {
            return _fnConvert.ToAction(_fnSynch.Before(_atnConvert.ToFunction(action),count));
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(  Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action , int count )
        {
            return _fnConvert.ToAction(_fnSynch.Before(_atnConvert.ToFunction(action),count));
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(  Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action , int count )
        {
            return _fnConvert.ToAction(_fnSynch.Before(_atnConvert.ToFunction(action),count));
        }
    }

}
