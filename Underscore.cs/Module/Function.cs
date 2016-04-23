using System;
using System.Threading.Tasks;
using Underscore.Function;

namespace Underscore.Module
{


    public class Function : 
        ISplitComponent, 
        IPartialComponent,
        IBindComponent,
        IComposeComponent,
        ISynchComponent,
        IConvertComponent,
        ICacheComponent,
        IBooleanComponent
    {

        private readonly IComposeComponent _compose;
        private readonly IBindComponent _bind;
        private readonly IPartialComponent _partial;
        private readonly ISplitComponent _split;
        private readonly IConvertComponent _convert;
        private readonly ISynchComponent _synch;
        private readonly ICacheComponent _cache;
        private readonly IBooleanComponent _booleanComponent;

        public Function( 
            IBindComponent bind, 
            IPartialComponent partial,
            ISplitComponent split,
            IComposeComponent compose,
            IConvertComponent convert,
            ISynchComponent synch,
            ICacheComponent cache,
            IBooleanComponent boolComponent) 
        {
            if (bind == null)
                throw new ArgumentNullException("bind");

            if (partial == null)
                throw new ArgumentNullException("partial");

            if (split == null)
                throw new ArgumentNullException("split");

            if (compose == null)
                throw new ArgumentNullException("compose");


            if (convert == null)
                throw new ArgumentNullException("convert");

            if (synch == null)
                throw new ArgumentNullException("synch");

            if (cache == null)
                throw new ArgumentNullException("cache");

            if (boolComponent == null)
                throw new ArgumentNullException("boolComponent");

            _bind = bind;
            _partial = partial;
            _split = split;
            _compose = compose;
            _synch = synch;
            _convert = convert;
            _cache = cache;
            _booleanComponent = boolComponent;
        }


        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _partial.Partial(function, a, b, c, d, e);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T2, T3, T4, T5, T6, T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 a)
        {
            return _partial.Partial(function, a);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T3, T4, T5, T6, T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 a, T2 b)
        {
            return _partial.Partial(function, a, b);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T4, T5, T6, T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(function, a, b, c);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T5, T6, T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 a, T2 b, T3 c, T4 d)
        {
            return _partial.Partial(function, a, b, c, d);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T6, T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _partial.Partial(function, a, b, c, d, e);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
        {
            return _partial.Partial(function, a, b, c, d, e, f);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T2, T3, T4, T5, T6, T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a)
        {
            return _partial.Partial(function, a);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T3, T4, T5, T6, T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a, T2 b)
        {
            return _partial.Partial(function, a, b);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T4, T5, T6, T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(function, a, b, c);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T5, T6, T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a, T2 b, T3 c, T4 d)
        {
            return _partial.Partial(function, a, b, c, d);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T6, T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _partial.Partial(function, a, b, c, d, e);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
        {
            return _partial.Partial(function, a, b, c, d, e, f);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T2, T3, T4, T5, T6, T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a)
        {
            return _partial.Partial(function, a);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T3, T4, T5, T6, T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b)
        {
            return _partial.Partial(function, a, b);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T4, T5, T6, T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(function, a, b, c);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T5, T6, T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b, T3 c, T4 d)
        {
            return _partial.Partial(function, a, b, c, d);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T6, T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _partial.Partial(function, a, b, c, d, e);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
        {
            return _partial.Partial(function, a, b, c, d, e, f);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a)
        {
            return _partial.Partial(function, a);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T3, T4, T5, T6, T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b)
        {
            return _partial.Partial(function, a, b);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T4, T5, T6, T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(function, a, b, c);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T5, T6, T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c, T4 d)
        {
            return _partial.Partial(function, a, b, c, d);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T6, T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _partial.Partial(function, a, b, c, d, e);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
        {
            return _partial.Partial(function, a, b, c, d, e, f);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g,
            T8 h)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g,
            T8 h, T9 i)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a)
        {
            return _partial.Partial(function, a);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b)
        {
            return _partial.Partial(function, a, b);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T4, T5, T6, T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(function, a, b, c);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T5, T6, T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d)
        {
            return _partial.Partial(function, a, b, c, d);
        }


        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T6, T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _partial.Partial(function, a, b, c, d, e);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
        {
            return _partial.Partial(function, a, b, c, d, e, f);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g, T8 h)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g, T8 h, T9 i)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g, T8 h, T9 i, T10 j)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a)
        {
            return _partial.Partial(function, a);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b)
        {
            return _partial.Partial(function, a, b);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(function, a, b, c);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T5, T6, T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d)
        {
            return _partial.Partial(function, a, b, c, d);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T6, T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _partial.Partial(function, a, b, c, d, e);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f)
        {
            return _partial.Partial(function, a, b, c, d, e, f);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f, T7 g)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f, T7 g, T8 h)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f, T7 g, T8 h, T9 i)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f, T7 g, T8 h, T9 i, T10 j)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f, T7 g, T8 h, T9 i, T10 j, T11 k)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j, k);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a)
        {
            return _partial.Partial(function, a);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b)
        {
            return _partial.Partial(function, a, b);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(function, a, b, c);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d)
        {
            return _partial.Partial(function, a, b, c, d);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T6, T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e)
        {
            return _partial.Partial(function, a, b, c, d, e);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f)
        {
            return _partial.Partial(function, a, b, c, d, e, f);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j, k);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j, k, l);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a)
        {
            return _partial.Partial(function, a);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b)
        {
            return _partial.Partial(function, a, b);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(function, a, b, c);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d)
        {
            return _partial.Partial(function, a, b, c, d);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e)
        {
            return _partial.Partial(function, a, b, c, d, e);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f)
        {
            return _partial.Partial(function, a, b, c, d, e, f);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j, k);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j, k, l);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j, k, l, m);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a)
        {
            return _partial.Partial(function, a);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b)
        {
            return _partial.Partial(function, a, b);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(function, a, b, c);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c,
            T4 d)
        {
            return _partial.Partial(function, a, b, c, d);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c,
            T4 d, T5 e)
        {
            return _partial.Partial(function, a, b, c, d, e);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f)
        {
            return _partial.Partial(function, a, b, c, d, e, f);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g, T8 h)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j, k);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j, k, l);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j, k, l, m);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j, k, l, m, n);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a)
        {
            return _partial.Partial(function, a);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b)
        {
            return _partial.Partial(function, a, b);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b,
            T3 c)
        {
            return _partial.Partial(function, a, b, c);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b,
            T3 c, T4 d)
        {
            return _partial.Partial(function, a, b, c, d);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b,
            T3 c, T4 d, T5 e)
        {
            return _partial.Partial(function, a, b, c, d, e);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b,
            T3 c, T4 d, T5 e, T6 f)
        {
            return _partial.Partial(function, a, b, c, d, e, f);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b,
            T3 c, T4 d, T5 e, T6 f, T7 g)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b,
            T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b,
            T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b,
            T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b,
            T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j, k);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b,
            T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j, k, l);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b,
            T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j, k, l, m);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b,
            T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j, k, l, m, n);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b,
            T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n, T15 o)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, T1 a, T2 b, T3 c, T4 d)
        {
            return _partial.Partial(function, a, b, c, d);
        }

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T2, T3, T4, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 a)
        {
            return _partial.Partial(function, a);
        }


        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T3, T4, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 a, T2 b)
        {
            return _partial.Partial(function, a, b);
        }


        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T4, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(function, a, b, c);
        }


        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 a, T2 b, T3 c, T4 d)
        {
            return _partial.Partial(function, a, b, c, d);
        }


        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T2, TResult> Partial<T1, T2, TResult>(Func<T1, T2, TResult> function, T1 a)
        {
            return _partial.Partial(function, a);
        }


        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T2, T3, TResult> Partial<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, T1 a)
        {
            return _partial.Partial(function, a);
        }


        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T3, TResult> Partial<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, T1 a, T2 b)
        {
            return _partial.Partial(function, a, b);
        }


        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T2, T3, T4, TResult> Partial<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, T1 a)
        {
            return _partial.Partial(function, a);
        }


        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T3, T4, TResult> Partial<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, T1 a, T2 b)
        {
            return _partial.Partial(function, a, b);
        }


        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T4, TResult> Partial<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(function, a, b, c);
        }


        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T2, T3, T4, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, T1 a)
        {
            return _partial.Partial(function, a);
        }


        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T3, T4, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, T1 a, T2 b)
        {
            return _partial.Partial(function, a, b);
        }


        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
        public Func<T4, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(function, a, b, c);
        }



        /// <summary>
        ///  Creates a new Function bound to the passed parameter
        /// </summary>
        public Func<TResult> Bind<T1, TResult>(Func<T1, TResult> function, T1 a)
        {
            return _bind.Bind(function, a);
        }

        /// <summary>
        ///  Creates a new Function bound to the passed parameter
        /// </summary>
        public Func<TResult> Bind<T1, T2, TResult>(Func<T1, T2, TResult> function, T1 a, T2 b)
        {
            return _bind.Bind(function, a, b);
        }

        /// <summary>
        ///  Creates a new Function bound to the passed parameter
        /// </summary>
        public Func<TResult> Bind<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, T1 a, T2 b, T3 c)
        {
            return _bind.Bind(function, a, b, c);
        }

        /// <summary>
        ///  Creates a new Function bound to the passed parameter
        /// </summary>
        public Func<TResult> Bind<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, T1 a, T2 b, T3 c, T4 d)
        {
            return _bind.Bind(function, a, b, c, d);
        }

        /// <summary>
        ///  Creates a new Function bound to the passed parameter
        /// </summary>
        public Func<TResult> Bind<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _bind.Bind(function, a, b, c, d, e);
        }

        /// <summary>
        ///  Creates a new Function bound to the passed parameter
        /// </summary>
        public Func<TResult> Bind<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
        {
            return _bind.Bind(function, a, b, c, d, e, f);
        }

        /// <summary>
        ///  Creates a new Function bound to the passed parameter
        /// </summary>
        public Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
        {
            return _bind.Bind(function, a, b, c, d, e, f, g);
        }

        /// <summary>
        ///  Creates a new Function bound to the passed parameter
        /// </summary>
        public Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
        {
            return _bind.Bind(function, a, b, c, d, e, f, g, h);
        }

        /// <summary>
        ///  Creates a new Function bound to the passed parameter
        /// </summary>
        public Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h,
            T9 i)
        {
            return _bind.Bind(function, a, b, c, d, e, f, g, h, i);
        }

        /// <summary>
        ///  Creates a new Function bound to the passed parameter
        /// </summary>
        public Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g,
            T8 h, T9 i, T10 j)
        {
            return _bind.Bind(function, a, b, c, d, e, f, g, h, i, j);
        }

        /// <summary>
        ///  Creates a new Function bound to the passed parameter
        /// </summary>
        public Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g,
            T8 h, T9 i, T10 j, T11 k)
        {
            return _bind.Bind(function, a, b, c, d, e, f, g, h, i, j, k);
        }

        /// <summary>
        ///  Creates a new Function bound to the passed parameter
        /// </summary>
        public Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g, T8 h, T9 i, T10 j, T11 k, T12 l)
        {
            return _bind.Bind(function, a, b, c, d, e, f, g, h, i, j, k, l);
        }

        /// <summary>
        ///  Creates a new Function bound to the passed parameter
        /// </summary>
        public Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m)
        {
            return _bind.Bind(function, a, b, c, d, e, f, g, h, i, j, k, l, m);
        }

        /// <summary>
        ///  Creates a new Function bound to the passed parameter
        /// </summary>
        public Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n)
        {
            return _bind.Bind(function, a, b, c, d, e, f, g, h, i, j, k, l, m, n);
        }

        /// <summary>
        ///  Creates a new Function bound to the passed parameter
        /// </summary>
        public Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n, T15 o)
        {
            return _bind.Bind(function, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
        }

        /// <summary>
        ///  Creates a new Function bound to the passed parameter
        /// </summary>
        public Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b,
            T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n, T15 o, T16 p)
        {
            return _bind.Bind(function, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
        }

        /// <summary>
        /// Halves the passed action as function that returns action that can invoke the passed action
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>        
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>        
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>        
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T13"></typeparam>        
        /// <typeparam name="T14"></typeparam>
        /// <typeparam name="T15"></typeparam>
        /// <param name="function"></param>
        /// <returns>
        /// a function taking first half of arguments 
        /// that returns an action that takes the other half, 
        /// invocation of returned method would be the same as invoking
        /// the passed action with all parameters from the first function call
        /// and the following action call
        /// </returns>
        public Func<T0, T1, T2, T3, T4, T5, T6, T7, Func<T8, T9, T10, T11, T12, T13, T14, T15, TResult>> Split<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function )
        {
            return _split.Split( function );
        }

        /// <summary>
        /// Halves the passed action as function that returns action that can invoke the passed action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>        
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>        
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <param name="function"></param>
        /// <returns>
        /// a function taking first half of arguments 
        /// that returns an action that takes the other half, 
        /// invocation of returned method would be the same as invoking
        /// the passed action with all parameters from the first function call
        /// and the following action call
        /// </returns>
        public Func<T0, T1, T2, T3, Func<T4, T5, T6, T7, TResult>> Split<T0, T1, T2, T3, T4, T5, T6, T7, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, T7, TResult> function )
        {
            return _split.Split( function );
        }

        /// <summary>
        /// Halves the passed action as function that returns action that can invoke the passed action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <param name="function"></param>
        /// <returns>
        /// a function taking first half of arguments 
        /// that returns an action that takes the other half, 
        /// invocation of returned method would be the same as invoking
        /// the passed action with all parameters from the first function call
        /// and the following action call
        /// </returns>
        public Func<T0, T1, Func<T2, T3, TResult>> Split<T0, T1, T2, T3, TResult>( Func<T0, T1, T2, T3, TResult> function )
        {
            return _split.Split( function );
        }

        /// <summary>
        /// Halves the passed action as function that returns action that can invoke the passed action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="function"></param>
        /// <returns>
        /// a function taking first half of arguments 
        /// that returns an action that takes the other half, 
        /// invocation of returned method would be the same as invoking
        /// the passed action with all parameters from the first function call
        /// and the following action call
        /// </returns>
        public Func<T0, Func<T1, TResult>> Split<T0, T1, TResult>( Func<T0, T1, TResult> function )
        {
            return _split.Split( function );
        }

        /// <summary>
        /// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
        /// each accepting one parameter associated cardinally 
        /// to the passed actions parameters
        /// final call is an action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T14"></typeparam>
        /// <typeparam name="T15"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="function">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TResult>>>>>>>>>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function )
        {
            return _split.Curry( function );
        }
        /// <summary>
        /// Translates a sequence of functions each taking one argument into a single action
        /// </summary>
        public Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TResult>>>>>>>>>>>>>>>> function)
        {
            return _split.Uncurry(function);
        }
        /// <summary>
        /// Translates a sequence of functions each taking one argument into a single action
        /// </summary>
        public Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TResult>>>>>>>>>>>>>>> function)
        {
            return _split.Uncurry(function);
        }
        /// <summary>
        /// Translates a sequence of functions each taking one argument into a single action
        /// </summary>
        public Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TResult>>>>>>>>>>>>>> function)
        {
            return _split.Uncurry(function);
        }
        /// <summary>
        /// Translates a sequence of functions each taking one argument into a single action
        /// </summary>
        public Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TResult>>>>>>>>>>>>> function)
        {
            return _split.Uncurry(function);
        }
        /// <summary>
        /// Translates a sequence of functions each taking one argument into a single action
        /// </summary>
        public Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, TResult>>>>>>>>>>>> function)
        {
            return _split.Uncurry(function);
        }
        /// <summary>
        /// Translates a sequence of functions each taking one argument into a single action
        /// </summary>
        public Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, TResult>>>>>>>>>>> function)
        {
            return _split.Uncurry(function);
        }
        /// <summary>
        /// Translates a sequence of functions each taking one argument into a single action
        /// </summary>
        public Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, TResult>>>>>>>>>> function)
        {
            return _split.Uncurry(function);
        }
        /// <summary>
        /// Translates a sequence of functions each taking one argument into a single action
        /// </summary>
        public Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, TResult> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TResult>>>>>>>>> function)
        {
            return _split.Uncurry(function);
        }
        /// <summary>
        /// Translates a sequence of functions each taking one argument into a single action
        /// </summary>
        public Func<T0, T1, T2, T3, T4, T5, T6, T7, TResult> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TResult>>>>>>>> function)
        {
            return _split.Uncurry(function);
        }
        /// <summary>
        /// Translates a sequence of functions each taking one argument into a single action
        /// </summary>
        public Func<T0, T1, T2, T3, T4, T5, T6, TResult> Uncurry<T0, T1, T2, T3, T4, T5, T6, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TResult>>>>>>> function)
        {
            return _split.Uncurry(function);
        }
        /// <summary>
        /// Translates a sequence of functions each taking one argument into a single action
        /// </summary>
        public Func<T0, T1, T2, T3, T4, T5, TResult> Uncurry<T0, T1, T2, T3, T4, T5, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TResult>>>>>> function)
        {
            return _split.Uncurry(function);
        }
        /// <summary>
        /// Translates a sequence of functions each taking one argument into a single action
        /// </summary>
        public Func<T0, T1, T2, T3, T4, TResult> Uncurry<T0, T1, T2, T3, T4, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, TResult>>>>> function)
        {
            return _split.Uncurry(function);
        }
        /// <summary>
        /// Translates a sequence of functions each taking one argument into a single action
        /// </summary>
        public Func<T0, T1, T2, T3, TResult> Uncurry<T0, T1, T2, T3, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, TResult>>>> function)
        {
            return _split.Uncurry(function);
        }
        /// <summary>
        /// Translates a sequence of functions each taking one argument into a single action
        /// </summary>
        public Func<T0, T1, T2, TResult> Uncurry<T0, T1, T2, TResult>(Func<T0, Func<T1, Func<T2, TResult>>> function)
        {
            return _split.Uncurry(function);
        }

        /// <summary>
        /// Translates a sequence of functions each taking one argument into a single action
        /// </summary>
        public Func<T0, T1, TResult> Uncurry<T0, T1, TResult>(Func<T0, Func<T1, TResult>> function)
        {
            return _split.Uncurry(function);
        }


        /// <summary>
        /// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
        /// each accepting one parameter associated cardinally 
        /// to the passed actions parameters
        /// final call is an action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="function">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TResult>>>>>>>>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function )
        {
            return _split.Curry( function );
        }


        /// <summary>
        /// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
        /// each accepting one parameter associated cardinally 
        /// to the passed actions parameters
        /// final call is an action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <param name="function">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TResult>>>>>>>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function )
        {
            return _split.Curry( function );
        }


        /// <summary>
        /// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
        /// each accepting one parameter associated cardinally 
        /// to the passed actions parameters
        /// final call is an action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="function">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TResult>>>>>>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function )
        {
            return _split.Curry( function );
        }


        /// <summary>
        /// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
        /// each accepting one parameter associated cardinally 
        /// to the passed actions parameters
        /// final call is an action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="function">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, TResult>>>>>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function )
        {
            return _split.Curry( function );
        }


        /// <summary>
        /// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
        /// each accepting one parameter associated cardinally 
        /// to the passed actions parameters
        /// final call is an action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="function">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, TResult>>>>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function )
        {
            return _split.Curry( function );
        }


        /// <summary>
        /// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
        /// each accepting one parameter associated cardinally 
        /// to the passed actions parameters
        /// final call is an action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="function">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, TResult>>>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function )
        {
            return _split.Curry( function );
        }

        /// <summary>
        /// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
        /// each accepting one parameter associated cardinally 
        /// to the passed actions parameters
        /// final call is an action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="function">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TResult>>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, TResult> function )
        {
            return _split.Curry( function );
        }

        /// <summary>
        /// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
        /// each accepting one parameter associated cardinally 
        /// to the passed actions parameters
        /// final call is an action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="function">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TResult>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, T7, TResult> function )
        {
            return _split.Curry( function );
        }

        /// <summary>
        /// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
        /// each accepting one parameter associated cardinally 
        /// to the passed actions parameters
        /// final call is an action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="function">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TResult>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, TResult> function )
        {
            return _split.Curry( function );
        }


        /// <summary>
        /// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
        /// each accepting one parameter associated cardinally 
        /// to the passed actions parameters
        /// final call is an action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="function">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TResult>>>>>> Curry<T0, T1, T2, T3, T4, T5, TResult>( Func<T0, T1, T2, T3, T4, T5, TResult> function )
        {
            return _split.Curry( function );
        }

        /// <summary>
        /// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
        /// each accepting one parameter associated cardinally 
        /// to the passed actions parameters
        /// final call is an action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="function">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, TResult>>>>> Curry<T0, T1, T2, T3, T4, TResult>( Func<T0, T1, T2, T3, T4, TResult> function )
        {
            return _split.Curry( function );
        }


        /// <summary>
        /// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
        /// each accepting one parameter associated cardinally 
        /// to the passed actions parameters
        /// final call is an action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="function">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        public Func<T0, Func<T1, Func<T2, Func<T3, TResult>>>> Curry<T0, T1, T2, T3, TResult>( Func<T0, T1, T2, T3, TResult> function )
        {
            return _split.Curry( function );
        }



        /// <summary>
        /// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
        /// each accepting one parameter associated cardinally 
        /// to the passed actions parameters
        /// final call is an action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="function">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        public Func<T0, Func<T1, Func<T2, TResult>>> Curry<T0, T1, T2, TResult>( Func<T0, T1, T2, TResult> function )
        {
            return _split.Curry( function );
        }

        /// <summary>
        /// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
        /// each accepting one parameter associated cardinally 
        /// to the passed actions parameters
        /// final call is an action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="function">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        public Func<T0, Func<T1, TResult>> Curry<T0, T1, TResult>( Func<T0, T1, TResult> function )
        {
            return _split.Curry( function );
        }

        /// <summary>
        /// Creates a sigle composite function from the passed functions
        /// </summary>
        public Func<TStart, TResult> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TResult>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d,
            Func<TLink5, TLink6> e, Func<TLink6, TResult> end)
        {
            return _compose.Compose(start, a, b, c, d, e, end);
        }

        /// <summary>
        /// Creates a sigle composite function from the passed functions
        /// </summary>
        public Func<TStart, TResult> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TResult>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c,
            Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TResult> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, end);
        }

        /// <summary>
        /// Creates a sigle composite function from the passed functions
        /// </summary>
        public Func<TStart, TResult> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TResult>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b,
            Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TLink8> g, Func<TLink8, TResult> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, g, end);
        }

        /// <summary>
        /// Creates a sigle composite function from the passed functions
        /// </summary>
        public Func<TStart, TResult> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TResult>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a,
            Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TLink8> g, Func<TLink8, TLink9> h, Func<TLink9, TResult> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, g, h, end);
        }

        /// <summary>
        /// Creates a sigle composite function from the passed functions
        /// </summary>
        public Func<TStart, TResult> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TResult>(
            Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TLink8> g, Func<TLink8, TLink9> h, Func<TLink9, TLink10> i, Func<TLink10, TResult> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, g, h, i, end);
        }

        /// <summary>
        /// Creates a sigle composite function from the passed functions
        /// </summary>
        public Func<TStart, TResult> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TResult>(
            Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TLink8> g, Func<TLink8, TLink9> h, Func<TLink9, TLink10> i, Func<TLink10, TLink11> j, Func<TLink11, TResult> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, g, h, i, j, end);
        }

        /// <summary>
        /// Creates a sigle composite function from the passed functions
        /// </summary>
        public Func<TStart, TResult> Compose
            <TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TLink12, TResult>
            (Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TLink8> g, Func<TLink8, TLink9> h, Func<TLink9, TLink10> i, Func<TLink10, TLink11> j, Func<TLink11, TLink12> k, Func<TLink12, TResult> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, g, h, i, j, k, end);
        }

        /// <summary>
        /// Creates a sigle composite function from the passed functions
        /// </summary>
        public Func<TStart, TResult> Compose
            <TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TLink12, TLink13,
                TResult>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TLink8> g, Func<TLink8, TLink9> h, Func<TLink9, TLink10> i, Func<TLink10, TLink11> j, Func<TLink11, TLink12> k,
                    Func<TLink12, TLink13> l, Func<TLink13, TResult> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, g, h, i, j, k, l, end);
        }

        /// <summary>
        /// Creates a sigle composite function from the passed functions
        /// </summary>
        public Func<TStart, TResult> Compose
            <TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TLink12, TLink13,
                TLink14, TResult>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TLink8> g, Func<TLink8, TLink9> h, Func<TLink9, TLink10> i, Func<TLink10, TLink11> j,
                    Func<TLink11, TLink12> k, Func<TLink12, TLink13> l, Func<TLink13, TLink14> m, Func<TLink14, TResult> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, g, h, i, j, k, l, m, end);
        }

        /// <summary>
        /// Creates a sigle composite function from the passed functions
        /// </summary>
        public Func<TStart, TResult> Compose
            <TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TLink12, TLink13,
                TLink14, TLink15, TResult>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TLink8> g, Func<TLink8, TLink9> h, Func<TLink9, TLink10> i,
                    Func<TLink10, TLink11> j, Func<TLink11, TLink12> k, Func<TLink12, TLink13> l, Func<TLink13, TLink14> m, Func<TLink14, TLink15> n, Func<TLink15, TResult> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, g, h, i, j, k, l, m, n, end);
        }

        /// <summary>
        /// Creates a sigle composite function from the passed functions
        /// </summary>
        public Func<TStart, TResult> Compose
            <TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TLink12, TLink13,
                TLink14, TLink15, TLink16, TResult>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TLink8> g, Func<TLink8, TLink9> h,
                    Func<TLink9, TLink10> i, Func<TLink10, TLink11> j, Func<TLink11, TLink12> k, Func<TLink12, TLink13> l, Func<TLink13, TLink14> m, Func<TLink14, TLink15> n, Func<TLink15, TLink16> o, Func<TLink16, TResult> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, end);
        }

        /// <summary>
        /// Creates a sigle composite function from the passed functions
        /// </summary>
        public Func<T, T> Compose<T>( params Func<T, T>[ ] args )
        {
            return _compose.Compose( args );
        }

        /// <summary>
        /// Calls a function using the passed array of arguments
        /// </summary>
        public TResult Apply<T, TResult>( Func<T, T, T, T, T, T, T, T, T, T, T, T, T, T, T, T, TResult> fn, T[ ] arguments )
        {
            return _compose.Apply( fn, arguments );
        }


        /// <summary>
        /// Calls the function passed with the given arguments as the parameters 
        /// </summary>
        public TResult Call<T1, TResult>(Func<T1, TResult> function, T1 a)
        {
            return _compose.Call(function, a);
        }


        /// <summary>
        /// Calls the function passed with the given arguments as the parameters 
        /// </summary>
        public TResult Call<T1, T2, TResult>(Func<T1, T2, TResult> function, T1 a, T2 b)
        {
            return _compose.Call(function, a, b);
        }


        /// <summary>
        /// Calls the function passed with the given arguments as the parameters 
        /// </summary>
        public TResult Call<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, T1 a, T2 b, T3 c)
        {
            return _compose.Call(function, a, b, c);
        }


        /// <summary>
        /// Calls the function passed with the given arguments as the parameters 
        /// </summary>
        public TResult Call<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, T1 a, T2 b, T3 c, T4 d)
        {
            return _compose.Call(function, a, b, c, d);
        }


        /// <summary>
        /// Calls the function passed with the given arguments as the parameters 
        /// </summary>
        public TResult Call<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _compose.Call(function, a, b, c, d, e);
        }


        /// <summary>
        /// Calls the function passed with the given arguments as the parameters 
        /// </summary>
        public TResult Call<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
        {
            return _compose.Call(function, a, b, c, d, e, f);
        }


        /// <summary>
        /// Calls the function passed with the given arguments as the parameters 
        /// </summary>
        public TResult Call<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
        {
            return _compose.Call(function, a, b, c, d, e, f, g);
        }


        /// <summary>
        /// Calls the function passed with the given arguments as the parameters 
        /// </summary>
        public TResult Call<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
        {
            return _compose.Call(function, a, b, c, d, e, f, g, h);
        }


        /// <summary>
        /// Calls the function passed with the given arguments as the parameters 
        /// </summary>
        public TResult Call<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h,
            T9 i)
        {
            return _compose.Call(function, a, b, c, d, e, f, g, h, i);
        }


        /// <summary>
        /// Calls the function passed with the given arguments as the parameters 
        /// </summary>
        public TResult Call<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g,
            T8 h, T9 i, T10 j)
        {
            return _compose.Call(function, a, b, c, d, e, f, g, h, i, j);
        }


        /// <summary>
        /// Calls the function passed with the given arguments as the parameters 
        /// </summary>
        public TResult Call<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g, T8 h, T9 i, T10 j, T11 k)
        {
            return _compose.Call(function, a, b, c, d, e, f, g, h, i, j, k);
        }


        /// <summary>
        /// Calls the function passed with the given arguments as the parameters 
        /// </summary>
        public TResult Call<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l)
        {
            return _compose.Call(function, a, b, c, d, e, f, g, h, i, j, k, l);
        }


        /// <summary>
        /// Calls the function passed with the given arguments as the parameters 
        /// </summary>
        public TResult Call<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m)
        {
            return _compose.Call(function, a, b, c, d, e, f, g, h, i, j, k, l, m);
        }


        /// <summary>
        /// Calls the function passed with the given arguments as the parameters 
        /// </summary>
        public TResult Call<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n)
        {
            return _compose.Call(function, a, b, c, d, e, f, g, h, i, j, k, l, m, n);
        }


        /// <summary>
        /// Calls the function passed with the given arguments as the parameters 
        /// </summary>
        public TResult Call<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n, T15 o)
        {
            return _compose.Call(function, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
        }


        /// <summary>
        /// Calls the function passed with the given arguments as the parameters 
        /// </summary>
        public TResult Call<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b,
            T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n, T15 o, T16 p)
        {
            return _compose.Call(function, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
        }

        /// <summary>
        /// Calls a function using the passed array of arguments
        /// </summary>
        public TResult Apply<T, TResult>( Func<T, T, T, T, T, T, T, T, T, T, T, T, T, T, T, TResult> fn, T[ ] arguments )
        {
            return _compose.Apply( fn, arguments );
        }

        /// <summary>
        /// Calls a function using the passed array of arguments
        /// </summary>
        public TResult Apply<T, TResult>( Func<T, T, T, T, T, T, T, T, T, T, T, T, T, T, TResult> fn, T[ ] arguments )
        {
            return _compose.Apply( fn, arguments );
        }

        /// <summary>
        /// Calls a function using the passed array of arguments
        /// </summary>
        public TResult Apply<T, TResult>( Func<T, T, T, T, T, T, T, T, T, T, T, T, T, TResult> fn, T[ ] arguments )
        {
            return _compose.Apply( fn, arguments );
        }

        /// <summary>
        /// Calls a function using the passed array of arguments
        /// </summary>
        public TResult Apply<T, TResult>( Func<T, T, T, T, T, T, T, T, T, T, T, T, TResult> fn, T[ ] arguments )
        {
            return _compose.Apply( fn, arguments );
        }

        /// <summary>
        /// Calls a function using the passed array of arguments
        /// </summary>
        public TResult Apply<T, TResult>( Func<T, T, T, T, T, T, T, T, T, T, T, TResult> fn, T[ ] arguments )
        {
            return _compose.Apply( fn, arguments );
        }

        /// <summary>
        /// Calls a function using the passed array of arguments
        /// </summary>
        public TResult Apply<T, TResult>( Func<T, T, T, T, T, T, T, T, T, T, TResult> fn, T[ ] arguments )
        {
            return _compose.Apply( fn, arguments );
        }

        /// <summary>
        /// Calls a function using the passed array of arguments
        /// </summary>
        public TResult Apply<T, TResult>( Func<T, T, T, T, T, T, T, T, T, TResult> fn, T[ ] arguments )
        {
            return _compose.Apply( fn, arguments );
        }

        /// <summary>
        /// Calls a function using the passed array of arguments
        /// </summary>
        public TResult Apply<T, TResult>( Func<T, T, T, T, T, T, T, T, TResult> fn, T[ ] arguments )
        {
            return _compose.Apply( fn, arguments );
        }

        /// <summary>
        /// Calls a function using the passed array of arguments
        /// </summary>
        public TResult Apply<T, TResult>( Func<T, T, T, T, T, T, T, TResult> fn, T[ ] arguments )
        {
            return _compose.Apply( fn, arguments );
        }

        /// <summary>
        /// Calls a function using the passed array of arguments
        /// </summary>
        public TResult Apply<T, TResult>( Func<T, T, T, T, T, T, TResult> fn, T[ ] arguments )
        {
            return _compose.Apply( fn, arguments );
        }

        /// <summary>
        /// Calls a function using the passed array of arguments
        /// </summary>
        public TResult Apply<T, TResult>( Func<T, T, T, T, T, TResult> fn, T[ ] arguments )
        {
            return _compose.Apply( fn, arguments );
        }

        /// <summary>
        /// Calls a function using the passed array of arguments
        /// </summary>
        public TResult Apply<T, TResult>( Func<T, T, T, T, TResult> fn, T[ ] arguments )
        {
            return _compose.Apply( fn, arguments );
        }

        /// <summary>
        /// Calls a function using the passed array of arguments
        /// </summary>
        public TResult Apply<T, TResult>( Func<T, T, T, TResult> fn, T[ ] arguments )
        {
            return _compose.Apply( fn, arguments );
        }

        /// <summary>
        /// Calls a function using the passed array of arguments
        /// </summary>
        public TResult Apply<T, TResult>( Func<T, T, TResult> fn, T[ ] arguments )
        {
            return _compose.Apply( fn, arguments );
        }

        /// <summary>
        /// Calls a function using the passed array of arguments
        /// </summary>
        public TResult Apply<T, TResult>( Func<T, TResult> fn, T[ ] arguments )
        {
            return _compose.Apply( fn, arguments );
        }

        /// <summary>
        /// Creates a sigle composite function from the passed functions
        /// </summary>
        public Func<TStart, TResult> Compose<TStart, TMid, TResult>(Func<TStart, TMid> start, Func<TMid, TResult> end)
        {
            return _compose.Compose(start, end);
        }

        /// <summary>
        /// Creates a sigle composite function from the passed functions
        /// </summary>
        public Func<TStart, TResult> Compose<TStart, TLink1, TLink2, TResult>(Func<TStart, TLink1> start, Func<TLink1, TLink2> mid, Func<TLink2, TResult> end)
        {
            return _compose.Compose(start, mid, end);
        }

        /// <summary>
        /// Creates a sigle composite function from the passed functions
        /// </summary>
        public Func<TStart, TResult> Compose<TStart, TLink1, TLink2, TLink3, TResult>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TResult> end)
        {
            return _compose.Compose(start, a, b, end);
        }

        /// <summary>
        /// Creates a sigle composite function from the passed functions
        /// </summary>
        public Func<TStart, TResult> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TResult>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TResult> end)
        {
            return _compose.Compose(start, a, b, c, end);
        }

        /// <summary>
        /// Creates a sigle composite function from the passed functions
        /// </summary>
        public Func<TStart, TResult> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TResult>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d,
            Func<TLink5, TResult> end)
        {
            return _compose.Compose(start, a, b, c, d, end);
        }

        /// <summary>
        /// Converts passed function into an action
        /// </summary>
        public System.Action ToAction(Func<object> function)
        {
            return _convert.ToAction(function);
        }

        /// <summary>
        /// Converts passed function into an action
        /// </summary>
        public Action<T1> ToAction<T1>(Func<T1, object> function)
        {
            return _convert.ToAction(function);
        }

        /// <summary>
        /// Converts passed function into an action
        /// </summary>
        public Action<T1, T2> ToAction<T1, T2>(Func<T1, T2, object> function)
        {
            return _convert.ToAction(function);
        }

        /// <summary>
        /// Converts passed function into an action
        /// </summary>
        public Action<T1, T2, T3> ToAction<T1, T2, T3>(Func<T1, T2, T3, object> function)
        {
            return _convert.ToAction(function);
        }

        /// <summary>
        /// Converts passed function into an action
        /// </summary>
        public Action<T1, T2, T3, T4> ToAction<T1, T2, T3, T4>(Func<T1, T2, T3, T4, object> function)
        {
            return _convert.ToAction(function);
        }

        /// <summary>
        /// Converts passed function into an action
        /// </summary>
        public Action<T1, T2, T3, T4, T5> ToAction<T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5, object> function)
        {
            return _convert.ToAction(function);
        }

        /// <summary>
        /// Converts passed function into an action
        /// </summary>
        public Action<T1, T2, T3, T4, T5, T6> ToAction<T1, T2, T3, T4, T5, T6>(Func<T1, T2, T3, T4, T5, T6, object> function)
        {
            return _convert.ToAction(function);
        }

        /// <summary>
        /// Converts passed function into an action
        /// </summary>
        public Action<T1, T2, T3, T4, T5, T6, T7> ToAction<T1, T2, T3, T4, T5, T6, T7>(Func<T1, T2, T3, T4, T5, T6, T7, object> function)
        {
            return _convert.ToAction(function);
        }

        /// <summary>
        /// Converts passed function into an action
        /// </summary>
        public Action<T1, T2, T3, T4, T5, T6, T7, T8> ToAction<T1, T2, T3, T4, T5, T6, T7, T8>(Func<T1, T2, T3, T4, T5, T6, T7, T8, object> function)
        {
            return _convert.ToAction(function);
        }

        /// <summary>
        /// Converts passed function into an action
        /// </summary>
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> ToAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, object> function)
        {
            return _convert.ToAction(function);
        }

        /// <summary>
        /// Converts passed function into an action
        /// </summary>
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ToAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, object> function)
        {
            return _convert.ToAction(function);
        }

        /// <summary>
        /// Converts passed function into an action
        /// </summary>
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ToAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, object> function)
        {
            return _convert.ToAction(function);
        }

        /// <summary>
        /// Converts passed function into an action
        /// </summary>
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ToAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, object> function)
        {
            return _convert.ToAction(function);
        }

        /// <summary>
        /// Converts passed function into an action
        /// </summary>
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ToAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, object> function)
        {
            return _convert.ToAction(function);
        }

        /// <summary>
        /// Converts passed function into an action
        /// </summary>
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ToAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, object> function)
        {
            return _convert.ToAction(function);
        }

        /// <summary>
        /// Converts passed function into an action
        /// </summary>
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ToAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, object> function)
        {
            return _convert.ToAction(function);
        }

        /// <summary>
        /// Converts passed function into an action
        /// </summary>
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> ToAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, object> function)
        {
            return _convert.ToAction(function);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<Task<TResult>> After<TResult>(Func<TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, Task<TResult>> After<T1, TResult>(Func<T1, TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, Task<TResult>> After<T1, T2, TResult>(Func<T1, T2, TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, Task<TResult>> After<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, Task<TResult>> After<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, Task<TResult>> After<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, Task<TResult>> After<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<TResult> Before<TResult>(Func<TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T1, TResult> Before<T1, TResult>(Func<T1, TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T1, T2, TResult> Before<T1, T2, TResult>(Func<T1, T2, TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T1, T2, T3, TResult> Before<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T1, T2, T3, T4, TResult> Before<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T1, T2, T3, T4, T5, TResult> Before<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, TResult> Before<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, TResult> Before<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<Task<TResult>> Debounce<TResult>(Func<TResult> function, int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T, Task<TResult>> Debounce<T, TResult>(Func<T, TResult> function, int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, Task<TResult>> Debounce<T1, T2, TResult>(Func<T1, T2, TResult> function, int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, T3, Task<TResult>> Debounce<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, Task<TResult>> Debounce<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, Task<TResult>> Debounce<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function,
            int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<Task<TResult>> Throttle<TResult>(Func<TResult> function, int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<Task<TResult>> Throttle<TResult>(Func<TResult> function, int milliseconds, bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T, Task<TResult>> Throttle<T, TResult>(Func<T, TResult> function, int milliseconds, bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T, Task<TResult>> Throttle<T, TResult>(Func<T, TResult> function, int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, Task<TResult>> Throttle<T1, T2, TResult>(Func<T1, T2, TResult> function, int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, Task<TResult>> Throttle<T1, T2, TResult>(Func<T1, T2, TResult> function, int milliseconds, bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, Task<TResult>> Throttle<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, Task<TResult>> Throttle<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, int milliseconds, bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, Task<TResult>> Throttle<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, Task<TResult>> Throttle<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, int milliseconds, bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, Task<TResult>> Throttle<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, Task<TResult>> Throttle<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, int milliseconds, bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, int milliseconds, bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, int milliseconds, bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, int milliseconds, bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, int milliseconds, bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, int milliseconds, bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, int milliseconds, bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, int milliseconds, bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, int milliseconds,
            bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, int milliseconds,
            bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, int milliseconds,
            bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function,
            int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function,
            int milliseconds, bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        /// <summary>
        /// Creates a function that after a delay time
        /// </summary>
        public Func<Task<TResult>> Delay<TResult>(Func<TResult> function, int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }

        /// <summary>
        /// Creates a function that after a delay time
        /// </summary>
        public Func<T, Task<TResult>> Delay<T, TResult>(Func<T, TResult> function, int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }
        /// <summary>
        /// Creates a function that after a delay time
        /// </summary>
        public Func<T1, T2, Task<TResult>> Delay<T1, T2, TResult>(Func<T1, T2, TResult> function, int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }
        /// <summary>
        /// Creates a function that after a delay time
        /// </summary>
        public Func<T1, T2, T3, Task<TResult>> Delay<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }      
        
        /// <summary>
        /// Creates a function that after a delay time
        /// </summary>
        public Func<T1, T2, T3, T4, Task<TResult>> Delay<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }
        /// <summary>
        /// Creates a function that after a delay time
        /// </summary>
        public Func<T1, T2, T3, T4, T5, Task<TResult>> Delay<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }
        /// <summary>
        /// Creates a function that after a delay time
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }
        /// <summary>
        /// Creates a function that after a delay time
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }
        /// <summary>
        /// Creates a function that after a delay time
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }
        /// <summary>
        /// Creates a function that after a delay time
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }
        /// <summary>
        /// Creates a function that after a delay time
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }
        /// <summary>
        /// Creates a function that after a delay time
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }
        /// <summary>
        /// Creates a function that after a delay time
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }
        /// <summary>
        /// Creates a function that after a delay time
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }
        /// <summary>
        /// Creates a function that after a delay time
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }
        /// <summary>
        /// Creates a function that after a delay time
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }


        /// <summary>
        /// Creates a function that after a delay time
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function,
            int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }


        /// <summary>
        /// Creates a function that will only execute one time
        /// </summary>
        public Func<TResult> Once<TResult>(Func<TResult> function)
        {
            return _synch.Once(function);
        }


        /// <summary>
        /// Creates a function that will only execute one time
        /// </summary>
        public Func<T, TResult> Once<T, TResult>(Func<T, TResult> function)
        {
            return _synch.Once(function);
        }


        /// <summary>
        /// Creates a function that will only execute one time
        /// </summary>
        public Func<T1, T2, TResult> Once<T1, T2, TResult>(Func<T1, T2, TResult> function)
        {
            return _synch.Once(function);
        }


        /// <summary>
        /// Creates a function that will only execute one time
        /// </summary>
        public Func<T1, T2, T3, TResult> Once<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function)
        {
            return _synch.Once(function);
        }


        /// <summary>
        /// Creates a function that will only execute one time
        /// </summary>
        public Func<T1, T2, T3, T4, TResult> Once<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function)
        {
            return _synch.Once(function);
        }


        /// <summary>
        /// Creates a function that will only execute one time
        /// </summary>
        public Func<T1, T2, T3, T4, T5, TResult> Once<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function)
        {
            return _synch.Once(function);
        }


        /// <summary>
        /// Creates a function that will only execute one time
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, TResult> Once<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function)
        {
            return _synch.Once(function);
        }


        /// <summary>
        /// Creates a function that will only execute one time
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, TResult> Once<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function)
        {
            return _synch.Once(function);
        }


        /// <summary>
        /// Creates a function that will only execute one time
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function)
        {
            return _synch.Once(function);
        }


        /// <summary>
        /// Creates a function that will only execute one time
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function)
        {
            return _synch.Once(function);
        }


        /// <summary>
        /// Creates a function that will only execute one time
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function)
        {
            return _synch.Once(function);
        }


        /// <summary>
        /// Creates a function that will only execute one time
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function)
        {
            return _synch.Once(function);
        }


        /// <summary>
        /// Creates a function that will only execute one time
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function)
        {
            return _synch.Once(function);
        }


        /// <summary>
        /// Creates a function that will only execute one time
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function)
        {
            return _synch.Once(function);
        }


        /// <summary>
        /// Creates a function that will only execute one time
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function)
        {
            return _synch.Once(function);
        }


        /// <summary>
        /// Creates a function that will only execute one time
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function)
        {
            return _synch.Once(function);
        }

        /// <summary>
        /// Creates a function that will only execute one time
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function)
        {
            return _synch.Once(function);
        }

        /// <summary>
        /// Creates a function that caches the first request with unique arguments and returns the first result for all following calls with the same parameters 
        /// </summary>
        public Func<TArg, TResult> Memoize<TArg, TResult>(Func<TArg, TResult> function)
        {
            return _cache.Memoize(function);
        }

        /// <summary>
        /// Creates a function that caches the first request with unique arguments and returns the first result for all following calls with the same parameters 
        /// </summary>
        public Func<TArg1, TArg2, TResult> Memoize<TArg1, TArg2, TResult>(Func<TArg1, TArg2, TResult> function)
        {
            return _cache.Memoize(function);
        }

        /// <summary>
        /// Creates a function that caches the first request with unique arguments and returns the first result for all following calls with the same parameters 
        /// </summary>
        public Func<TArg1, TArg2, TArg3, TResult> Memoize<TArg1, TArg2, TArg3, TResult>(Func<TArg1, TArg2, TArg3, TResult> function)
        {
            return _cache.Memoize(function);
        }

        /// <summary>
        /// Creates a function that caches the first request with unique arguments and returns the first result for all following calls with the same parameters 
        /// </summary>
        public Func<TArg1, TArg2, TArg3, TArg4, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TResult> function)
        {
            return _cache.Memoize(function);
        }

        /// <summary>
        /// Creates a function that caches the first request with unique arguments and returns the first result for all following calls with the same parameters 
        /// </summary>
        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> function)
        {
            return _cache.Memoize(function);
        }

        /// <summary>
        /// Creates a function that caches the first request with unique arguments and returns the first result for all following calls with the same parameters 
        /// </summary>
        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> function)
        {
            return _cache.Memoize(function);
        }

        /// <summary>
        /// Creates a function that caches the first request with unique arguments and returns the first result for all following calls with the same parameters 
        /// </summary>
        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> function)
        {
            return _cache.Memoize(function);
        }

        /// <summary>
        /// Creates a function that caches the first request with unique arguments and returns the first result for all following calls with the same parameters 
        /// </summary>
        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> function)
        {
            return _cache.Memoize(function);
        }

        /// <summary>
        /// Creates a function that caches the first request with unique arguments and returns the first result for all following calls with the same parameters 
        /// </summary>
        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> function)
        {
            return _cache.Memoize(function);
        }

        /// <summary>
        /// Creates a function that caches the first request with unique arguments and returns the first result for all following calls with the same parameters 
        /// </summary>
        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> function)
        {
            return _cache.Memoize(function);
        }

        /// <summary>
        /// Creates a function that caches the first request with unique arguments and returns the first result for all following calls with the same parameters 
        /// </summary>
        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> function)
        {
            return _cache.Memoize(function);
        }

        /// <summary>
        /// Creates a function that caches the first request with unique arguments and returns the first result for all following calls with the same parameters 
        /// </summary>
        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> function)
        {
            return _cache.Memoize(function);
        }

        /// <summary>
        /// Creates a function that caches the first request with unique arguments and returns the first result for all following calls with the same parameters 
        /// </summary>
        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> function)
        {
            return _cache.Memoize(function);
        }

        /// <summary>
        /// Creates a function that caches the first request with unique arguments and returns the first result for all following calls with the same parameters 
        /// </summary>
        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> Memoize
            <TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> function)
        {
            return _cache.Memoize(function);
        }


        /// <summary>
        /// Creates a function that caches the first request with unique arguments and returns the first result for all following calls with the same parameters 
        /// </summary>
        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> Memoize
            <TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15,
                TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> function)
        {
            return _cache.Memoize(function);
        }

        /// <summary>
        /// Creates a function that caches the first request with unique arguments and returns the first result for all following calls with the same parameters 
        /// </summary>
        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> Memoize
            <TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15,
                TArg16, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> function)
        {
            return _cache.Memoize(function);
        }

        /// <summary>
        /// Creates a function that is the negation of the passed function
        /// </summary>
        public Func<bool> Negate(Func<bool> fn)
        {
            return _booleanComponent.Negate(fn);
        }

        /// <summary>
        /// Creates a function that is the negation of the passed function
        /// </summary>
        public Func<T1, bool> Negate<T1>(Func<T1, bool> fn)
        {
            return _booleanComponent.Negate(fn);
        }

        /// <summary>
        /// Creates a function that is the negation of the passed function
        /// </summary>
        public Func<T1, T2, bool> Negate<T1, T2>(Func<T1, T2, bool> fn)
        {
            return _booleanComponent.Negate(fn);
        }

        /// <summary>
        /// Creates a function that is the negation of the passed function
        /// </summary>
        public Func<T1, T2, T3, bool> Negate<T1, T2, T3>(Func<T1, T2, T3, bool> fn)
        {
            return _booleanComponent.Negate(fn);
        }

        /// <summary>
        /// Creates a function that is the negation of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, bool> Negate<T1, T2, T3, T4>(Func<T1, T2, T3, T4, bool> fn)
        {
            return _booleanComponent.Negate(fn);
        }

        /// <summary>
        /// Creates a function that is the negation of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, bool> Negate<T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5, bool> fn)
        {
            return _booleanComponent.Negate(fn);
        }

        /// <summary>
        /// Creates a function that is the negation of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, bool> Negate<T1, T2, T3, T4, T5, T6>(Func<T1, T2, T3, T4, T5, T6, bool> fn)
        {
            return _booleanComponent.Negate(fn);
        }

        /// <summary>
        /// Creates a function that is the negation of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, bool> Negate<T1, T2, T3, T4, T5, T6, T7>(Func<T1, T2, T3, T4, T5, T6, T7, bool> fn)
        {
            return _booleanComponent.Negate(fn);
        }

        /// <summary>
        /// Creates a function that is the negation of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8>(Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> fn)
        {
            return _booleanComponent.Negate(fn);
        }

        /// <summary>
        /// Creates a function that is the negation of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> fn)
        {
            return _booleanComponent.Negate(fn);
        }

        /// <summary>
        /// Creates a function that is the negation of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> fn)
        {
            return _booleanComponent.Negate(fn);
        }

        /// <summary>
        /// Creates a function that is the negation of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> fn)
        {
            return _booleanComponent.Negate(fn);
        }

        /// <summary>
        /// Creates a function that is the negation of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> fn)
        {
            return _booleanComponent.Negate(fn);
        }

        /// <summary>
        /// Creates a function that is the negation of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> fn)
        {
            return _booleanComponent.Negate(fn);
        }

        /// <summary>
        /// Creates a function that is the negation of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> fn)
        {
            return _booleanComponent.Negate(fn);
        }

        /// <summary>
        /// Creates a function that is the negation of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> fn)
        {
            return _booleanComponent.Negate(fn);
        }
        /// <summary>
        /// Creates a function that is the negation of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> fn)
        {
            return _booleanComponent.Negate(fn);
        }
        /// <summary>
        /// Creates a composite of all the functions by oring the results together
        /// </summary>
        public Func<bool> Or(params Func<bool>[] fns)
        {
            return _booleanComponent.Or(fns);
        }
        /// <summary>
        /// Creates a composite of all the functions by oring the results together
        /// </summary>
        public Func<T1, bool> Or<T1>(params Func<T1, bool>[] fns)
        {
            return _booleanComponent.Or(fns);
        }
        /// <summary>
        /// Creates a composite of all the functions by oring the results together
        /// </summary>
        public Func<T1, T2, bool> Or<T1, T2>(params Func<T1, T2, bool>[] fns)
        {
            return _booleanComponent.Or(fns);
        }
        /// <summary>
        /// Creates a composite of all the functions by oring the results together
        /// </summary>
        public Func<T1, T2, T3, bool> Or<T1, T2, T3>(params Func<T1, T2, T3, bool>[] fns)
        {
            return _booleanComponent.Or(fns);
        }
        /// <summary>
        /// Creates a composite of all the functions by oring the results together
        /// </summary>
        public Func<T1, T2, T3, T4, bool> Or<T1, T2, T3, T4>(params Func<T1, T2, T3, T4, bool>[] fns)
        {
            return _booleanComponent.Or(fns);
        }
        /// <summary>
        /// Creates a composite of all the functions by oring the results together
        /// </summary>
        public Func<T1, T2, T3, T4, T5, bool> Or<T1, T2, T3, T4, T5>(params Func<T1, T2, T3, T4, T5, bool>[] fns)
        {
            return _booleanComponent.Or(fns);
        }
        /// <summary>
        /// Creates a composite of all the functions by oring the results together
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, bool> Or<T1, T2, T3, T4, T5, T6>(params Func<T1, T2, T3, T4, T5, T6, bool>[] fns)
        {
            return _booleanComponent.Or(fns);
        }
        /// <summary>
        /// Creates a composite of all the functions by oring the results together
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, bool> Or<T1, T2, T3, T4, T5, T6, T7>(params Func<T1, T2, T3, T4, T5, T6, T7, bool>[] fns)
        {
            return _booleanComponent.Or(fns);
        }
        /// <summary>
        /// Creates a composite of all the functions by oring the results together
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, bool>[] fns)
        {
            return _booleanComponent.Or(fns);
        }
        /// <summary>
        /// Creates a composite of all the functions by oring the results together
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8, T9>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool>[] fns)
        {
            return _booleanComponent.Or(fns);
        }
        /// <summary>
        /// Creates a composite of all the functions by oring the results together
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>[] fns)
        {
            return _booleanComponent.Or(fns);
        }
        /// <summary>
        /// Creates a composite of all the functions by oring the results together
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool>[] fns)
        {
            return _booleanComponent.Or(fns);
        }
        /// <summary>
        /// Creates a composite of all the functions by oring the results together
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool>[] fns)
        {
            return _booleanComponent.Or(fns);
        }
        /// <summary>
        /// Creates a composite of all the functions by oring the results together
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool>[] fns)
        {
            return _booleanComponent.Or(fns);
        }
        /// <summary>
        /// Creates a composite of all the functions by oring the results together
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool>[] fns)
        {
            return _booleanComponent.Or(fns);
        }
        /// <summary>
        /// Creates a composite of all the functions by oring the results together
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool>[] fns)
        {
            return _booleanComponent.Or(fns);
        }

        /// <summary>
        /// Creates a composite of all the functions by oring the results together
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool>[] fns)
        {
            return _booleanComponent.Or(fns);
        }

        /// <summary>
        /// Creates a composite of all the functions by anding the results together
        /// </summary>
        public Func<bool> And(params Func<bool>[] fns)
        {
            return _booleanComponent.And(fns);
        }

        /// <summary>
        /// Creates a composite of all the functions by anding the results together
        /// </summary>
        public Func<T1, bool> And<T1>(params Func<T1, bool>[] fns)
        {
            return _booleanComponent.And(fns);
        }

        /// <summary>
        /// Creates a composite of all the functions by anding the results together
        /// </summary>
        public Func<T1, T2, bool> And<T1, T2>(params Func<T1, T2, bool>[] fns)
        {
            return _booleanComponent.And(fns);
        }

        /// <summary>
        /// Creates a composite of all the functions by anding the results together
        /// </summary>
        public Func<T1, T2, T3, bool> And<T1, T2, T3>(params Func<T1, T2, T3, bool>[] fns)
        {
            return _booleanComponent.And(fns);
        }

        /// <summary>
        /// Creates a composite of all the functions by anding the results together
        /// </summary>
        public Func<T1, T2, T3, T4, bool> And<T1, T2, T3, T4>(params Func<T1, T2, T3, T4, bool>[] fns)
        {
            return _booleanComponent.And(fns);
        }

        /// <summary>
        /// Creates a composite of all the functions by anding the results together
        /// </summary>
        public Func<T1, T2, T3, T4, T5, bool> And<T1, T2, T3, T4, T5>(params Func<T1, T2, T3, T4, T5, bool>[] fns)
        {
            return _booleanComponent.And(fns);
        }

        /// <summary>
        /// Creates a composite of all the functions by anding the results together
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, bool> And<T1, T2, T3, T4, T5, T6>(params Func<T1, T2, T3, T4, T5, T6, bool>[] fns)
        {
            return _booleanComponent.And(fns);
        }

        /// <summary>
        /// Creates a composite of all the functions by anding the results together
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, bool> And<T1, T2, T3, T4, T5, T6, T7>(params Func<T1, T2, T3, T4, T5, T6, T7, bool>[] fns)
        {
            return _booleanComponent.And(fns);
        }

        /// <summary>
        /// Creates a composite of all the functions by anding the results together
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> And<T1, T2, T3, T4, T5, T6, T7, T8>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, bool>[] fns)
        {
            return _booleanComponent.And(fns);
        }

        /// <summary>
        /// Creates a composite of all the functions by anding the results together
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> And<T1, T2, T3, T4, T5, T6, T7, T8, T9>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool>[] fns)
        {
            return _booleanComponent.And(fns);
        }

        /// <summary>
        /// Creates a composite of all the functions by anding the results together
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> And<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>[] fns)
        {
            return _booleanComponent.And(fns);
        }

        /// <summary>
        /// Creates a composite of all the functions by anding the results together
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> And<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool>[] fns)
        {
            return _booleanComponent.And(fns);
        }

        /// <summary>
        /// Creates a composite of all the functions by anding the results together
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> And<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool>[] fns)
        {
            return _booleanComponent.And(fns);
        }

        /// <summary>
        /// Creates a composite of all the functions by anding the results together
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> And<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool>[] fns)
        {
            return _booleanComponent.And(fns);
        }

        /// <summary>
        /// Creates a composite of all the functions by anding the results together
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> And<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool>[] fns)
        {
            return _booleanComponent.And(fns);
        }

        /// <summary>
        /// Creates a composite of all the functions by anding the results together
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> And<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool>[] fns)
        {
            return _booleanComponent.And(fns);
        }

        /// <summary>
        /// Creates a composite of all the functions by anding the results together
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> And<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool>[] fns)
        {
            return _booleanComponent.And(fns);
        }
    }
}
