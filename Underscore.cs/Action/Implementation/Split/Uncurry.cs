using System;

namespace Underscore.Action
{
    public partial class SplitComponent : ISplitComponent
    {
        public Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Action<T15>>>>>>>>>>>>>>>> action)
        {
            return
                (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => action(a)(b)(c)(d)(e)(f)(g)(h)(i)(j)(k)(l)(m)(n)(o)(p);
        }

        public Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Action<T14>>>>>>>>>>>>>>> action)
        {
            return
                (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => action(a)(b)(c)(d)(e)(f)(g)(h)(i)(j)(k)(l)(m)(n)(o);
        }

        public Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Action<T13>>>>>>>>>>>>>> action)
        {
            return
                (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => action(a)(b)(c)(d)(e)(f)(g)(h)(i)(j)(k)(l)(m)(n);
        }

        public Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Action<T12>>>>>>>>>>>>> action)
        {
            return
                (a, b, c, d, e, f, g, h, i, j, k, l, m) => action(a)(b)(c)(d)(e)(f)(g)(h)(i)(j)(k)(l)(m);
        }

        public Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Action<T11>>>>>>>>>>>> action)
        {
            return
                (a, b, c, d, e, f, g, h, i, j, k, l) => action(a)(b)(c)(d)(e)(f)(g)(h)(i)(j)(k)(l);
        }

        public Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Action<T10>>>>>>>>>>> action)
        {
            return
                (a, b, c, d, e, f, g, h, i, j, k) => action(a)(b)(c)(d)(e)(f)(g)(h)(i)(j)(k);
        }

        public Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Action<T9>>>>>>>>>> action)
        {
            return
                (a, b, c, d, e, f, g, h, i, j) => action(a)(b)(c)(d)(e)(f)(g)(h)(i)(j);
        }

        public Action<T0, T1, T2, T3, T4, T5, T6, T7, T8> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Action<T8>>>>>>>>> action)
        {
            return
                (a, b, c, d, e, f, g, h, i) => action(a)(b)(c)(d)(e)(f)(g)(h)(i);
        }

        public Action<T0, T1, T2, T3, T4, T5, T6, T7> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Action<T7>>>>>>>> action)
        {
            return
                (a, b, c, d, e, f, g, h) => action(a)(b)(c)(d)(e)(f)(g)(h);
        }

        public Action<T0, T1, T2, T3, T4, T5, T6> Uncurry<T0, T1, T2, T3, T4, T5, T6>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Action<T6>>>>>>> action)
        {
            return
                (a, b, c, d, e, f, g) => action(a)(b)(c)(d)(e)(f)(g);
        }

        public Action<T0, T1, T2, T3, T4, T5> Uncurry<T0, T1, T2, T3, T4, T5>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Action<T5>>>>>> action)
        {
            return
                (a, b, c, d, e, f) => action(a)(b)(c)(d)(e)(f);
        }

        public Action<T0, T1, T2, T3, T4> Uncurry<T0, T1, T2, T3, T4>(Func<T0, Func<T1, Func<T2, Func<T3, Action<T4>>>>> action)
        {
            return
                (a, b, c, d, e) => action(a)(b)(c)(d)(e);
        }

        public Action<T0, T1, T2, T3> Uncurry<T0, T1, T2, T3>(Func<T0, Func<T1, Func<T2, Action<T3>>>> action)
        {
            return
                (a, b, c, d) => action(a)(b)(c)(d);
        }

        public Action<T0, T1, T2> Uncurry<T0, T1, T2>(Func<T0, Func<T1, Action<T2>>> action)
        {
            return
                (a, b, c) => action(a)(b)(c);
        }

        public Action<T0, T1> Uncurry<T0, T1>(Func<T0, Action<T1>> action)
        {
            return
                (a, b) => action(a)(b);
        }
    }
}
