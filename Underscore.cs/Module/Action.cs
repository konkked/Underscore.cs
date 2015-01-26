using System;
using System.Threading.Tasks;
using Underscore.Action;

namespace Underscore.Module
{
    public class Action :
        IBindingComponent,
        IPartialComponent,
        ISplitComponent,
        IComposeComponent,
        ISynchComponent,
        IConvertComponent
    {

        private readonly IBindingComponent _bind;
        private readonly IPartialComponent _partial;
        private readonly ISplitComponent _split;
        private readonly IComposeComponent _compose;
        private readonly ISynchComponent _synch;
        private readonly IConvertComponent _convert;

        public Action(
            IBindingComponent bind,
            IPartialComponent partial,
            ISplitComponent split,
            IComposeComponent compose,
            ISynchComponent synch,
            IConvertComponent convert
            )
        {
            _bind = bind;
            _partial = partial;
            _split = split;
            _compose = compose;
            _synch = synch;
            _convert = convert;
        }

        public Func<T0, T1, T2, T3, T4, T5, T6, T7, Action<T8, T9, T10, T11, T12, T13, T14, T15>> Split
            <T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> target)
        {
            return _split.Split(target);
        }

        public Func<T0, T1, T2, T3, Action<T4, T5, T6, T7>> Split<T0, T1, T2, T3, T4, T5, T6, T7>(
            Action<T0, T1, T2, T3, T4, T5, T6, T7> target)
        {
            return _split.Split(target);
        }

        public Func<T0, T1, Action<T2, T3>> Split<T0, T1, T2, T3>(Action<T0, T1, T2, T3> target)
        {
            return _split.Split(target);
        }

        public Func<T0, Action<T1>> Split<T0, T1>(Action<T0, T1> target)
        {
            return _split.Split(target);
        }

        public System.Action After(System.Action function, int count)
        {
            var ncount = count;
            return () => { if (ncount-- == 0) function(); };
        }

        public System.Action Before(System.Action function, int count)
        {
            var ncount = count;
            return () => { if (ncount-- >= 0) function(); };
        }

        public Func<Task> Debounce(System.Action action, int milliseconds)
        {
            return _synch.Debounce(action, milliseconds);
        }

        public Func<T, Task> Debounce<T>(Action<T> action, int milliseconds)
        {
            return _synch.Debounce(action, milliseconds);
        }

        public Func<T1, T2, Task> Debounce<T1, T2>(Action<T1, T2> action, int milliseconds)
        {
            return _synch.Debounce(action, milliseconds);
        }

        public Func<T1, T2, T3, Task> Debounce<T1, T2, T3>(Action<T1, T2, T3> action, int milliseconds)
        {
            return _synch.Debounce(action, milliseconds);
        }

