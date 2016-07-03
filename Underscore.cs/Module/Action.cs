using System;
using System.Threading.Tasks;
using Underscore.Action;

namespace Underscore.Module
{
    public class Action :
        IBindComponent,
        ISplitComponent,
        IComposeComponent,
        ISynchComponent,
        IConvertComponent
    {

        private readonly IBindComponent _bind;
        private readonly ISplitComponent _split;
        private readonly IComposeComponent _compose;
        private readonly ISynchComponent _synch;
        private readonly IConvertComponent _convert;

        public Action(
            IBindComponent bind,
            ISplitComponent split,
            IComposeComponent compose,
            ISynchComponent synch,
            IConvertComponent convert
            )
        {
            if(bind == null)
                throw new ArgumentNullException("bind");

            if (split == null)
                throw new ArgumentNullException("split");

            if (compose == null)
                throw new ArgumentNullException("compose");

            if (synch == null)
                throw new ArgumentNullException("synch");

            if (convert == null)
                throw new ArgumentNullException("convert");

            _bind = bind;
            _split = split;
            _compose = compose;
            _synch = synch;
            _convert = convert;
        }

        /// <summary>
        /// Halves the passed action
        /// </summary>
        public Func<T0, T1, T2, T3, T4, T5, T6, T7, Action<T8, T9, T10, T11, T12, T13, T14, T15>> Split
            <T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action)
        {
            return _split.Split(action);
        }

