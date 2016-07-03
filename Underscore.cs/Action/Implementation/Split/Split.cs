using System;

namespace Underscore.Action
{
    public partial class SplitComponent : ISplitComponent
    {
        /// <summary>
        /// Halves the passed action as function that returns action that can invoke the passed action
        /// </summary>
        public Func<T0, Action<T1>> Split<T0, T1>(Action<T0, T1> action)
        {
            return
                (a) =>
                    (b) =>
                        action(a, b);
        }

        /// <summary>
        /// Halves the passed action as function that returns action that can invoke the passed action
        /// </summary>
        public Func<T0, T1, Action<T2, T3>> Split<T0, T1, T2, T3>(Action<T0, T1, T2, T3> action)
        {
            return
                (a, b) =>
                    (c, d) =>
                        action(a, b, c, d);
        }

        /// <summary>
		/// Halves the passed action as function that returns action that can invoke the passed action
		/// </summary>
		public Func<T0, T1, T2, Action<T3, T4, T5>> Split<T0, T1, T2, T3, T4, T5>(Action<T0, T1, T2, T3, T4, T5> action)
        {
            return
                (a, b, c) =>
                    (d, e, f) =>
                        action(a, b, c, d, e, f);
        }

        /// <summary>
        /// Halves the passed action as function that returns action that can invoke the passed action
        /// </summary>
        public Func<T0, T1, T2, T3, Action<T4, T5, T6, T7>> Split<T0, T1, T2, T3, T4, T5, T6, T7>(Action<T0, T1, T2, T3, T4, T5, T6, T7> action)
        {
            return
                (a, b, c, d) =>
                    (e, f, g, h) =>
                        action(a, b, c, d, e, f, g, h);
        }

        /// <summary>
        /// Halves the passed action as function that returns action that can invoke the passed action
        /// </summary>
        public Func<T0, T1, T2, T3, T4, Action<T5, T6, T7, T8, T9>> Split<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> action)
	    {
		    return
			    (a, b, c, d, e) =>
				    (f, g, h, i, j) =>
					    action(a, b, c, d, e, f, g, h, i, j);
	    }

        /// <summary>
        /// Halves the passed action as function that returns action that can invoke the passed action
        /// </summary>
        public Func<T0, T1, T2, T3, T4, T5, Action<T6, T7, T8, T9, T10, T11>> Split<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action)
        {
            return
                (a, b, c, d, e, f) =>
                    (g, h, i, j, k, l) =>
                        action(a, b, c, d, e, f, g, h, i, j, k, l);
        }		

        /// <summary>
        /// Halves the passed action as function that returns action that can invoke the passed action
        /// </summary>
        public Func<T0, T1, T2, T3, T4, T5, T6, Action<T7, T8, T9, T10, T11, T12, T13>> Split<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action)
        {
            return
                (a, b, c, d, e, f, g) =>
                    (h, i, j, k, l, m, n) =>
                        action(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
        }

        /// <summary>
        /// Halves the passed action as function that returns action that can invoke the passed action
        /// </summary>
        public Func<T0, T1, T2, T3, T4, T5, T6, T7, Action<T8, T9, T10, T11, T12, T13, T14, T15>> Split<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action)
        {
            return
                (a, b, c, d, e, f, g, h) =>
                    (i, j, k, l, m, n, o, p) =>
                        action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
        }
    }
}