        public Func<T1, T2, T3, T4, Task> Debounce<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, int milliseconds)
        {
            return _synch.Debounce(action, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, Task> Debounce<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action,
            int milliseconds)
        {
            return _synch.Debounce(action, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, Task> Debounce<T1, T2, T3, T4, T5, T6>(
            Action<T1, T2, T3, T4, T5, T6> action, int milliseconds)
        {
            return _synch.Debounce(action, milliseconds);
        }

        public Func<Task> Throttle(System.Action action, int milliseconds)
        {
            return _synch.Throttle(action, milliseconds);
        }

        public Func<T, Task> Throttle<T>(Action<T> action, int milliseconds)
        {
            return _synch.Throttle(action, milliseconds);
        }

        public Func<T, Task> Throttle<T>(Action<T> action, int milliseconds, bool leading)
        {
            return _synch.Throttle(action, milliseconds, leading);
        }

        public Func<T1, T2, Task> Throttle<T1, T2>(Action<T1, T2> action, int milliseconds)
        {
            return _synch.Throttle(action, milliseconds);
        }

        public Func<T1, T2, Task> Throttle<T1, T2>(Action<T1, T2> action, int milliseconds, bool leading)
        {
            return _synch.Throttle(action, milliseconds, leading);
        }

        public Func<T1, T2, T3, Task> Throttle<T1, T2, T3>(Action<T1, T2, T3> action, int milliseconds)
        {
            return _synch.Throttle(action, milliseconds);
        }

        public Func<T1, T2, T3, Task> Throttle<T1, T2, T3>(Action<T1, T2, T3> action, int milliseconds, bool leading)
        {
            return _synch.Throttle(action, milliseconds, leading);
        }

        public Func<T1, T2, T3, T4, Task> Throttle<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, int milliseconds)
        {
            return _synch.Throttle(action, milliseconds);
        }

        public Func<T1, T2, T3, T4, Task> Throttle<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, int milliseconds,
            bool leading)
        {
            return _synch.Throttle(action, milliseconds, leading);
        }

        public Func<T1, T2, T3, T4, T5, Task> Throttle<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action,
            int milliseconds)
        {
            return _synch.Throttle(action, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, Task> Throttle<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action,
            int milliseconds, bool leading)
        {
            return _synch.Throttle(action, milliseconds, leading);
        }

        public Func<T1, T2, T3, T4, T5, T6, Task> Throttle<T1, T2, T3, T4, T5, T6>(
            Action<T1, T2, T3, T4, T5, T6> action, int milliseconds)
        {
            return _synch.Throttle(action, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, Task> Throttle<T1, T2, T3, T4, T5, T6>(
            Action<T1, T2, T3, T4, T5, T6> action, int milliseconds, bool leading)
        {
            return _synch.Throttle(action, milliseconds, leading);
        }

        public Func<Task> Delay(System.Action action, int milliseconds)
        {
            return _synch.Delay(action, milliseconds);
        }

        public Func<T, Task> Delay<T>(Action<T> action, int milliseconds)
        {
            return _synch.Delay(action, milliseconds);
        }

        public Func<T1, T2, Task> Delay<T1, T2>(Action<T1, T2> action, int milliseconds)
        {
            return _synch.Delay(action, milliseconds);
        }

        public Func<T1, T2, T3, Task> Delay<T1, T2, T3>(Action<T1, T2, T3> action, int milliseconds)
        {
            return _synch.Delay(action, milliseconds);
        }

        public Func<T1, T2, T3, T4, Task> Delay<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, int milliseconds)
        {
            return _synch.Delay(action, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, Task> Delay<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action,
            int milliseconds)
        {
            return _synch.Delay(action, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, Task> Delay<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action,
            int milliseconds)
        {
            return _synch.Delay(action, milliseconds);
        }

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

        public Action<T> Once<T>(Action<T> action)
        {
            return _synch.Once(action);
        }

        public Action<T1, T2> Once<T1, T2>(Action<T1, T2> action)
        {
            return _synch.Once(action);
        }

        public Action<T1, T2, T3> Once<T1, T2, T3>(Action<T1, T2, T3> action)
        {
            return _synch.Once(action);
        }

        public Action<T1, T2, T3, T4> Once<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action)
        {
            return _synch.Once(action);
        }

        public Action<T1, T2, T3, T4, T5> Once<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action)
        {
            return _synch.Once(action);
        }

        public Action<T1, T2, T3, T4, T5, T6> Once<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action)
        {
            return _synch.Once(action);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7> Once<T1, T2, T3, T4, T5, T6, T7>(
            Action<T1, T2, T3, T4, T5, T6, T7> action)
        {
            return _synch.Once(action);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8> Once<T1, T2, T3, T4, T5, T6, T7, T8>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8> action)
        {
            return _synch.Once(action);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action)
        {
            return _synch.Once(action);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action)
        {
            return _synch.Once(action);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action)
        {
            return _synch.Once(action);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Once
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action)
        {
            return _synch.Once(action);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Once
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action)
        {
            return _synch.Once(action);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Once
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action)
        {
            return _synch.Once(action);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Once
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action)
        {
            return _synch.Once(action);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Once
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action)
        {
            return _synch.Once(action);
        }

        public Func<Task> After(int count, System.Action action)
        {
            return _synch.After(count, action);
        }

        public Func<T, Task> After<T>(int count, Action<T> action)
        {
            return _synch.After(count, action);
        }

        public Func<T1, T2, Task> After<T1, T2>(int count, Action<T1, T2> action)
        {
            return _synch.After(count, action);
        }

        public Func<T1, T2, T3, Task> After<T1, T2, T3>(int count, Action<T1, T2, T3> action)
        {
            return _synch.After(count, action);
        }

        public Func<T1, T2, T3, T4, Task> After<T1, T2, T3, T4>(int count, Action<T1, T2, T3, T4> action)
        {
            return _synch.After(count, action);
        }

        public Func<T1, T2, T3, T4, T5, Task> After<T1, T2, T3, T4, T5>(int count, Action<T1, T2, T3, T4, T5> action)
        {
            return _synch.After(count, action);
        }

        public Func<T1, T2, T3, T4, T5, T6, Task> After<T1, T2, T3, T4, T5, T6>(int count,
            Action<T1, T2, T3, T4, T5, T6> action)
        {
            return _synch.After(count, action);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, Task> After<T1, T2, T3, T4, T5, T6, T7>(int count,
            Action<T1, T2, T3, T4, T5, T6, T7> action)
        {
            return _synch.After(count, action);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> After<T1, T2, T3, T4, T5, T6, T7, T8>(int count,
            Action<T1, T2, T3, T4, T5, T6, T7, T8> action)
        {
            return _synch.After(count, action);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9>(int count,
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action)
        {
            return _synch.After(count, action);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            int count, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action)
        {
            return _synch.After(count, action);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> After
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int count,
                Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action)
        {
            return _synch.After(count, action);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> After
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int count,
                Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action)
        {
            return _synch.After(count, action);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> After
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int count,
                Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action)
        {
            return _synch.After(count, action);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> After
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int count,
                Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action)
        {
            return _synch.After(count, action);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> After
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int count,
                Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action)
        {
            return _synch.After(count, action);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> After
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(int count,
                Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action)
        {
            return _synch.After(count, action);
        }

        public System.Action Before(int count, System.Action action)
        {
            return _synch.Before(count, action);
        }

        public Action<T> Before<T>(int count, Action<T> action)
        {
            return _synch.Before(count, action);
        }

        public Action<T1, T2> Before<T1, T2>(int count, Action<T1, T2> action)
        {
            return _synch.Before(count, action);
        }

        public Action<T1, T2, T3> Before<T1, T2, T3>(int count, Action<T1, T2, T3> action)
        {
            return _synch.Before(count, action);
        }

        public Action<T1, T2, T3, T4> Before<T1, T2, T3, T4>(int count, Action<T1, T2, T3, T4> action)
        {
            return _synch.Before(count, action);
        }

        public Action<T1, T2, T3, T4, T5> Before<T1, T2, T3, T4, T5>(int count, Action<T1, T2, T3, T4, T5> action)
        {
            return _synch.Before(count, action);
        }

        public Action<T1, T2, T3, T4, T5, T6> Before<T1, T2, T3, T4, T5, T6>(int count,
            Action<T1, T2, T3, T4, T5, T6> action)
        {
            return _synch.Before(count, action);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7> Before<T1, T2, T3, T4, T5, T6, T7>(int count,
            Action<T1, T2, T3, T4, T5, T6, T7> action)
        {
            return _synch.Before(count, action);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8> Before<T1, T2, T3, T4, T5, T6, T7, T8>(int count,
            Action<T1, T2, T3, T4, T5, T6, T7, T8> action)
        {
            return _synch.Before(count, action);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9>(int count,
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action)
        {
            return _synch.Before(count, action);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            int count, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action)
        {
            return _synch.Before(count, action);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
            (int count, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action)
        {
            return _synch.Before(count, action);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Before
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int count,
                Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action)
        {
            return _synch.Before(count, action);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Before
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int count,
                Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action)
        {
            return _synch.Before(count, action);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Before
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int count,
                Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action)
        {
            return _synch.Before(count, action);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Before
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int count,
                Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action)
        {
            return _synch.Before(count, action);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Before
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(int count,
                Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action)
        {
            return _synch.Before(count, action);
        }


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

        public Action<T> Compose<T>(params Action<T>[] actions)
        {
            return _compose.Compose(actions);
        }

        public void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T, T, T, T, T, T, T> action, T[] arguments)
        {
            _compose.Apply(action, arguments);
        }

        public void Call<T1>(Action<T1> action, T1 a)
        {
            _compose.Call(action, a);
        }

        public void Call<T1, T2>(Action<T1, T2> action, T1 a, T2 b)
        {
            _compose.Call(action, a, b);
        }

        public void Call<T1, T2, T3>(Action<T1, T2, T3> action, T1 a, T2 b, T3 c)
        {
            _compose.Call(action, a, b, c);
        }

        public void Call<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 a, T2 b, T3 c, T4 d)
        {
            _compose.Call(action, a, b, c, d);
        }

        public void Call<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            _compose.Call(action, a, b, c, d, e);
        }

        public void Call<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f)
        {
            _compose.Call(action, a, b, c, d, e, f);
        }

        public void Call<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g)
        {
            _compose.Call(action, a, b, c, d, e, f, g);
        }

        public void Call<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g, T8 h)
        {
            _compose.Call(action, a, b, c, d, e, f, g, h);
        }

        public void Call<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 a,
            T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
        {
            _compose.Call(action, a, b, c, d, e, f, g, h, i);
        }

        public void Call<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i,
            T10 j)
        {
            _compose.Call(action, a, b, c, d, e, f, g, h, i, j);
        }

        public void Call<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h,
            T9 i, T10 j, T11 k)
        {
            _compose.Call(action, a, b, c, d, e, f, g, h, i, j, k);
        }

        public void Call<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g,
            T8 h, T9 i, T10 j, T11 k, T12 l)
        {
            _compose.Call(action, a, b, c, d, e, f, g, h, i, j, k, l);
        }

        public void Call<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m)
        {
            _compose.Call(action, a, b, c, d, e, f, g, h, i, j, k, l, m);
        }

        public void Call<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f,
            T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n)
        {
            _compose.Call(action, a, b, c, d, e, f, g, h, i, j, k, l, m, n);
        }

        public void Call<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d,
            T5 e,
            T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n, T15 o)
        {
            _compose.Call(action, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
        }

        public void Call<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n, T15 o, T16 p)
        {
            _compose.Call(action, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
        }

        public Action<TStart> Compose<TStart, TEnd>(Func<TStart, TEnd> start, Action<TEnd> end)
        {
            return _compose.Compose(start, end);
        }

        public Action<TStart> Compose<TStart, TMid, TEnd>(Func<TStart, TMid> start, Func<TMid, TEnd> mid,
            Action<TEnd> end)
        {
            return _compose.Compose(start, mid, end);
        }

        public Action<TStart> Compose<TStart, TLink1, TLink2, TEnd>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a,
            Func<TLink2, TEnd> b, Action<TEnd> end)
        {
            return _compose.Compose(start, a, b, end);
        }

        public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TEnd>(Func<TStart, TLink1> start,
            Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TEnd> c, Action<TEnd> end)
        {
            return _compose.Compose(start, a, b, c, end);
        }

        public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TEnd>(Func<TStart, TLink1> start,
            Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TEnd> d,
            Action<TEnd> end)
        {
            return _compose.Compose(start, a, b, c, d, end);
        }

        public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TEnd>(Func<TStart, TLink1> start,
            Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d,
            Func<TLink5, TEnd> e,
            Action<TEnd> end)
        {
            return _compose.Compose(start, a, b, c, d, e, end);
        }

        public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TEnd>(
            Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c,
            Func<TLink4, TLink5> d,
            Func<TLink5, TLink6> e, Func<TLink6, TEnd> f, Action<TEnd> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, end);
        }

        public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TEnd>(
            Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c,
            Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TEnd> g,
            Action<TEnd> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, g, end);
        }

        public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TEnd>(
            Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b,
            Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f,
            Func<TLink7, TLink8> g, Func<TLink8, TEnd> h, Action<TEnd> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, g, h, end);
        }

        public Action<TStart> Compose
            <TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TEnd>(
            Func<TStart, TLink1> start, Func<TLink1, TLink2> a,
            Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e,
            Func<TLink6, TLink7> f, Func<TLink7, TLink8> g, Func<TLink8, TLink9> h, Func<TLink9, TEnd> i,
            Action<TEnd> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, g, h, i, end);
        }

        public Action<TStart> Compose
            <TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TEnd>(
            Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c,
            Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TLink8> g,
            Func<TLink8, TLink9> h, Func<TLink9, TLink10> i, Func<TLink10, TEnd> j, Action<TEnd> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, g, h, i, j, end);
        }

        public Action<TStart> Compose
            <TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TEnd>(
            Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c,
            Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TLink8> g,
            Func<TLink8, TLink9> h, Func<TLink9, TLink10> i, Func<TLink10, TLink11> j, Func<TLink11, TEnd> k,
            Action<TEnd> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, g, h, i, j, k, end);
        }

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

        public void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T, T, T, T, T, T> action, T[] arguments)
        {
            _compose.Apply(action, arguments);
        }

        public void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T, T, T, T, T> action, T[] arguments)
        {
            _compose.Apply(action, arguments);
        }

        public void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T, T, T, T> action, T[] arguments)
        {
            _compose.Apply(action, arguments);
        }

        public void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T, T, T> action, T[] arguments)
        {
            _compose.Apply(action, arguments);
        }

        public void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T, T> action, T[] arguments)
        {
            _compose.Apply(action, arguments);
        }

        public void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T> action, T[] arguments)
        {
            _compose.Apply(action, arguments);
        }

        public void Apply<T>(Action<T, T, T, T, T, T, T, T, T> action, T[] arguments)
        {
            _compose.Apply(action, arguments);
        }

        public void Apply<T>(Action<T, T, T, T, T, T, T, T> action, T[] arguments)
        {
            _compose.Apply(action, arguments);
        }

        public void Apply<T>(Action<T, T, T, T, T, T, T> action, T[] arguments)
        {
            _compose.Apply(action, arguments);
        }

        public void Apply<T>(Action<T, T, T, T, T, T> action, T[] arguments)
        {
            _compose.Apply(action, arguments);
        }

        public void Apply<T>(Action<T, T, T, T, T> action, T[] arguments)
        {
            _compose.Apply(action, arguments);
        }

        public void Apply<T>(Action<T, T, T, T> action, T[] arguments)
        {
            _compose.Apply(action, arguments);
        }

        public void Apply<T>(Action<T, T, T> action, T[] arguments)
        {
            _compose.Apply(action, arguments);
        }

        public void Apply<T>(Action<T, T> action, T[] arguments)
        {
            _compose.Apply(action, arguments);
        }

        public void Apply<T>(Action<T> action, T[] arguments)
        {
            _compose.Apply(action, arguments);
        }


        public
            Func
                <T0,
                    Func
                        <T1,
                            Func
                                <T2,
                                    Func
                                        <T3,
                                            Func
                                                <T4,
                                                    Func
                                                        <T5,
                                                            Func
                                                                <T6,
                                                                    Func
                                                                        <T7,
                                                                            Func
                                                                                <T8,
                                                                                    Func
                                                                                        <T9,
                                                                                            Func
                                                                                                <T10,
                                                                                                    Func
                                                                                                        <T11,
                                                                                                            Func
                                                                                                                <T12,
                                                                                                                    Func
                                                                                                                        <
                                                                                                                            T13,
                                                                                                                            Func
                                                                                                                                <
                                                                                                                                    T14,
                                                                                                                                    Action
                                                                                                                                        <
                                                                                                                                            T15
                                                                                                                                            >
                                                                                                                                    >
                                                                                                                            >
                                                                                                                    >>>>
                                                                                    >>>>>>>>> Splay
            <T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> target)
        {
            return _split.Splay(target);
        }

        public
            Func
                <T0,
                    Func
                        <T1,
                            Func
                                <T2,
                                    Func
                                        <T3,
                                            Func
                                                <T4,
                                                    Func
                                                        <T5,
                                                            Func
                                                                <T6,
                                                                    Func
                                                                        <T7,
                                                                            Func
                                                                                <T8,
                                                                                    Func
                                                                                        <T9,
                                                                                            Func
                                                                                                <T10,
                                                                                                    Func
                                                                                                        <T11,
                                                                                                            Func
                                                                                                                <T12,
                                                                                                                    Func
                                                                                                                        <
                                                                                                                            T13,
                                                                                                                            Action
                                                                                                                                <
                                                                                                                                    T14
                                                                                                                                    >
                                                                                                                            >
                                                                                                                    >>>>
                                                                                    >>>>>>>>> Splay
            <T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> target)
        {
            return _split.Splay(target);
        }

        public
            Func
                <T0,
                    Func
                        <T1,
                            Func
                                <T2,
                                    Func
                                        <T3,
                                            Func
                                                <T4,
                                                    Func
                                                        <T5,
                                                            Func
                                                                <T6,
                                                                    Func
                                                                        <T7,
                                                                            Func
                                                                                <T8,
                                                                                    Func
                                                                                        <T9,
                                                                                            Func
                                                                                                <T10,
                                                                                                    Func
                                                                                                        <T11,
                                                                                                            Func
                                                                                                                <T12,
                                                                                                                    Action
                                                                                                                        <
                                                                                                                            T13
                                                                                                                            >
                                                                                                                    >>>>
                                                                                    >>>>>>>>> Splay
            <T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> target)
        {
            return _split.Splay(target);
        }

        public
            Func
                <T0,
                    Func
                        <T1,
                            Func
                                <T2,
                                    Func
                                        <T3,
                                            Func
                                                <T4,
                                                    Func
                                                        <T5,
                                                            Func
                                                                <T6,
                                                                    Func
                                                                        <T7,
                                                                            Func
                                                                                <T8,
                                                                                    Func
                                                                                        <T9,
                                                                                            Func
                                                                                                <T10,
                                                                                                    Func
                                                                                                        <T11,
                                                                                                            Action<T12>>
                                                                                                    >>>>>>>>>>> Splay
            <T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> target)
        {
            return _split.Splay(target);
        }

        public
            Func
                <T0,
                    Func
                        <T1,
                            Func
                                <T2,
                                    Func
                                        <T3,
                                            Func
                                                <T4,
                                                    Func
                                                        <T5,
                                                            Func
                                                                <T6,
                                                                    Func<T7, Func<T8, Func<T9, Func<T10, Action<T11>>>>>
                                                                    >>>>>>> Splay
            <T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> target)
        {
            return _split.Splay(target);
        }

        public
            Func
                <T0,
                    Func
                        <T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Action<T10>>>>>>>>>
                            >> Splay<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> target)
        {
            return _split.Splay(target);
        }

        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Action<T9>>>>>>>>>>
            Splay<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> target)
        {
            return _split.Splay(target);
        }

        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Action<T8>>>>>>>>> Splay
            <T0, T1, T2, T3, T4, T5, T6, T7, T8>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8> target)
        {
            return _split.Splay(target);
        }

        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Action<T7>>>>>>>> Splay
            <T0, T1, T2, T3, T4, T5, T6, T7>(Action<T0, T1, T2, T3, T4, T5, T6, T7> target)
        {
            return _split.Splay(target);
        }

        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Action<T6>>>>>>> Splay<T0, T1, T2, T3, T4, T5, T6>(
            Action<T0, T1, T2, T3, T4, T5, T6> target)
        {
            return _split.Splay(target);
        }

        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Action<T5>>>>>> Splay<T0, T1, T2, T3, T4, T5>(
            Action<T0, T1, T2, T3, T4, T5> target)
        {
            return _split.Splay(target);
        }

        public Func<T0, Func<T1, Func<T2, Func<T3, Action<T4>>>>> Splay<T0, T1, T2, T3, T4>(
            Action<T0, T1, T2, T3, T4> target)
        {
            return _split.Splay(target);
        }

        public Func<T0, Func<T1, Func<T2, Action<T3>>>> Splay<T0, T1, T2, T3>(Action<T0, T1, T2, T3> target)
        {
            return _split.Splay(target);
        }

        public Func<T0, Func<T1, Action<T2>>> Splay<T0, T1, T2>(Action<T0, T1, T2> target)
        {
            return _split.Splay(target);
        }

        public Func<T0, Action<T1>> Splay<T0, T1>(Action<T0, T1> target)
        {
            return _split.Splay(target);
        }

        public Func<object> ToFunction(System.Action action)
        {
            return _convert.ToFunction(action);
        }

        public Func<T1, object> ToFunction<T1>(Action<T1> action)
        {
            return _convert.ToFunction(action);
        }

        public Func<T1, T2, object> ToFunction<T1, T2>(Action<T1, T2> action)
        {
            return _convert.ToFunction(action);
        }

        public Func<T1, T2, T3, object> ToFunction<T1, T2, T3>(Action<T1, T2, T3> action)
        {
            return _convert.ToFunction(action);
        }

        public Func<T1, T2, T3, T4, object> ToFunction<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action)
        {
            return _convert.ToFunction(action);
        }

        public Func<T1, T2, T3, T4, T5, object> ToFunction<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action)
        {
            return _convert.ToFunction(action);
        }

        public Func<T1, T2, T3, T4, T5, T6, object> ToFunction<T1, T2, T3, T4, T5, T6>(
            Action<T1, T2, T3, T4, T5, T6> action)
        {
            return _convert.ToFunction(action);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, object> ToFunction<T1, T2, T3, T4, T5, T6, T7>(
            Action<T1, T2, T3, T4, T5, T6, T7> action)
        {
            return _convert.ToFunction(action);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, object> ToFunction<T1, T2, T3, T4, T5, T6, T7, T8>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8> action)
        {
            return _convert.ToFunction(action);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, object> ToFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action)
        {
            return _convert.ToFunction(action);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, object> ToFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
            (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action)
        {
            return _convert.ToFunction(action);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, object> ToFunction
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action)
        {
            return _convert.ToFunction(action);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, object> ToFunction
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action)
        {
            return _convert.ToFunction(action);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, object> ToFunction
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action)
        {
            return _convert.ToFunction(action);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, object> ToFunction
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action)
        {
            return _convert.ToFunction(action);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, object> ToFunction
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action)
        {
            return _convert.ToFunction(action);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, object> ToFunction
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action)
        {
            return _convert.ToFunction(action);
        }

        public System.Action Bind<T1>(Action<T1> action, T1 a)
        {
            return _bind.Bind(action, a);
        }

        public System.Action Bind<T1, T2>(Action<T1, T2> action, T1 a, T2 b)
        {
            return _bind.Bind(action, a, b);
        }

        public System.Action Bind<T1, T2, T3>(Action<T1, T2, T3> action, T1 a, T2 b, T3 c)
        {
            return _bind.Bind(action, a, b, c);
        }

        public System.Action Bind<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 a, T2 b, T3 c, T4 d)
        {
            return _bind.Bind(action, a, b, c, d);
        }

        public System.Action Bind<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _bind.Bind(action, a, b, c, d, e);
        }

        public System.Action Bind<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f)
        {
            return _bind.Bind(action, a, b, c, d, e, f);
        }

        public System.Action Bind<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 a, T2 b,
            T3 c, T4 d, T5 e, T6 f, T7 g)
        {
            return _bind.Bind(action, a, b, c, d, e, f, g);
        }

        public System.Action Bind<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 a,
            T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
        {
            return _bind.Bind(action, a, b, c, d, e, f, g, h);
        }

        public System.Action Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action,
            T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
        {
            return _bind.Bind(action, a, b, c, d, e, f, g, h, i);
        }

        public System.Action Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i,
            T10 j)
        {
            return _bind.Bind(action, a, b, c, d, e, f, g, h, i, j);
        }

        public System.Action Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h,
            T9 i, T10 j, T11 k)
        {
            return _bind.Bind(action, a, b, c, d, e, f, g, h, i, j, k);
        }

        public System.Action Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g,
            T8 h, T9 i, T10 j, T11 k, T12 l)
        {
            return _bind.Bind(action, a, b, c, d, e, f, g, h, i, j, k, l);
        }

        public System.Action Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m)
        {
            return _bind.Bind(action, a, b, c, d, e, f, g, h, i, j, k, l, m);
        }

        public System.Action Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n)
        {
            return _bind.Bind(action, a, b, c, d, e, f, g, h, i, j, k, l, m, n);
        }

        public System.Action Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n, T15 o)
        {
            return _bind.Bind(action, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
        }

        public System.Action Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n, T15 o, T16 p)
        {
            return _bind.Bind(action, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
        }

        public Action<T2> Partial<T1, T2>(Action<T1, T2> action, T1 a)
        {
            return _partial.Partial(action, a);
        }

        public Action<T2, T3> Partial<T1, T2, T3>(Action<T1, T2, T3> action, T1 a)
        {
            return _partial.Partial(action, a);
        }

        public Action<T3> Partial<T1, T2, T3>(Action<T1, T2, T3> action, T1 a, T2 b)
        {
            return _partial.Partial(action, a, b);
        }

        public Action<T2, T3, T4> Partial<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 a)
        {
            return _partial.Partial(action, a);
        }

        public Action<T3, T4> Partial<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 a, T2 b)
        {
            return _partial.Partial(action, a, b);
        }

        public Action<T4> Partial<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(action, a, b, c);
        }

        public Action<T2, T3, T4, T5> Partial<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 a)
        {
            return _partial.Partial(action, a);
        }

        public Action<T3, T4, T5> Partial<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 a, T2 b)
        {
            return _partial.Partial(action, a, b);
        }

        public Action<T4, T5> Partial<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(action, a, b, c);
        }

        public Action<T5> Partial<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 a, T2 b, T3 c, T4 d)
        {
            return _partial.Partial(action, a, b, c, d);
        }

        public Action<T2, T3, T4, T5, T6> Partial<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 a)
        {
            return _partial.Partial(action, a);
        }

        public Action<T3, T4, T5, T6> Partial<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 a, T2 b)
        {
            return _partial.Partial(action, a, b);
        }

        public Action<T4, T5, T6> Partial<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 a, T2 b,
            T3 c)
        {
            return _partial.Partial(action, a, b, c);
        }

        public Action<T5, T6> Partial<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 a, T2 b, T3 c,
            T4 d)
        {
            return _partial.Partial(action, a, b, c, d);
        }

        public Action<T6> Partial<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 a, T2 b, T3 c, T4 d,
            T5 e)
        {
            return _partial.Partial(action, a, b, c, d, e);
        }

        public Action<T2, T3, T4, T5, T6, T7> Partial<T1, T2, T3, T4, T5, T6, T7>(
            Action<T1, T2, T3, T4, T5, T6, T7> action, T1 a)
        {
            return _partial.Partial(action, a);
        }

        public Action<T3, T4, T5, T6, T7> Partial<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action,
            T1 a, T2 b)
        {
            return _partial.Partial(action, a, b);
        }

        public Action<T4, T5, T6, T7> Partial<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action,
            T1 a, T2 b, T3 c)
        {
            return _partial.Partial(action, a, b, c);
        }

        public Action<T5, T6, T7> Partial<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 a,
            T2 b, T3 c, T4 d)
        {
            return _partial.Partial(action, a, b, c, d);
        }

        public Action<T6, T7> Partial<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 a, T2 b,
            T3 c, T4 d, T5 e)
        {
            return _partial.Partial(action, a, b, c, d, e);
        }

        public Action<T7> Partial<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 a, T2 b,
            T3 c, T4 d, T5 e, T6 f)
        {
            return _partial.Partial(action, a, b, c, d, e, f);
        }

        public Action<T2, T3, T4, T5, T6, T7, T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 a)
        {
            return _partial.Partial(action, a);
        }

        public Action<T3, T4, T5, T6, T7, T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 a, T2 b)
        {
            return _partial.Partial(action, a, b);
        }

        public Action<T4, T5, T6, T7, T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(action, a, b, c);
        }

        public Action<T5, T6, T7, T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 a, T2 b, T3 c, T4 d)
        {
            return _partial.Partial(action, a, b, c, d);
        }

        public Action<T6, T7, T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action,
            T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _partial.Partial(action, a, b, c, d, e);
        }

        public Action<T7, T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action,
            T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
        {
            return _partial.Partial(action, a, b, c, d, e, f);
        }

        public Action<T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 a,
            T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g);
        }

        public Action<T2, T3, T4, T5, T6, T7, T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 a)
        {
            return _partial.Partial(action, a);
        }

        public Action<T3, T4, T5, T6, T7, T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 a, T2 b)
        {
            return _partial.Partial(action, a, b);
        }

        public Action<T4, T5, T6, T7, T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(action, a, b, c);
        }

        public Action<T5, T6, T7, T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 a, T2 b, T3 c, T4 d)
        {
            return _partial.Partial(action, a, b, c, d);
        }

        public Action<T6, T7, T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _partial.Partial(action, a, b, c, d, e);
        }

        public Action<T7, T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
        {
            return _partial.Partial(action, a, b, c, d, e, f);
        }

        public Action<T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g);
        }

        public Action<T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action,
            T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h);
        }

        public Action<T2, T3, T4, T5, T6, T7, T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 a)
        {
            return _partial.Partial(action, a);
        }

        public Action<T3, T4, T5, T6, T7, T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 a, T2 b)
        {
            return _partial.Partial(action, a, b);
        }

        public Action<T4, T5, T6, T7, T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(action, a, b, c);
        }

        public Action<T5, T6, T7, T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 a, T2 b, T3 c, T4 d)
        {
            return _partial.Partial(action, a, b, c, d);
        }

        public Action<T6, T7, T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _partial.Partial(action, a, b, c, d, e);
        }

        public Action<T7, T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
        {
            return _partial.Partial(action, a, b, c, d, e, f);
        }

        public Action<T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g);
        }

        public Action<T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h);
        }

        public Action<T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h,
            T9 i)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h, i);
        }

        public Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a)
        {
            return _partial.Partial(action, a);
        }

        public Action<T3, T4, T5, T6, T7, T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a, T2 b)
        {
            return _partial.Partial(action, a, b);
        }

        public Action<T4, T5, T6, T7, T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(action, a, b, c);
        }

        public Action<T5, T6, T7, T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a, T2 b, T3 c, T4 d)
        {
            return _partial.Partial(action, a, b, c, d);
        }

        public Action<T6, T7, T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _partial.Partial(action, a, b, c, d, e);
        }

        public Action<T7, T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
        {
            return _partial.Partial(action, a, b, c, d, e, f);
        }

        public Action<T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g);
        }

        public Action<T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g,
            T8 h)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h);
        }

        public Action<T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g,
            T8 h, T9 i)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h, i);
        }

        public Action<T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g,
            T8 h, T9 i, T10 j)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h, i, j);
        }

        public Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a)
        {
            return _partial.Partial(action, a);
        }

        public Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b)
        {
            return _partial.Partial(action, a, b);
        }

        public Action<T4, T5, T6, T7, T8, T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(action, a, b, c);
        }

        public Action<T5, T6, T7, T8, T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b, T3 c, T4 d)
        {
            return _partial.Partial(action, a, b, c, d);
        }

        public Action<T6, T7, T8, T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _partial.Partial(action, a, b, c, d, e);
        }

        public Action<T7, T8, T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
        {
            return _partial.Partial(action, a, b, c, d, e, f);
        }

        public Action<T8, T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g);
        }

        public Action<T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g, T8 h)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h);
        }

        public Action<T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g, T8 h, T9 i)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h, i);
        }

        public Action<T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g, T8 h, T9 i, T10 j)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h, i, j);
        }

        public Action<T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g, T8 h, T9 i, T10 j, T11 k)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h, i, j, k);
        }

        public Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a)
        {
            return _partial.Partial(action, a);
        }

        public Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b)
        {
            return _partial.Partial(action, a, b);
        }

        public Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(action, a, b, c);
        }

        public Action<T5, T6, T7, T8, T9, T10, T11, T12, T13> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c, T4 d)
        {
            return _partial.Partial(action, a, b, c, d);
        }

        public Action<T6, T7, T8, T9, T10, T11, T12, T13> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _partial.Partial(action, a, b, c, d, e);
        }

        public Action<T7, T8, T9, T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
        {
            return _partial.Partial(action, a, b, c, d, e, f);
        }

        public Action<T8, T9, T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g);
        }

        public Action<T9, T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g, T8 h)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h);
        }

        public Action<T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g, T8 h, T9 i)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h, i);
        }

        public Action<T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g, T8 h, T9 i, T10 j)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h, i, j);
        }

        public Action<T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g, T8 h, T9 i, T10 j, T11 k)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h, i, j, k);
        }

        public Action<T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g, T8 h, T9 i, T10 j, T11 k, T12 l)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h, i, j, k, l);
        }

        public Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a)
        {
            return _partial.Partial(action, a);
        }

        public Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b)
        {
            return _partial.Partial(action, a, b);
        }

        public Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(action, a, b, c);
        }

        public Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d)
        {
            return _partial.Partial(action, a, b, c, d);
        }

        public Action<T6, T7, T8, T9, T10, T11, T12, T13, T14> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _partial.Partial(action, a, b, c, d, e);
        }

        public Action<T7, T8, T9, T10, T11, T12, T13, T14> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f)
        {
            return _partial.Partial(action, a, b, c, d, e, f);
        }

        public Action<T8, T9, T10, T11, T12, T13, T14> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f, T7 g)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g);
        }

        public Action<T9, T10, T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f, T7 g, T8 h)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h);
        }

        public Action<T10, T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f, T7 g, T8 h, T9 i)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h, i);
        }

        public Action<T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f, T7 g, T8 h, T9 i, T10 j)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h, i, j);
        }

        public Action<T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f, T7 g, T8 h, T9 i, T10 j, T11 k)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h, i, j, k);
        }

        public Action<T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h, i, j, k, l);
        }

        public Action<T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h, i, j, k, l, m);
        }

        public Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a)
        {
            return _partial.Partial(action, a);
        }

        public Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b)
        {
            return _partial.Partial(action, a, b);
        }

        public Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(action, a, b, c);
        }

        public Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d)
        {
            return _partial.Partial(action, a, b, c, d);
        }

        public Action<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d,
            T5 e)
        {
            return _partial.Partial(action, a, b, c, d, e);
        }

        public Action<T7, T8, T9, T10, T11, T12, T13, T14, T15> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f)
        {
            return _partial.Partial(action, a, b, c, d, e, f);
        }

        public Action<T8, T9, T10, T11, T12, T13, T14, T15> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g);
        }

        public Action<T9, T10, T11, T12, T13, T14, T15> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h);
        }

        public Action<T10, T11, T12, T13, T14, T15> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h, i);
        }

        public Action<T11, T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
            (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d,
                T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h, i, j);
        }

        public Action<T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h, i, j, k);
        }

        public Action<T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h, i, j, k, l);
        }

        public Action<T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h, i, j, k, l, m);
        }

        public Action<T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h, i, j, k, l, m, n);
        }

        public Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a)
        {
            return _partial.Partial(action, a);
        }

        public Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b)
        {
            return _partial.Partial(action, a, b);
        }

        public Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(action, a, b, c);
        }

        public Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c,
            T4 d)
        {
            return _partial.Partial(action, a, b, c, d);
        }

        public Action<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c,
            T4 d, T5 e)
        {
            return _partial.Partial(action, a, b, c, d, e);
        }

        public Action<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f)
        {
            return _partial.Partial(action, a, b, c, d, e, f);
        }

        public Action<T8, T9, T10, T11, T12, T13, T14, T15, T16> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g);
        }

        public Action<T9, T10, T11, T12, T13, T14, T15, T16> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g, T8 h)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h);
        }

        public Action<T10, T11, T12, T13, T14, T15, T16> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h, i);
        }

        public Action<T11, T12, T13, T14, T15, T16> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h, i, j);
        }

        public Action<T12, T13, T14, T15, T16> Partial
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h, i, j, k);
        }

        public Action<T13, T14, T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
            (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c,
                T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h, i, j, k, l);
        }

        public Action<T14, T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h, i, j, k, l, m);
        }

        public Action<T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h, i, j, k, l, m, n);
        }

        public Action<T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n, T15 o)
        {
            return _partial.Partial(action, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
        }
    }
}