        /// <summary>
        /// Halves the passed action
        /// </summary>
        public Func<T0, T1, T2, T3, T4, T5, T6, Action<T7, T8, T9, T10, T11, T12, T13>> Split<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action)
        {
            return _split.Split(action);
        }

        /// <summary>
        /// Halves the passed action
        /// </summary>
        public Func<T0, T1, T2, T3, T4, T5, Action<T6, T7, T8, T9, T10, T11>> Split<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action)
        {
            return _split.Split(action);
        }

        /// <summary>
        /// Halves the passed action
        /// </summary>
        public Func<T0, T1, T2, T3, T4, Action<T5, T6, T7, T8, T9>> Split<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> action)
        {
            return _split.Split(action);
        }

        /// <summary>
        /// Halves the passed action
        /// </summary>
        public Func<T0, T1, T2, T3, Action<T4, T5, T6, T7>> Split<T0, T1, T2, T3, T4, T5, T6, T7>(
            Action<T0, T1, T2, T3, T4, T5, T6, T7> action)
        {
            return _split.Split(action);
        }

        /// <summary>
        /// Halves the passed action
        /// </summary>
        public Func<T0, T1, T2, Action<T3, T4, T5>> Split<T0, T1, T2, T3, T4, T5>(Action<T0, T1, T2, T3, T4, T5> action)
        {
            return _split.Split(action);
        }

        /// <summary>
        /// Halves the passed action
        /// </summary>
        public Func<T0, T1, Action<T2, T3>> Split<T0, T1, T2, T3>(Action<T0, T1, T2, T3> action)
        {
            return _split.Split(action);
        }

        /// <summary>
        /// Halves the passed action
        /// </summary>
        public Func<T0, Action<T1>> Split<T0, T1>(Action<T0, T1> action)
        {
            return _split.Split(action);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public System.Action After(System.Action function, int count)
        {
            var ncount = count;
            return () => { if (ncount-- == 0) function(); };
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, Task> After<T1>(Action<T1> action, int count)
        {
            return _synch.After(action, count);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, Task> After<T1, T2>(Action<T1, T2> action, int count)
        {
            return _synch.After(action, count);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, Task> After<T1, T2, T3>(Action<T1, T2, T3> action, int count)
        {
            return _synch.After(action, count);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, Task> After<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, int count)
        {
            return _synch.After(action, count);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, Task> After<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, int count)
        {
            return _synch.After(action, count);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, Task> After<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, int count)
        {
            return _synch.After(action, count);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, Task> After<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, int count)
        {
            return _synch.After(action, count);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> After<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, int count)
        {
            return _synch.After(action, count);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, int count)
        {
            return _synch.After(action, count);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, int count)
        {
            return _synch.After(action, count);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, int count)
        {
            return _synch.After(action, count);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, int count)
        {
            return _synch.After(action, count);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, int count)
        {
            return _synch.After(action, count);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, int count)
        {
            return _synch.After(action, count);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, int count)
        {
            return _synch.After(action, count);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, int count)
        {
            return _synch.After(action, count);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        Func<Task> ISynchComponent.After(System.Action action, int count)
        {
            return _synch.After(action, count);
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public System.Action Before(System.Action function, int count)
        {
            var ncount = count;
            return () => { if (ncount-- >= 0) function(); };
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Action<T1> Before<T1>(Action<T1> action, int count)
        {
            return _synch.Before(action, count);
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Action<T1, T2> Before<T1, T2>(Action<T1, T2> action, int count)
        {
            return _synch.Before(action, count);
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Action<T1, T2, T3> Before<T1, T2, T3>(Action<T1, T2, T3> action, int count)
        {
            return _synch.Before(action, count);
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Action<T1, T2, T3, T4> Before<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, int count)
        {
            return _synch.Before(action, count);
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Action<T1, T2, T3, T4, T5> Before<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, int count)
        {
            return _synch.Before(action, count);
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Action<T1, T2, T3, T4, T5, T6> Before<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, int count)
        {
            return _synch.Before(action, count);
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Action<T1, T2, T3, T4, T5, T6, T7> Before<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, int count)
        {
            return _synch.Before(action, count);
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Action<T1, T2, T3, T4, T5, T6, T7, T8> Before<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, int count)
        {
            return _synch.Before(action, count);
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, int count)
        {
            return _synch.Before(action, count);
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, int count)
        {
            return _synch.Before(action, count);
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, int count)
        {
            return _synch.Before(action, count);
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, int count)
        {
            return _synch.Before(action, count);
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, int count)
        {
            return _synch.Before(action, count);
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, int count)
        {
            return _synch.Before(action, count);
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, int count)
        {
            return _synch.Before(action, count);
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, int count)
        {
            return _synch.Before(action, count);
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<Task> Debounce(System.Action action, int milliseconds)
        {
            return _synch.Debounce(action, milliseconds);
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T, Task> Debounce<T>(Action<T> action, int milliseconds)
        {
            return _synch.Debounce(action, milliseconds);
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, Task> Debounce<T1, T2>(Action<T1, T2> action, int milliseconds)
        {
            return _synch.Debounce(action, milliseconds);
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, T3, Task> Debounce<T1, T2, T3>(Action<T1, T2, T3> action, int milliseconds)
        {
            return _synch.Debounce(action, milliseconds);
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, Task> Debounce<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, int milliseconds)
        {
            return _synch.Debounce(action, milliseconds);
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, Task> Debounce<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action,
            int milliseconds)
        {
            return _synch.Debounce(action, milliseconds);
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, Task> Debounce<T1, T2, T3, T4, T5, T6>(
            Action<T1, T2, T3, T4, T5, T6> action, int milliseconds)
        {
            return _synch.Debounce(action, milliseconds);
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, Task> Debounce<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, int milliseconds)
        {
            return _synch.Debounce(action, milliseconds);
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, int milliseconds)
        {
            return _synch.Debounce(action, milliseconds);
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, int milliseconds)
        {
            return _synch.Debounce(action, milliseconds);
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, int milliseconds)
        {
            return _synch.Debounce(action, milliseconds);
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, int milliseconds)
        {
            return _synch.Debounce(action, milliseconds);
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, int milliseconds)
        {
            return _synch.Debounce(action, milliseconds);
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, int milliseconds)
        {
            return _synch.Debounce(action, milliseconds);
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, int milliseconds)
        {
            return _synch.Debounce(action, milliseconds);
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, int milliseconds)
        {
            return _synch.Debounce(action, milliseconds);
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, int milliseconds)
        {
            return _synch.Debounce(action, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<Task> Throttle(System.Action action, int milliseconds)
        {
            return _synch.Throttle(action, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<Task> Throttle(System.Action action, int milliseconds, bool leading)
        {
            return _synch.Throttle(action, milliseconds, leading);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T, Task> Throttle<T>(Action<T> action, int milliseconds)
        {
            return _synch.Throttle(action, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T, Task> Throttle<T>(Action<T> action, int milliseconds, bool leading)
        {
            return _synch.Throttle(action, milliseconds, leading);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, Task> Throttle<T1, T2>(Action<T1, T2> action, int milliseconds)
        {
            return _synch.Throttle(action, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, Task> Throttle<T1, T2>(Action<T1, T2> action, int milliseconds, bool leading)
        {
            return _synch.Throttle(action, milliseconds, leading);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, Task> Throttle<T1, T2, T3>(Action<T1, T2, T3> action, int milliseconds)
        {
            return _synch.Throttle(action, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, Task> Throttle<T1, T2, T3>(Action<T1, T2, T3> action, int milliseconds, bool leading)
        {
            return _synch.Throttle(action, milliseconds, leading);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, Task> Throttle<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, int milliseconds)
        {
            return _synch.Throttle(action, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, Task> Throttle<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, int milliseconds,
            bool leading)
        {
            return _synch.Throttle(action, milliseconds, leading);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, Task> Throttle<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action,
            int milliseconds)
        {
            return _synch.Throttle(action, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, Task> Throttle<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action,
            int milliseconds, bool leading)
        {
            return _synch.Throttle(action, milliseconds, leading);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, Task> Throttle<T1, T2, T3, T4, T5, T6>(
            Action<T1, T2, T3, T4, T5, T6> action, int milliseconds)
        {
            return _synch.Throttle(action, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, Task> Throttle<T1, T2, T3, T4, T5, T6>(
            Action<T1, T2, T3, T4, T5, T6> action, int milliseconds, bool leading)
        {
            return _synch.Throttle(action, milliseconds, leading);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, Task> Throttle<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, int milliseconds)
        {
            return _synch.Throttle(action, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, Task> Throttle<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, int milliseconds, bool leading)
        {
            return _synch.Throttle(action, milliseconds, leading);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, int milliseconds)
        {
            return _synch.Throttle(action, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, int milliseconds, bool leading)
        {
            return _synch.Throttle(action, milliseconds, leading);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, int milliseconds)
        {
            return _synch.Throttle(action, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, int milliseconds, bool leading)
        {
            return _synch.Throttle(action, milliseconds, leading);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, int milliseconds)
        {
            return _synch.Throttle(action, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, int milliseconds, bool leading)
        {
            return _synch.Throttle(action, milliseconds, leading);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, int milliseconds)
        {
            return _synch.Throttle(action, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, int milliseconds, bool leading)
        {
            return _synch.Throttle(action, milliseconds, leading);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, int milliseconds)
        {
            return _synch.Throttle(action, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, int milliseconds, bool leading)
        {
            return _synch.Throttle(action, milliseconds, leading);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, int milliseconds)
        {
            return _synch.Throttle(action, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, int milliseconds, bool leading)
        {
            return _synch.Throttle(action, milliseconds, leading);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, int milliseconds)
        {
            return _synch.Throttle(action, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, int milliseconds, bool leading)
        {
            return _synch.Throttle(action, milliseconds, leading);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, int milliseconds)
        {
            return _synch.Throttle(action, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, int milliseconds,
            bool leading)
        {
            return _synch.Throttle(action, milliseconds, leading);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, int milliseconds)
        {
            return _synch.Throttle(action, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, int milliseconds,
            bool leading)
        {
            return _synch.Throttle(action, milliseconds, leading);
        }

        /// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
        public Func<Task> Delay(System.Action action, int milliseconds)
        {
            return _synch.Delay(action, milliseconds);
        }

        /// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
        public Func<T, Task> Delay<T>(Action<T> action, int milliseconds)
        {
            return _synch.Delay(action, milliseconds);
        }

        /// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
        public Func<T1, T2, Task> Delay<T1, T2>(Action<T1, T2> action, int milliseconds)
        {
            return _synch.Delay(action, milliseconds);
        }

        /// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
        public Func<T1, T2, T3, Task> Delay<T1, T2, T3>(Action<T1, T2, T3> action, int milliseconds)
        {
            return _synch.Delay(action, milliseconds);
        }

        /// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
        public Func<T1, T2, T3, T4, Task> Delay<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, int milliseconds)
        {
            return _synch.Delay(action, milliseconds);
        }

        /// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
        public Func<T1, T2, T3, T4, T5, Task> Delay<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action,
            int milliseconds)
        {
            return _synch.Delay(action, milliseconds);
        }

        /// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, Task> Delay<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action,
            int milliseconds)
        {
            return _synch.Delay(action, milliseconds);
        }

        /// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, Task> Delay<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, int milliseconds)
        {
            return _synch.Delay(action, milliseconds);
        }

        /// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, int milliseconds)
        {
            return _synch.Delay(action, milliseconds);
        }

        /// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, int milliseconds)
        {
            return _synch.Delay(action, milliseconds);
        }

        /// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, int milliseconds)
        {
            return _synch.Delay(action, milliseconds);
        }

        /// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, int milliseconds)
        {
            return _synch.Delay(action, milliseconds);
        }

        /// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, int milliseconds)
        {
            return _synch.Delay(action, milliseconds);
        }

        /// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, int milliseconds)
        {
            return _synch.Delay(action, milliseconds);
        }

        /// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, int milliseconds)
        {
            return _synch.Delay(action, milliseconds);
        }

        /// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, int milliseconds)
        {
            return _synch.Delay(action, milliseconds);
        }

        /// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, int milliseconds)
        {
            return _synch.Delay(action, milliseconds);
        }

        /// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
        public System.Action Once(System.Action action)
        {
            var hasRan = false;
            return () =>
            {
                if (!hasRan)
                {
                    hasRan = true;
                    action();
                }
            };
        }

        /// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
        public Action<T> Once<T>(Action<T> action)
        {
            return _synch.Once(action);
        }

        /// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
        public Action<T1, T2> Once<T1, T2>(Action<T1, T2> action)
        {
            return _synch.Once(action);
        }

        /// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
        public Action<T1, T2, T3> Once<T1, T2, T3>(Action<T1, T2, T3> action)
        {
            return _synch.Once(action);
        }

        /// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
        public Action<T1, T2, T3, T4> Once<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action)
        {
            return _synch.Once(action);
        }

        /// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
        public Action<T1, T2, T3, T4, T5> Once<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action)
        {
            return _synch.Once(action);
        }

        /// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
        public Action<T1, T2, T3, T4, T5, T6> Once<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action)
        {
            return _synch.Once(action);
        }

        /// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
        public Action<T1, T2, T3, T4, T5, T6, T7> Once<T1, T2, T3, T4, T5, T6, T7>(
            Action<T1, T2, T3, T4, T5, T6, T7> action)
        {
            return _synch.Once(action);
        }

        /// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
        public Action<T1, T2, T3, T4, T5, T6, T7, T8> Once<T1, T2, T3, T4, T5, T6, T7, T8>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8> action)
        {
            return _synch.Once(action);
        }

        /// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action)
        {
            return _synch.Once(action);
        }

        /// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action)
        {
            return _synch.Once(action);
        }

        /// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action)
        {
            return _synch.Once(action);
        }

        /// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Once
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action)
        {
            return _synch.Once(action);
        }

        /// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Once
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action)
        {
            return _synch.Once(action);
        }

        /// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Once
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action)
        {
            return _synch.Once(action);
        }

        /// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Once
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action)
        {
            return _synch.Once(action);
        }

        /// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Once
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action)
        {
            return _synch.Once(action);
        }

        /// <summary>
        /// Creates a composition of actions, executed in order all sharing the same parameter
        /// </summary>
        public Action<TStart> Compose
            <TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TLink12,
                TLink13,
                TLink14, TLink15, TEnd>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b,
                    Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f,
                    Func<TLink7, TLink8> g, Func<TLink8, TLink9> h, Func<TLink9, TLink10> i,
                    Func<TLink10, TLink11> j, Func<TLink11, TLink12> k, Func<TLink12, TLink13> l,
                    Func<TLink13, TLink14> m, Func<TLink14, TLink15> n, Func<TLink15, TEnd> o, Action<TEnd> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, end);
        }

        /// <summary>
        /// Creates a composition of actions, executed in order all sharing the same parameter
        /// </summary>
        public Action<T> Compose<T>(params Action<T>[] actions)
        {
            return _compose.Compose(actions);
        }

        /// <summary>
        /// Calls the function passed with the given arguments as the parameters 
        /// </summary>
        public void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T, T, T, T, T, T, T> action, T[] arguments)
        {
            _compose.Apply(action, arguments);
        }

        /// <summary>
        /// Creates a sigle composite action from the passed functions
        /// </summary>
        public Action<TStart> Compose<TStart, TEnd>(Func<TStart, TEnd> start, Action<TEnd> end)
        {
            return _compose.Compose(start, end);
        }

        /// <summary>
        /// Creates a sigle composite action from the passed functions
        /// </summary>
        public Action<TStart> Compose<TStart, TMid, TEnd>(Func<TStart, TMid> start, Func<TMid, TEnd> mid,
            Action<TEnd> end)
        {
            return _compose.Compose(start, mid, end);
        }

        /// <summary>
        /// Creates a sigle composite action from the passed functions
        /// </summary>
        public Action<TStart> Compose<TStart, TLink1, TLink2, TEnd>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a,
            Func<TLink2, TEnd> b, Action<TEnd> end)
        {
            return _compose.Compose(start, a, b, end);
        }

        /// <summary>
        /// Creates a sigle composite action from the passed functions
        /// </summary>
        public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TEnd>(Func<TStart, TLink1> start,
            Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TEnd> c, Action<TEnd> end)
        {
            return _compose.Compose(start, a, b, c, end);
        }

        /// <summary>
        /// Creates a sigle composite action from the passed functions
        /// </summary>
        public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TEnd>(Func<TStart, TLink1> start,
            Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TEnd> d,
            Action<TEnd> end)
        {
            return _compose.Compose(start, a, b, c, d, end);
        }

        /// <summary>
        /// Creates a sigle composite action from the passed functions
        /// </summary>
        public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TEnd>(Func<TStart, TLink1> start,
            Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d,
            Func<TLink5, TEnd> e,
            Action<TEnd> end)
        {
            return _compose.Compose(start, a, b, c, d, e, end);
        }

        /// <summary>
        /// Creates a sigle composite action from the passed functions
        /// </summary>
        public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TEnd>(
            Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c,
            Func<TLink4, TLink5> d,
            Func<TLink5, TLink6> e, Func<TLink6, TEnd> f, Action<TEnd> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, end);
        }

        /// <summary>
        /// Creates a sigle composite action from the passed functions
        /// </summary>
        public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TEnd>(
            Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c,
            Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TEnd> g,
            Action<TEnd> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, g, end);
        }

        /// <summary>
        /// Creates a sigle composite action from the passed functions
        /// </summary>
        public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TEnd>(
            Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b,
            Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f,
            Func<TLink7, TLink8> g, Func<TLink8, TEnd> h, Action<TEnd> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, g, h, end);
        }

        /// <summary>
        /// Creates a sigle composite action from the passed functions
        /// </summary>
        public Action<TStart> Compose
            <TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TEnd>(
            Func<TStart, TLink1> start, Func<TLink1, TLink2> a,
            Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e,
            Func<TLink6, TLink7> f, Func<TLink7, TLink8> g, Func<TLink8, TLink9> h, Func<TLink9, TEnd> i,
            Action<TEnd> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, g, h, i, end);
        }

        /// <summary>
        /// Creates a sigle composite action from the passed functions
        /// </summary>
        public Action<TStart> Compose
            <TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TEnd>(
            Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c,
            Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TLink8> g,
            Func<TLink8, TLink9> h, Func<TLink9, TLink10> i, Func<TLink10, TEnd> j, Action<TEnd> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, g, h, i, j, end);
        }

        /// <summary>
        /// Creates a sigle composite action from the passed functions
        /// </summary>
        public Action<TStart> Compose
            <TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TEnd>(
            Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c,
            Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TLink8> g,
            Func<TLink8, TLink9> h, Func<TLink9, TLink10> i, Func<TLink10, TLink11> j, Func<TLink11, TEnd> k,
            Action<TEnd> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, g, h, i, j, k, end);
        }

        /// <summary>
        /// Creates a sigle composite action from the passed functions
        /// </summary>
        public Action<TStart> Compose
            <TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TLink12,
                TEnd>(
            Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c,
            Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TLink8> g,
            Func<TLink8, TLink9> h, Func<TLink9, TLink10> i, Func<TLink10, TLink11> j, Func<TLink11, TLink12> k,
            Func<TLink12, TEnd> l,
            Action<TEnd> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, g, h, i, j, k, l, end);
        }

        /// <summary>
        /// Creates a sigle composite action from the passed functions
        /// </summary>
        public Action<TStart> Compose
            <TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TLink12,
                TLink13,
                TEnd>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c,
                    Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TLink8> g,
                    Func<TLink8, TLink9> h, Func<TLink9, TLink10> i, Func<TLink10, TLink11> j, Func<TLink11, TLink12> k,
                    Func<TLink12, TLink13> l,
                    Func<TLink13, TEnd> m, Action<TEnd> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, g, h, i, j, k, l, m, end);
        }

        /// <summary>
        /// Creates a sigle composite action from the passed functions
        /// </summary>
        public Action<TStart> Compose
            <TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TLink12,
                TLink13,
                TLink14, TEnd>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b,
                    Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f,
                    Func<TLink7, TLink8> g, Func<TLink8, TLink9> h, Func<TLink9, TLink10> i, Func<TLink10, TLink11> j,
                    Func<TLink11, TLink12> k, Func<TLink12, TLink13> l, Func<TLink13, TLink14> m, Func<TLink14, TEnd> n,
                    Action<TEnd> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, g, h, i, j, k, l, m, n, end);
        }

        /// <summary>
        /// Calls the passed action using the passed array of elements as it's parameters
        /// </summary>
        public void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T, T, T, T, T, T> action, T[] arguments)
        {
            _compose.Apply(action, arguments);
        }

        /// <summary>
        /// Calls the passed action using the passed array of elements as it's parameters
        /// </summary>
        public void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T, T, T, T, T> action, T[] arguments)
        {
            _compose.Apply(action, arguments);
        }

        /// <summary>
        /// Calls the passed action using the passed array of elements as it's parameters
        /// </summary>
        public void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T, T, T, T> action, T[] arguments)
        {
            _compose.Apply(action, arguments);
        }

        /// <summary>
        /// Calls the passed action using the passed array of elements as it's parameters
        /// </summary>
        public void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T, T, T> action, T[] arguments)
        {
            _compose.Apply(action, arguments);
        }

        /// <summary>
        /// Calls the passed action using the passed array of elements as it's parameters
        /// </summary>
        public void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T, T> action, T[] arguments)
        {
            _compose.Apply(action, arguments);
        }

        /// <summary>
        /// Calls the passed action using the passed array of elements as it's parameters
        /// </summary>
        public void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T> action, T[] arguments)
        {
            _compose.Apply(action, arguments);
        }

        /// <summary>
        /// Calls the passed action using the passed array of elements as it's parameters
        /// </summary>
        public void Apply<T>(Action<T, T, T, T, T, T, T, T, T> action, T[] arguments)
        {
            _compose.Apply(action, arguments);
        }

        /// <summary>
        /// Calls the passed action using the passed array of elements as it's parameters
        /// </summary>
        public void Apply<T>(Action<T, T, T, T, T, T, T, T> action, T[] arguments)
        {
            _compose.Apply(action, arguments);
        }

        /// <summary>
        /// Calls the passed action using the passed array of elements as it's parameters
        /// </summary>
        public void Apply<T>(Action<T, T, T, T, T, T, T> action, T[] arguments)
        {
            _compose.Apply(action, arguments);
        }

        /// <summary>
        /// Calls the passed action using the passed array of elements as it's parameters
        /// </summary>
        public void Apply<T>(Action<T, T, T, T, T, T> action, T[] arguments)
        {
            _compose.Apply(action, arguments);
        }

        /// <summary>
        /// Calls the passed action using the passed array of elements as it's parameters
        /// </summary>
        public void Apply<T>(Action<T, T, T, T, T> action, T[] arguments)
        {
            _compose.Apply(action, arguments);
        }

        /// <summary>
        /// Calls the passed action using the passed array of elements as it's parameters
        /// </summary>
        public void Apply<T>(Action<T, T, T, T> action, T[] arguments)
        {
            _compose.Apply(action, arguments);
        }

        /// <summary>
        /// Calls the passed action using the passed array of elements as it's parameters
        /// </summary>
        public void Apply<T>(Action<T, T, T> action, T[] arguments)
        {
            _compose.Apply(action, arguments);
        }

        /// <summary>
        /// Calls the passed action using the passed array of elements as it's parameters
        /// </summary>
        public void Apply<T>(Action<T, T> action, T[] arguments)
        {
            _compose.Apply(action, arguments);
        }

        /// <summary>
        /// Calls the passed action using the passed array of elements as it's parameters
        /// </summary>
        public void Apply<T>(Action<T> action, T[] arguments)
        {
            _compose.Apply(action, arguments);
        }

        /// <summary>
        /// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
        /// </summary>
        public Func <T0,Func <T1,Func <T2, Func <T3,Func<T4,Func<T5,Func<T6,Func<T7,Func<T8,Func<T9,Func<T10,Func<T11,Func<T12,Func <T13,Func<T14,Action<T15>>>>>>>>>>>>>>>> 
            Curry <T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
                Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> target
            )
        {
            return _split.Curry(target);
        }

        /// <summary>
        /// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
        /// </summary>
        public Func<T0,Func<T1,Func<T2,Func<T3,Func<T4,Func<T5,Func<T6,Func<T7,Func<T8,Func<T9,Func<T10,Func<T11,Func<T12,Func<T13,Action<T14>>>>>>>>>>>>>>> 
            Curry
            <T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> target)
        {
            return _split.Curry(target);
        }

        /// <summary>
        /// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
        /// </summary>
        public Func <T0, Func <T1, Func <T2, Func <T3, Func <T4, Func <T5, Func <T6, Func <T7, Func <T8,Func <T9,Func<T10,Func<T11,Func<T12,Action<T13>>>>>>>>>>>>>> Curry
            <T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> target)
        {
            return _split.Curry(target);
        }

        /// <summary>
        /// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
        /// </summary>
        public Func<T0,Func<T1,Func<T2,Func<T3,Func<T4,Func<T5,Func<T6,Func<T7,Func<T8,Func<T9,Func<T10,Func<T11,Action<T12>>>>>>>>>>>>> Curry
            <T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> target)
        {
            return _split.Curry(target);
        }

        /// <summary>
        /// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
        /// </summary>
        public Func <T0, Func<T1,Func<T2,Func<T3,Func<T4,Func<T5,Func<T6,Func<T7, Func<T8, Func<T9, Func<T10, Action<T11>>>>>>>>>>>> Curry
            <T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> target)
        {
            return _split.Curry(target);
        }

        /// <summary>
        /// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
        /// </summary>
        public Func <T0, Func <T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Action<T10>>>>>>>>>>> 
            Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> target)
        {
            return _split.Curry(target);
        }

        /// <summary>
        /// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
        /// </summary>
        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Action<T9>>>>>>>>>>
            Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> target)
        {
            return _split.Curry(target);
        }

        /// <summary>
        /// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
        /// </summary>
        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Action<T8>>>>>>>>> Curry
            <T0, T1, T2, T3, T4, T5, T6, T7, T8>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8> target)
        {
            return _split.Curry(target);
        }

        /// <summary>
        /// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
        /// </summary>
        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Action<T7>>>>>>>> Curry
            <T0, T1, T2, T3, T4, T5, T6, T7>(Action<T0, T1, T2, T3, T4, T5, T6, T7> target)
        {
            return _split.Curry(target);
        }

        /// <summary>
        /// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
        /// </summary>
        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Action<T6>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6>(
            Action<T0, T1, T2, T3, T4, T5, T6> target)
        {
            return _split.Curry(target);
        }

        /// <summary>
        /// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
        /// </summary>
        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Action<T5>>>>>> Curry<T0, T1, T2, T3, T4, T5>(
            Action<T0, T1, T2, T3, T4, T5> target)
        {
            return _split.Curry(target);
        }

        /// <summary>
        /// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
        /// </summary>
        public Func<T0, Func<T1, Func<T2, Func<T3, Action<T4>>>>> Curry<T0, T1, T2, T3, T4>(
            Action<T0, T1, T2, T3, T4> target)
        {
            return _split.Curry(target);
        }

        /// <summary>
        /// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
        /// </summary>
        public Func<T0, Func<T1, Func<T2, Action<T3>>>> Curry<T0, T1, T2, T3>(Action<T0, T1, T2, T3> target)
        {
            return _split.Curry(target);
        }

        /// <summary>
        /// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
        /// </summary>
        public Func<T0, Func<T1, Action<T2>>> Curry<T0, T1, T2>(Action<T0, T1, T2> target)
        {
            return _split.Curry(target);
        }

        /// <summary>
        /// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
        /// </summary>
        public Func<T0, Action<T1>> Curry<T0, T1>(Action<T0, T1> target)
        {
            return _split.Curry(target);
        }

        /// <summary>
        /// Translates a sequence of functions each taking one argument into a single action
        /// </summary>
        public Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Action<T15>>>>>>>>>>>>>>>> action)
        {
            return _split.Uncurry(action);
        }

        /// <summary>
        /// Translates a sequence of functions each taking one argument into a single action
        /// </summary>
        public Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Action<T14>>>>>>>>>>>>>>> action)
        {
            return _split.Uncurry(action);
        }

        /// <summary>
        /// Translates a sequence of functions each taking one argument into a single action
        /// </summary>
        public Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Action<T13>>>>>>>>>>>>>> action)
        {
            return _split.Uncurry(action);
        }

        /// <summary>
        /// Translates a sequence of functions each taking one argument into a single action
        /// </summary>
        public Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Action<T12>>>>>>>>>>>>> action)
        {
            return _split.Uncurry(action);
        }

        /// <summary>
        /// Translates a sequence of functions each taking one argument into a single action
        /// </summary>
        public Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Action<T11>>>>>>>>>>>> action)
        {
            return _split.Uncurry(action);
        }

        /// <summary>
        /// Translates a sequence of functions each taking one argument into a single action
        /// </summary>
        public Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Action<T10>>>>>>>>>>> action)
        {
            return _split.Uncurry(action);
        }

        /// <summary>
        /// Translates a sequence of functions each taking one argument into a single action
        /// </summary>
        public Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Action<T9>>>>>>>>>> action)
        {
            return _split.Uncurry(action);
        }

        /// <summary>
        /// Translates a sequence of functions each taking one argument into a single action
        /// </summary>
        public Action<T0, T1, T2, T3, T4, T5, T6, T7, T8> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Action<T8>>>>>>>>> action)
        {
            return _split.Uncurry(action);
        }

        /// <summary>
        /// Translates a sequence of functions each taking one argument into a single action
        /// </summary>
        public Action<T0, T1, T2, T3, T4, T5, T6, T7> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Action<T7>>>>>>>> action)
        {
            return _split.Uncurry(action);
        }

        /// <summary>
        /// Translates a sequence of functions each taking one argument into a single action
        /// </summary>
        public Action<T0, T1, T2, T3, T4, T5, T6> Uncurry<T0, T1, T2, T3, T4, T5, T6>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Action<T6>>>>>>> action)
        {
            return _split.Uncurry(action);
        }

        /// <summary>
        /// Translates a sequence of functions each taking one argument into a single action
        /// </summary>
        public Action<T0, T1, T2, T3, T4, T5> Uncurry<T0, T1, T2, T3, T4, T5>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Action<T5>>>>>> action)
        {
            return _split.Uncurry(action);
        }

        /// <summary>
        /// Translates a sequence of functions each taking one argument into a single action
        /// </summary>
        public Action<T0, T1, T2, T3, T4> Uncurry<T0, T1, T2, T3, T4>(Func<T0, Func<T1, Func<T2, Func<T3, Action<T4>>>>> action)
        {
            return _split.Uncurry(action);
        }

        /// <summary>
        /// Translates a sequence of functions each taking one argument into a single action
        /// </summary>
        public Action<T0, T1, T2, T3> Uncurry<T0, T1, T2, T3>(Func<T0, Func<T1, Func<T2, Action<T3>>>> action)
        {
            return _split.Uncurry(action);
        }

        /// <summary>
        /// Translates a sequence of functions each taking one argument into a single action
        /// </summary>
        public Action<T0, T1, T2> Uncurry<T0, T1, T2>(Func<T0, Func<T1, Action<T2>>> action)
        {
            return _split.Uncurry(action);
        }

        /// <summary>
        /// Translates a sequence of functions each taking one argument into a single action
        /// </summary>
        public Action<T0, T1> Uncurry<T0, T1>(Func<T0, Action<T1>> action)
        {
            return _split.Uncurry(action);
        }

        /// <summary>
        /// Creates function from the passed action ( resulting function will always return null )
        /// </summary>
        public Func<object> ToFunction(System.Action action)
        {
            return _convert.ToFunction(action);
        }

        /// <summary>
        /// Creates function from the passed action ( resulting function will always return null )
        /// </summary>
        public Func<T1, object> ToFunction<T1>(Action<T1> action)
        {
            return _convert.ToFunction(action);
        }

        /// <summary>
        /// Creates function from the passed action ( resulting function will always return null )
        /// </summary>
        public Func<T1, T2, object> ToFunction<T1, T2>(Action<T1, T2> action)
        {
            return _convert.ToFunction(action);
        }

        /// <summary>
        /// Creates function from the passed action ( resulting function will always return null )
        /// </summary>
        public Func<T1, T2, T3, object> ToFunction<T1, T2, T3>(Action<T1, T2, T3> action)
        {
            return _convert.ToFunction(action);
        }

        /// <summary>
        /// Creates function from the passed action ( resulting function will always return null )
        /// </summary>
        public Func<T1, T2, T3, T4, object> ToFunction<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action)
        {
            return _convert.ToFunction(action);
        }

        /// <summary>
        /// Creates function from the passed action ( resulting function will always return null )
        /// </summary>
        public Func<T1, T2, T3, T4, T5, object> ToFunction<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action)
        {
            return _convert.ToFunction(action);
        }

        /// <summary>
        /// Creates function from the passed action ( resulting function will always return null )
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, object> ToFunction<T1, T2, T3, T4, T5, T6>(
            Action<T1, T2, T3, T4, T5, T6> action)
        {
            return _convert.ToFunction(action);
        }

        /// <summary>
        /// Creates function from the passed action ( resulting function will always return null )
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, object> ToFunction<T1, T2, T3, T4, T5, T6, T7>(
            Action<T1, T2, T3, T4, T5, T6, T7> action)
        {
            return _convert.ToFunction(action);
        }

        /// <summary>
        /// Creates function from the passed action ( resulting function will always return null )
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, object> ToFunction<T1, T2, T3, T4, T5, T6, T7, T8>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8> action)
        {
            return _convert.ToFunction(action);
        }

        /// <summary>
        /// Creates function from the passed action ( resulting function will always return null )
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, object> ToFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action)
        {
            return _convert.ToFunction(action);
        }

        /// <summary>
        /// Creates function from the passed action ( resulting function will always return null )
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, object> ToFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
            (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action)
        {
            return _convert.ToFunction(action);
        }

        /// <summary>
        /// Creates function from the passed action ( resulting function will always return null )
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, object> ToFunction
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action)
        {
            return _convert.ToFunction(action);
        }

        /// <summary>
        /// Creates function from the passed action ( resulting function will always return null )
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, object> ToFunction
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action)
        {
            return _convert.ToFunction(action);
        }

        /// <summary>
        /// Creates function from the passed action ( resulting function will always return null )
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, object> ToFunction
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action)
        {
            return _convert.ToFunction(action);
        }

        /// <summary>
        /// Creates function from the passed action ( resulting function will always return null )
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, object> ToFunction
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action)
        {
            return _convert.ToFunction(action);
        }

        /// <summary>
        /// Creates function from the passed action ( resulting function will always return null )
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, object> ToFunction
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action)
        {
            return _convert.ToFunction(action);
        }

        /// <summary>
        /// Creates function from the passed action ( resulting function will always return null )
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, object> ToFunction
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action)
        {
            return _convert.ToFunction(action);
        }

        /// <summary>
        ///  Creates a new action from the passed action being bound to the passed parameters
        /// </summary>
        public System.Action Bind<T1>(Action<T1> action, T1 a)
        {
            return _bind.Bind(action, a);
        }

        /// <summary>
        ///  Creates a new action from the passed action being bound to the passed parameters
        /// </summary>
        public System.Action Bind<T1, T2>(Action<T1, T2> action, T1 a, T2 b)
        {
            return _bind.Bind(action, a, b);
        }

        /// <summary>
        ///  Creates a new action from the passed action being bound to the passed parameters
        /// </summary>
        public System.Action Bind<T1, T2, T3>(Action<T1, T2, T3> action, T1 a, T2 b, T3 c)
        {
            return _bind.Bind(action, a, b, c);
        }

        /// <summary>
        ///  Creates a new action from the passed action being bound to the passed parameters
        /// </summary>
        public System.Action Bind<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 a, T2 b, T3 c, T4 d)
        {
            return _bind.Bind(action, a, b, c, d);
        }

        /// <summary>
        ///  Creates a new action from the passed action being bound to the passed parameters
        /// </summary>
        public System.Action Bind<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _bind.Bind(action, a, b, c, d, e);
        }

        /// <summary>
        ///  Creates a new action from the passed action being bound to the passed parameters
        /// </summary>
        public System.Action Bind<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f)
        {
            return _bind.Bind(action, a, b, c, d, e, f);
        }

        /// <summary>
        ///  Creates a new action from the passed action being bound to the passed parameters
        /// </summary>
        public System.Action Bind<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 a, T2 b,
            T3 c, T4 d, T5 e, T6 f, T7 g)
        {
            return _bind.Bind(action, a, b, c, d, e, f, g);
        }

        /// <summary>
        ///  Creates a new action from the passed action being bound to the passed parameters
        /// </summary>
        public System.Action Bind<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 a,
            T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
        {
            return _bind.Bind(action, a, b, c, d, e, f, g, h);
        }

        /// <summary>
        ///  Creates a new action from the passed action being bound to the passed parameters
        /// </summary>
        public System.Action Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action,
            T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
        {
            return _bind.Bind(action, a, b, c, d, e, f, g, h, i);
        }

        /// <summary>
        ///  Creates a new action from the passed action being bound to the passed parameters
        /// </summary>
        public System.Action Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i,
            T10 j)
        {
            return _bind.Bind(action, a, b, c, d, e, f, g, h, i, j);
        }

        /// <summary>
        ///  Creates a new action from the passed action being bound to the passed parameters
        /// </summary>
        public System.Action Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h,
            T9 i, T10 j, T11 k)
        {
            return _bind.Bind(action, a, b, c, d, e, f, g, h, i, j, k);
        }

        /// <summary>
        ///  Creates a new action from the passed action being bound to the passed parameters
        /// </summary>
        public System.Action Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g,
            T8 h, T9 i, T10 j, T11 k, T12 l)
        {
            return _bind.Bind(action, a, b, c, d, e, f, g, h, i, j, k, l);
        }

        /// <summary>
        ///  Creates a new action from the passed action being bound to the passed parameters
        /// </summary>
        public System.Action Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m)
        {
            return _bind.Bind(action, a, b, c, d, e, f, g, h, i, j, k, l, m);
        }

        /// <summary>
        ///  Creates a new action from the passed action being bound to the passed parameters
        /// </summary>
        public System.Action Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n)
        {
            return _bind.Bind(action, a, b, c, d, e, f, g, h, i, j, k, l, m, n);
        }

        /// <summary>
        ///  Creates a new action from the passed action being bound to the passed parameters
        /// </summary>
        public System.Action Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n, T15 o)
        {
            return _bind.Bind(action, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
        }

        /// <summary>
        ///  Creates a new action from the passed action being bound to the passed parameters
        /// </summary>
        public System.Action Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n, T15 o, T16 p)
        {
            return _bind.Bind(action, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T2> Partial<T1, T2>(Action<T1, T2> action, T1 a)
        {
            return _bind.Partial(action, a);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T2, T3> Partial<T1, T2, T3>(Action<T1, T2, T3> action, T1 a)
        {
            return _bind.Partial(action, a);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T3> Partial<T1, T2, T3>(Action<T1, T2, T3> action, T1 a, T2 b)
        {
            return _bind.Partial(action, a, b);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T2, T3, T4> Partial<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 a)
        {
            return _bind.Partial(action, a);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T3, T4> Partial<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 a, T2 b)
        {
            return _bind.Partial(action, a, b);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T4> Partial<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 a, T2 b, T3 c)
        {
            return _bind.Partial(action, a, b, c);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T2, T3, T4, T5> Partial<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 a)
        {
            return _bind.Partial(action, a);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T3, T4, T5> Partial<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 a, T2 b)
        {
            return _bind.Partial(action, a, b);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T4, T5> Partial<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 a, T2 b, T3 c)
        {
            return _bind.Partial(action, a, b, c);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T5> Partial<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 a, T2 b, T3 c, T4 d)
        {
            return _bind.Partial(action, a, b, c, d);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T2, T3, T4, T5, T6> Partial<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 a)
        {
            return _bind.Partial(action, a);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T3, T4, T5, T6> Partial<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 a, T2 b)
        {
            return _bind.Partial(action, a, b);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T4, T5, T6> Partial<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 a, T2 b,
            T3 c)
        {
            return _bind.Partial(action, a, b, c);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T5, T6> Partial<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 a, T2 b, T3 c,
            T4 d)
        {
            return _bind.Partial(action, a, b, c, d);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T6> Partial<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 a, T2 b, T3 c, T4 d,
            T5 e)
        {
            return _bind.Partial(action, a, b, c, d, e);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T2, T3, T4, T5, T6, T7> Partial<T1, T2, T3, T4, T5, T6, T7>(
            Action<T1, T2, T3, T4, T5, T6, T7> action, T1 a)
        {
            return _bind.Partial(action, a);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T3, T4, T5, T6, T7> Partial<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action,
            T1 a, T2 b)
        {
            return _bind.Partial(action, a, b);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T4, T5, T6, T7> Partial<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action,
            T1 a, T2 b, T3 c)
        {
            return _bind.Partial(action, a, b, c);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T5, T6, T7> Partial<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 a,
            T2 b, T3 c, T4 d)
        {
            return _bind.Partial(action, a, b, c, d);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T6, T7> Partial<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 a, T2 b,
            T3 c, T4 d, T5 e)
        {
            return _bind.Partial(action, a, b, c, d, e);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T7> Partial<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 a, T2 b,
            T3 c, T4 d, T5 e, T6 f)
        {
            return _bind.Partial(action, a, b, c, d, e, f);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T2, T3, T4, T5, T6, T7, T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 a)
        {
            return _bind.Partial(action, a);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T3, T4, T5, T6, T7, T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 a, T2 b)
        {
            return _bind.Partial(action, a, b);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T4, T5, T6, T7, T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 a, T2 b, T3 c)
        {
            return _bind.Partial(action, a, b, c);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T5, T6, T7, T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 a, T2 b, T3 c, T4 d)
        {
            return _bind.Partial(action, a, b, c, d);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T6, T7, T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action,
            T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _bind.Partial(action, a, b, c, d, e);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T7, T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action,
            T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
        {
            return _bind.Partial(action, a, b, c, d, e, f);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 a,
            T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T2, T3, T4, T5, T6, T7, T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 a)
        {
            return _bind.Partial(action, a);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T3, T4, T5, T6, T7, T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 a, T2 b)
        {
            return _bind.Partial(action, a, b);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T4, T5, T6, T7, T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 a, T2 b, T3 c)
        {
            return _bind.Partial(action, a, b, c);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T5, T6, T7, T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 a, T2 b, T3 c, T4 d)
        {
            return _bind.Partial(action, a, b, c, d);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T6, T7, T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _bind.Partial(action, a, b, c, d, e);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T7, T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
        {
            return _bind.Partial(action, a, b, c, d, e, f);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action,
            T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T2, T3, T4, T5, T6, T7, T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 a)
        {
            return _bind.Partial(action, a);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T3, T4, T5, T6, T7, T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 a, T2 b)
        {
            return _bind.Partial(action, a, b);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T4, T5, T6, T7, T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 a, T2 b, T3 c)
        {
            return _bind.Partial(action, a, b, c);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T5, T6, T7, T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 a, T2 b, T3 c, T4 d)
        {
            return _bind.Partial(action, a, b, c, d);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T6, T7, T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _bind.Partial(action, a, b, c, d, e);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T7, T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
        {
            return _bind.Partial(action, a, b, c, d, e, f);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h,
            T9 i)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h, i);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a)
        {
            return _bind.Partial(action, a);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T3, T4, T5, T6, T7, T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a, T2 b)
        {
            return _bind.Partial(action, a, b);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T4, T5, T6, T7, T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a, T2 b, T3 c)
        {
            return _bind.Partial(action, a, b, c);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T5, T6, T7, T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a, T2 b, T3 c, T4 d)
        {
            return _bind.Partial(action, a, b, c, d);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T6, T7, T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _bind.Partial(action, a, b, c, d, e);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T7, T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
        {
            return _bind.Partial(action, a, b, c, d, e, f);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g,
            T8 h)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g,
            T8 h, T9 i)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h, i);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g,
            T8 h, T9 i, T10 j)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h, i, j);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a)
        {
            return _bind.Partial(action, a);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b)
        {
            return _bind.Partial(action, a, b);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T4, T5, T6, T7, T8, T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b, T3 c)
        {
            return _bind.Partial(action, a, b, c);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T5, T6, T7, T8, T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b, T3 c, T4 d)
        {
            return _bind.Partial(action, a, b, c, d);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T6, T7, T8, T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _bind.Partial(action, a, b, c, d, e);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T7, T8, T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
        {
            return _bind.Partial(action, a, b, c, d, e, f);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T8, T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g, T8 h)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g, T8 h, T9 i)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h, i);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g, T8 h, T9 i, T10 j)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h, i, j);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g, T8 h, T9 i, T10 j, T11 k)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h, i, j, k);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a)
        {
            return _bind.Partial(action, a);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b)
        {
            return _bind.Partial(action, a, b);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c)
        {
            return _bind.Partial(action, a, b, c);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T5, T6, T7, T8, T9, T10, T11, T12, T13> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c, T4 d)
        {
            return _bind.Partial(action, a, b, c, d);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T6, T7, T8, T9, T10, T11, T12, T13> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _bind.Partial(action, a, b, c, d, e);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T7, T8, T9, T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
        {
            return _bind.Partial(action, a, b, c, d, e, f);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T8, T9, T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T9, T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g, T8 h)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g, T8 h, T9 i)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h, i);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g, T8 h, T9 i, T10 j)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h, i, j);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g, T8 h, T9 i, T10 j, T11 k)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h, i, j, k);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g, T8 h, T9 i, T10 j, T11 k, T12 l)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h, i, j, k, l);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a)
        {
            return _bind.Partial(action, a);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b)
        {
            return _bind.Partial(action, a, b);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c)
        {
            return _bind.Partial(action, a, b, c);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d)
        {
            return _bind.Partial(action, a, b, c, d);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T6, T7, T8, T9, T10, T11, T12, T13, T14> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _bind.Partial(action, a, b, c, d, e);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T7, T8, T9, T10, T11, T12, T13, T14> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f)
        {
            return _bind.Partial(action, a, b, c, d, e, f);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T8, T9, T10, T11, T12, T13, T14> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f, T7 g)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T9, T10, T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f, T7 g, T8 h)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T10, T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f, T7 g, T8 h, T9 i)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h, i);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f, T7 g, T8 h, T9 i, T10 j)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h, i, j);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f, T7 g, T8 h, T9 i, T10 j, T11 k)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h, i, j, k);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h, i, j, k, l);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h, i, j, k, l, m);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a)
        {
            return _bind.Partial(action, a);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b)
        {
            return _bind.Partial(action, a, b);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c)
        {
            return _bind.Partial(action, a, b, c);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d)
        {
            return _bind.Partial(action, a, b, c, d);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d,
            T5 e)
        {
            return _bind.Partial(action, a, b, c, d, e);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T7, T8, T9, T10, T11, T12, T13, T14, T15> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f)
        {
            return _bind.Partial(action, a, b, c, d, e, f);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T8, T9, T10, T11, T12, T13, T14, T15> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T9, T10, T11, T12, T13, T14, T15> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T10, T11, T12, T13, T14, T15> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h, i);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T11, T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
            (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d,
                T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h, i, j);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h, i, j, k);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h, i, j, k, l);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h, i, j, k, l, m);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h, i, j, k, l, m, n);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a)
        {
            return _bind.Partial(action, a);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b)
        {
            return _bind.Partial(action, a, b);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c)
        {
            return _bind.Partial(action, a, b, c);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c,
            T4 d)
        {
            return _bind.Partial(action, a, b, c, d);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c,
            T4 d, T5 e)
        {
            return _bind.Partial(action, a, b, c, d, e);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f)
        {
            return _bind.Partial(action, a, b, c, d, e, f);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T8, T9, T10, T11, T12, T13, T14, T15, T16> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T9, T10, T11, T12, T13, T14, T15, T16> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g, T8 h)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T10, T11, T12, T13, T14, T15, T16> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h, i);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T11, T12, T13, T14, T15, T16> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h, i, j);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T12, T13, T14, T15, T16> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h, i, j, k);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T13, T14, T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
            (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c,
                T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h, i, j, k, l);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T14, T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h, i, j, k, l, m);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h, i, j, k, l, m, n);
        }

        /// <summary>
        /// Binds the action partially, from left to right
        /// </summary>
        public Action<T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n, T15 o)
        {
            return _bind.Partial(action, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
        }
    }
}
