using System;

namespace Underscore.Action
{
    public partial interface IBindComponent
    {
        /// <summary>
        ///  Creates a new action from the passed action being bound to the passed parameters
        /// </summary>
		System.Action Bind<T1>(Action<T1> action, T1 a);

        /// <summary>
        ///  Creates a new action from the passed action being bound to the passed parameters
        /// </summary>
        System.Action Bind<T1, T2>(Action<T1, T2> action, T1 a, T2 b);

        /// <summary>
        ///  Creates a new action from the passed action being bound to the passed parameters
        /// </summary>
        System.Action Bind<T1, T2, T3>(Action<T1, T2, T3> action, T1 a, T2 b, T3 c);

        /// <summary>
        ///  Creates a new action from the passed action being bound to the passed parameters
        /// </summary>
        System.Action Bind<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 a, T2 b, T3 c, T4 d);

        /// <summary>
        ///  Creates a new action from the passed action being bound to the passed parameters
        /// </summary>
        System.Action Bind<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 a, T2 b, T3 c, T4 d, T5 e);

        /// <summary>
        ///  Creates a new action from the passed action being bound to the passed parameters
        /// </summary>
        System.Action Bind<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f);

        /// <summary>
        ///  Creates a new action from the passed action being bound to the passed parameters
        /// </summary>
        System.Action Bind<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g);

        /// <summary>
        ///  Creates a new action from the passed action being bound to the passed parameters
        /// </summary>
        System.Action Bind<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h);

        /// <summary>
        ///  Creates a new action from the passed action being bound to the passed parameters
        /// </summary>
        System.Action Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i);

        /// <summary>
        ///  Creates a new action from the passed action being bound to the passed parameters
        /// </summary>
        System.Action Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j);

        /// <summary>
        ///  Creates a new action from the passed action being bound to the passed parameters
        /// </summary>
        System.Action Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k);

        /// <summary>
        ///  Creates a new action from the passed action being bound to the passed parameters
        /// </summary>
        System.Action Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l);

        /// <summary>
        ///  Creates a new action from the passed action being bound to the passed parameters
        /// </summary>
        System.Action Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m);

        /// <summary>
        ///  Creates a new action from the passed action being bound to the passed parameters
        /// </summary>
        System.Action Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n);

        /// <summary>
        ///  Creates a new action from the passed action being bound to the passed parameters
        /// </summary>
        System.Action Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n, T15 o);

        /// <summary>
        ///  Creates a new action from the passed action being bound to the passed parameters
        /// </summary>
        System.Action Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n, T15 o, T16 p);
    }
}
