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
        ICacheComponent
    {

        private readonly IComposeComponent _compose;
        private readonly IBindComponent _bind;
        private readonly IPartialComponent _partial;
        private readonly ISplitComponent _split;
        private readonly IConvertComponent _convert;
        private readonly ISynchComponent _synch;
        private readonly ICacheComponent _cache;

        public Function( 
            IBindComponent bind, 
            IPartialComponent partial,
            ISplitComponent split,
            IComposeComponent compose,
            IConvertComponent convert,
            ISynchComponent synch,
            ICacheComponent cache) 
        {
            _bind = bind;
            _partial = partial;
            _split = split;
            _compose = compose;
            _synch = synch;
            _convert = convert;
            _cache = cache;
        }


        public Func<T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _partial.Partial(function, a, b, c, d, e);
        }

        public Func<T2, T3, T4, T5, T6, T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 a)
        {
            return _partial.Partial(function, a);
        }

        public Func<T3, T4, T5, T6, T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 a, T2 b)
        {
            return _partial.Partial(function, a, b);
        }

        public Func<T4, T5, T6, T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(function, a, b, c);
        }

        public Func<T5, T6, T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 a, T2 b, T3 c, T4 d)
        {
            return _partial.Partial(function, a, b, c, d);
        }

        public Func<T6, T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _partial.Partial(function, a, b, c, d, e);
        }

        public Func<T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
        {
            return _partial.Partial(function, a, b, c, d, e, f);
        }

        public Func<T2, T3, T4, T5, T6, T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a)
        {
            return _partial.Partial(function, a);
        }

        public Func<T3, T4, T5, T6, T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a, T2 b)
        {
            return _partial.Partial(function, a, b);
        }

        public Func<T4, T5, T6, T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(function, a, b, c);
        }

        public Func<T5, T6, T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a, T2 b, T3 c, T4 d)
        {
            return _partial.Partial(function, a, b, c, d);
        }

        public Func<T6, T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _partial.Partial(function, a, b, c, d, e);
        }

        public Func<T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
        {
            return _partial.Partial(function, a, b, c, d, e, f);
        }

        public Func<T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g);
        }

        public Func<T2, T3, T4, T5, T6, T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a)
        {
            return _partial.Partial(function, a);
        }

        public Func<T3, T4, T5, T6, T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b)
        {
            return _partial.Partial(function, a, b);
        }

        public Func<T4, T5, T6, T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(function, a, b, c);
        }

        public Func<T5, T6, T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b, T3 c, T4 d)
        {
            return _partial.Partial(function, a, b, c, d);
        }

        public Func<T6, T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _partial.Partial(function, a, b, c, d, e);
        }

        public Func<T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
        {
            return _partial.Partial(function, a, b, c, d, e, f);
        }

        public Func<T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g);
        }

        public Func<T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h);
        }

        public Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a)
        {
            return _partial.Partial(function, a);
        }

        public Func<T3, T4, T5, T6, T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b)
        {
            return _partial.Partial(function, a, b);
        }

        public Func<T4, T5, T6, T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(function, a, b, c);
        }

        public Func<T5, T6, T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c, T4 d)
        {
            return _partial.Partial(function, a, b, c, d);
        }

        public Func<T6, T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _partial.Partial(function, a, b, c, d, e);
        }

        public Func<T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
        {
            return _partial.Partial(function, a, b, c, d, e, f);
        }

        public Func<T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g);
        }

        public Func<T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g,
            T8 h)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h);
        }

        public Func<T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g,
            T8 h, T9 i)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i);
        }

        public Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a)
        {
            return _partial.Partial(function, a);
        }

        public Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b)
        {
            return _partial.Partial(function, a, b);
        }

        public Func<T4, T5, T6, T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(function, a, b, c);
        }

        public Func<T5, T6, T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d)
        {
            return _partial.Partial(function, a, b, c, d);
        }

        public Func<T6, T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _partial.Partial(function, a, b, c, d, e);
        }

        public Func<T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
        {
            return _partial.Partial(function, a, b, c, d, e, f);
        }

        public Func<T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g);
        }

        public Func<T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g, T8 h)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h);
        }

        public Func<T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g, T8 h, T9 i)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i);
        }

        public Func<T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g, T8 h, T9 i, T10 j)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j);
        }

        public Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a)
        {
            return _partial.Partial(function, a);
        }

        public Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b)
        {
            return _partial.Partial(function, a, b);
        }

        public Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(function, a, b, c);
        }

        public Func<T5, T6, T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d)
        {
            return _partial.Partial(function, a, b, c, d);
        }

        public Func<T6, T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _partial.Partial(function, a, b, c, d, e);
        }

        public Func<T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f)
        {
            return _partial.Partial(function, a, b, c, d, e, f);
        }

        public Func<T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f, T7 g)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g);
        }

        public Func<T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f, T7 g, T8 h)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h);
        }

        public Func<T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f, T7 g, T8 h, T9 i)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i);
        }

        public Func<T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f, T7 g, T8 h, T9 i, T10 j)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j);
        }

        public Func<T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f, T7 g, T8 h, T9 i, T10 j, T11 k)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j, k);
        }

        public Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a)
        {
            return _partial.Partial(function, a);
        }

        public Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b)
        {
            return _partial.Partial(function, a, b);
        }

        public Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(function, a, b, c);
        }

        public Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d)
        {
            return _partial.Partial(function, a, b, c, d);
        }

        public Func<T6, T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e)
        {
            return _partial.Partial(function, a, b, c, d, e);
        }

        public Func<T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f)
        {
            return _partial.Partial(function, a, b, c, d, e, f);
        }

        public Func<T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g);
        }

        public Func<T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h);
        }

        public Func<T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i);
        }

        public Func<T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j);
        }

        public Func<T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j, k);
        }

        public Func<T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j, k, l);
        }

        public Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a)
        {
            return _partial.Partial(function, a);
        }

        public Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b)
        {
            return _partial.Partial(function, a, b);
        }

        public Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(function, a, b, c);
        }

        public Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d)
        {
            return _partial.Partial(function, a, b, c, d);
        }

        public Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e)
        {
            return _partial.Partial(function, a, b, c, d, e);
        }

        public Func<T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f)
        {
            return _partial.Partial(function, a, b, c, d, e, f);
        }

        public Func<T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g);
        }

        public Func<T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h);
        }

        public Func<T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i);
        }

        public Func<T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j);
        }

        public Func<T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j, k);
        }

        public Func<T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j, k, l);
        }

        public Func<T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j, k, l, m);
        }

        public Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a)
        {
            return _partial.Partial(function, a);
        }

        public Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b)
        {
            return _partial.Partial(function, a, b);
        }

        public Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(function, a, b, c);
        }

        public Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c,
            T4 d)
        {
            return _partial.Partial(function, a, b, c, d);
        }

        public Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c,
            T4 d, T5 e)
        {
            return _partial.Partial(function, a, b, c, d, e);
        }

        public Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f)
        {
            return _partial.Partial(function, a, b, c, d, e, f);
        }

        public Func<T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g);
        }

        public Func<T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g, T8 h)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h);
        }

        public Func<T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i);
        }

        public Func<T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j);
        }

        public Func<T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j, k);
        }

        public Func<T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j, k, l);
        }

        public Func<T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j, k, l, m);
        }

        public Func<T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j, k, l, m, n);
        }

        public Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a)
        {
            return _partial.Partial(function, a);
        }

        public Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b)
        {
            return _partial.Partial(function, a, b);
        }

        public Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b,
            T3 c)
        {
            return _partial.Partial(function, a, b, c);
        }

        public Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b,
            T3 c, T4 d)
        {
            return _partial.Partial(function, a, b, c, d);
        }

        public Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b,
            T3 c, T4 d, T5 e)
        {
            return _partial.Partial(function, a, b, c, d, e);
        }

        public Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b,
            T3 c, T4 d, T5 e, T6 f)
        {
            return _partial.Partial(function, a, b, c, d, e, f);
        }

        public Func<T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b,
            T3 c, T4 d, T5 e, T6 f, T7 g)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g);
        }

        public Func<T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b,
            T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h);
        }

        public Func<T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b,
            T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i);
        }

        public Func<T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b,
            T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j);
        }

        public Func<T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b,
            T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j, k);
        }

        public Func<T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b,
            T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j, k, l);
        }

        public Func<T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b,
            T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j, k, l, m);
        }

        public Func<T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b,
            T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j, k, l, m, n);
        }

        public Func<T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b,
            T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n, T15 o)
        {
            return _partial.Partial(function, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
        }
        public Func<T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, T1 a, T2 b, T3 c, T4 d)
        {
            return _partial.Partial(function, a, b, c, d);
        }

        public Func<T2, T3, T4, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 a)
        {
            return _partial.Partial(function, a);
        }

        public Func<T3, T4, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 a, T2 b)
        {
            return _partial.Partial(function, a, b);
        }

        public Func<T4, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(function, a, b, c);
        }

        public Func<T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 a, T2 b, T3 c, T4 d)
        {
            return _partial.Partial(function, a, b, c, d);
        }

        public Func<T2, TResult> Partial<T1, T2, TResult>(Func<T1, T2, TResult> function, T1 a)
        {
            return _partial.Partial(function, a);
        }

        public Func<T2, T3, TResult> Partial<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, T1 a)
        {
            return _partial.Partial(function, a);
        }

        public Func<T3, TResult> Partial<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, T1 a, T2 b)
        {
            return _partial.Partial(function, a, b);
        }

        public Func<T2, T3, T4, TResult> Partial<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, T1 a)
        {
            return _partial.Partial(function, a);
        }

        public Func<T3, T4, TResult> Partial<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, T1 a, T2 b)
        {
            return _partial.Partial(function, a, b);
        }

        public Func<T4, TResult> Partial<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(function, a, b, c);
        }

        public Func<T2, T3, T4, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, T1 a)
        {
            return _partial.Partial(function, a);
        }

        public Func<T3, T4, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, T1 a, T2 b)
        {
            return _partial.Partial(function, a, b);
        }

        public Func<T4, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, T1 a, T2 b, T3 c)
        {
            return _partial.Partial(function, a, b, c);
        }



        public Func<TResult> Bind<T1, TResult>(Func<T1, TResult> function, T1 a)
        {
            return _bind.Bind(function, a);
        }

        public Func<TResult> Bind<T1, T2, TResult>(Func<T1, T2, TResult> function, T1 a, T2 b)
        {
            return _bind.Bind(function, a, b);
        }

        public Func<TResult> Bind<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, T1 a, T2 b, T3 c)
        {
            return _bind.Bind(function, a, b, c);
        }

        public Func<TResult> Bind<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, T1 a, T2 b, T3 c, T4 d)
        {
            return _bind.Bind(function, a, b, c, d);
        }

        public Func<TResult> Bind<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _bind.Bind(function, a, b, c, d, e);
        }

        public Func<TResult> Bind<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
        {
            return _bind.Bind(function, a, b, c, d, e, f);
        }

        public Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
        {
            return _bind.Bind(function, a, b, c, d, e, f, g);
        }

        public Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
        {
            return _bind.Bind(function, a, b, c, d, e, f, g, h);
        }

        public Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h,
            T9 i)
        {
            return _bind.Bind(function, a, b, c, d, e, f, g, h, i);
        }

        public Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g,
            T8 h, T9 i, T10 j)
        {
            return _bind.Bind(function, a, b, c, d, e, f, g, h, i, j);
        }

        public Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g,
            T8 h, T9 i, T10 j, T11 k)
        {
            return _bind.Bind(function, a, b, c, d, e, f, g, h, i, j, k);
        }

        public Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g, T8 h, T9 i, T10 j, T11 k, T12 l)
        {
            return _bind.Bind(function, a, b, c, d, e, f, g, h, i, j, k, l);
        }

        public Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m)
        {
            return _bind.Bind(function, a, b, c, d, e, f, g, h, i, j, k, l, m);
        }

        public Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n)
        {
            return _bind.Bind(function, a, b, c, d, e, f, g, h, i, j, k, l, m, n);
        }

        public Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n, T15 o)
        {
            return _bind.Bind(function, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
        }

        public Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b,
            T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n, T15 o, T16 p)
        {
            return _bind.Bind(function, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
        }

        public Func<T0, T1, T2, T3, T4, T5, T6, T7, Func<T8, T9, T10, T11, T12, T13, T14, T15, TResult>> Split<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> target )
        {
            return _split.Split( target );
        }

        public Func<T0, T1, T2, T3, Func<T4, T5, T6, T7, TResult>> Split<T0, T1, T2, T3, T4, T5, T6, T7, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, T7, TResult> target )
        {
            return _split.Split( target );
        }

        public Func<T0, T1, Func<T2, T3, TResult>> Split<T0, T1, T2, T3, TResult>( Func<T0, T1, T2, T3, TResult> target )
        {
            return _split.Split( target );
        }

        public Func<T0, Func<T1, TResult>> Split<T0, T1, TResult>( Func<T0, T1, TResult> target )
        {
            return _split.Split( target );
        }


        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TResult>>>>>>>>>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> target )
        {
            return _split.Curry( target );
        }

        public Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TResult>>>>>>>>>>>>>>>> function)
        {
            return _split.Uncurry(function);
        }

        public Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TResult>>>>>>>>>>>>>>> function)
        {
            return _split.Uncurry(function);
        }

        public Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TResult>>>>>>>>>>>>>> function)
        {
            return _split.Uncurry(function);
        }

        public Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TResult>>>>>>>>>>>>> function)
        {
            return _split.Uncurry(function);
        }

        public Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, TResult>>>>>>>>>>>> function)
        {
            return _split.Uncurry(function);
        }

        public Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, TResult>>>>>>>>>>> function)
        {
            return _split.Uncurry(function);
        }

        public Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, TResult>>>>>>>>>> function)
        {
            return _split.Uncurry(function);
        }

        public Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, TResult> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TResult>>>>>>>>> function)
        {
            return _split.Uncurry(function);
        }

        public Func<T0, T1, T2, T3, T4, T5, T6, T7, TResult> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TResult>>>>>>>> function)
        {
            return _split.Uncurry(function);
        }

        public Func<T0, T1, T2, T3, T4, T5, T6, TResult> Uncurry<T0, T1, T2, T3, T4, T5, T6, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TResult>>>>>>> function)
        {
            return _split.Uncurry(function);
        }

        public Func<T0, T1, T2, T3, T4, T5, TResult> Uncurry<T0, T1, T2, T3, T4, T5, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TResult>>>>>> function)
        {
            return _split.Uncurry(function);
        }

        public Func<T0, T1, T2, T3, T4, TResult> Uncurry<T0, T1, T2, T3, T4, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, TResult>>>>> function)
        {
            return _split.Uncurry(function);
        }

        public Func<T0, T1, T2, T3, TResult> Uncurry<T0, T1, T2, T3, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, TResult>>>> function)
        {
            return _split.Uncurry(function);
        }

        public Func<T0, T1, T2, TResult> Uncurry<T0, T1, T2, TResult>(Func<T0, Func<T1, Func<T2, TResult>>> function)
        {
            return _split.Uncurry(function);
        }

        public Func<T0, T1, TResult> Uncurry<T0, T1, TResult>(Func<T0, Func<T1, TResult>> function)
        {
            return _split.Uncurry(function);
        }

        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TResult>>>>>>>>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> target )
        {
            return _split.Curry( target );
        }

        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TResult>>>>>>>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> target )
        {
            return _split.Curry( target );
        }

        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TResult>>>>>>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> target )
        {
            return _split.Curry( target );
        }

        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, TResult>>>>>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> target )
        {
            return _split.Curry( target );
        }

        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, TResult>>>>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> target )
        {
            return _split.Curry( target );
        }

        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, TResult>>>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> target )
        {
            return _split.Curry( target );
        }

        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TResult>>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, TResult> target )
        {
            return _split.Curry( target );
        }

        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TResult>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, T7, TResult> target )
        {
            return _split.Curry( target );
        }

        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TResult>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, TResult> target )
        {
            return _split.Curry( target );
        }

        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TResult>>>>>> Curry<T0, T1, T2, T3, T4, T5, TResult>( Func<T0, T1, T2, T3, T4, T5, TResult> target )
        {
            return _split.Curry( target );
        }

        public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, TResult>>>>> Curry<T0, T1, T2, T3, T4, TResult>( Func<T0, T1, T2, T3, T4, TResult> target )
        {
            return _split.Curry( target );
        }

        public Func<T0, Func<T1, Func<T2, Func<T3, TResult>>>> Curry<T0, T1, T2, T3, TResult>( Func<T0, T1, T2, T3, TResult> target )
        {
            return _split.Curry( target );
        }

        public Func<T0, Func<T1, Func<T2, TResult>>> Curry<T0, T1, T2, TResult>( Func<T0, T1, T2, TResult> target )
        {
            return _split.Curry( target );
        }

        public Func<T0, Func<T1, TResult>> Curry<T0, T1, TResult>( Func<T0, T1, TResult> target )
        {
            return _split.Curry( target );
        }


        public Func<TStart, TResult> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TResult>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d,
            Func<TLink5, TLink6> e, Func<TLink6, TResult> end)
        {
            return _compose.Compose(start, a, b, c, d, e, end);
        }

        public Func<TStart, TResult> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TResult>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c,
            Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TResult> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, end);
        }

        public Func<TStart, TResult> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TResult>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b,
            Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TLink8> g, Func<TLink8, TResult> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, g, end);
        }

        public Func<TStart, TResult> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TResult>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a,
            Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TLink8> g, Func<TLink8, TLink9> h, Func<TLink9, TResult> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, g, h, end);
        }

        public Func<TStart, TResult> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TResult>(
            Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TLink8> g, Func<TLink8, TLink9> h, Func<TLink9, TLink10> i, Func<TLink10, TResult> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, g, h, i, end);
        }

        public Func<TStart, TResult> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TResult>(
            Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TLink8> g, Func<TLink8, TLink9> h, Func<TLink9, TLink10> i, Func<TLink10, TLink11> j, Func<TLink11, TResult> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, g, h, i, j, end);
        }

        public Func<TStart, TResult> Compose
            <TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TLink12, TResult>
            (Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TLink8> g, Func<TLink8, TLink9> h, Func<TLink9, TLink10> i, Func<TLink10, TLink11> j, Func<TLink11, TLink12> k, Func<TLink12, TResult> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, g, h, i, j, k, end);
        }

        public Func<TStart, TResult> Compose
            <TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TLink12, TLink13,
                TResult>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TLink8> g, Func<TLink8, TLink9> h, Func<TLink9, TLink10> i, Func<TLink10, TLink11> j, Func<TLink11, TLink12> k,
                    Func<TLink12, TLink13> l, Func<TLink13, TResult> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, g, h, i, j, k, l, end);
        }

        public Func<TStart, TResult> Compose
            <TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TLink12, TLink13,
                TLink14, TResult>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TLink8> g, Func<TLink8, TLink9> h, Func<TLink9, TLink10> i, Func<TLink10, TLink11> j,
                    Func<TLink11, TLink12> k, Func<TLink12, TLink13> l, Func<TLink13, TLink14> m, Func<TLink14, TResult> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, g, h, i, j, k, l, m, end);
        }

        public Func<TStart, TResult> Compose
            <TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TLink12, TLink13,
                TLink14, TLink15, TResult>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TLink8> g, Func<TLink8, TLink9> h, Func<TLink9, TLink10> i,
                    Func<TLink10, TLink11> j, Func<TLink11, TLink12> k, Func<TLink12, TLink13> l, Func<TLink13, TLink14> m, Func<TLink14, TLink15> n, Func<TLink15, TResult> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, g, h, i, j, k, l, m, n, end);
        }

        public Func<TStart, TResult> Compose
            <TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TLink12, TLink13,
                TLink14, TLink15, TLink16, TResult>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TLink8> g, Func<TLink8, TLink9> h,
                    Func<TLink9, TLink10> i, Func<TLink10, TLink11> j, Func<TLink11, TLink12> k, Func<TLink12, TLink13> l, Func<TLink13, TLink14> m, Func<TLink14, TLink15> n, Func<TLink15, TLink16> o, Func<TLink16, TResult> end)
        {
            return _compose.Compose(start, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, end);
        }

        public Func<T, T> Compose<T>( params Func<T, T>[ ] args )
        {
            return _compose.Compose( args );
        }


        public TResult Apply<T, TResult>( Func<T, T, T, T, T, T, T, T, T, T, T, T, T, T, T, T, TResult> fn, T[ ] arguments )
        {
            return _compose.Apply( fn, arguments );
        }

        public TResult Call<T1, TResult>(Func<T1, TResult> function, T1 a)
        {
            return _compose.Call(function, a);
        }

        public TResult Call<T1, T2, TResult>(Func<T1, T2, TResult> function, T1 a, T2 b)
        {
            return _compose.Call(function, a, b);
        }

        public TResult Call<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, T1 a, T2 b, T3 c)
        {
            return _compose.Call(function, a, b, c);
        }

        public TResult Call<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, T1 a, T2 b, T3 c, T4 d)
        {
            return _compose.Call(function, a, b, c, d);
        }

        public TResult Call<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return _compose.Call(function, a, b, c, d, e);
        }

        public TResult Call<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
        {
            return _compose.Call(function, a, b, c, d, e, f);
        }

        public TResult Call<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
        {
            return _compose.Call(function, a, b, c, d, e, f, g);
        }

        public TResult Call<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
        {
            return _compose.Call(function, a, b, c, d, e, f, g, h);
        }

        public TResult Call<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h,
            T9 i)
        {
            return _compose.Call(function, a, b, c, d, e, f, g, h, i);
        }

        public TResult Call<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g,
            T8 h, T9 i, T10 j)
        {
            return _compose.Call(function, a, b, c, d, e, f, g, h, i, j);
        }

        public TResult Call<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f,
            T7 g, T8 h, T9 i, T10 j, T11 k)
        {
            return _compose.Call(function, a, b, c, d, e, f, g, h, i, j, k);
        }

        public TResult Call<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e,
            T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l)
        {
            return _compose.Call(function, a, b, c, d, e, f, g, h, i, j, k, l);
        }

        public TResult Call<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m)
        {
            return _compose.Call(function, a, b, c, d, e, f, g, h, i, j, k, l, m);
        }

        public TResult Call<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d,
            T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n)
        {
            return _compose.Call(function, a, b, c, d, e, f, g, h, i, j, k, l, m, n);
        }

        public TResult Call<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c,
            T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n, T15 o)
        {
            return _compose.Call(function, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
        }

        public TResult Call<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b,
            T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n, T15 o, T16 p)
        {
            return _compose.Call(function, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
        }

        public TResult Apply<T, TResult>( Func<T, T, T, T, T, T, T, T, T, T, T, T, T, T, T, TResult> fn, T[ ] arguments )
        {
            return _compose.Apply( fn, arguments );
        }

        public TResult Apply<T, TResult>( Func<T, T, T, T, T, T, T, T, T, T, T, T, T, T, TResult> fn, T[ ] arguments )
        {
            return _compose.Apply( fn, arguments );
        }

        public TResult Apply<T, TResult>( Func<T, T, T, T, T, T, T, T, T, T, T, T, T, TResult> fn, T[ ] arguments )
        {
            return _compose.Apply( fn, arguments );
        }

        public TResult Apply<T, TResult>( Func<T, T, T, T, T, T, T, T, T, T, T, T, TResult> fn, T[ ] arguments )
        {
            return _compose.Apply( fn, arguments );
        }

        public TResult Apply<T, TResult>( Func<T, T, T, T, T, T, T, T, T, T, T, TResult> fn, T[ ] arguments )
        {
            return _compose.Apply( fn, arguments );
        }

        public TResult Apply<T, TResult>( Func<T, T, T, T, T, T, T, T, T, T, TResult> fn, T[ ] arguments )
        {
            return _compose.Apply( fn, arguments );
        }

        public TResult Apply<T, TResult>( Func<T, T, T, T, T, T, T, T, T, TResult> fn, T[ ] arguments )
        {
            return _compose.Apply( fn, arguments );
        }

        public TResult Apply<T, TResult>( Func<T, T, T, T, T, T, T, T, TResult> fn, T[ ] arguments )
        {
            return _compose.Apply( fn, arguments );
        }

        public TResult Apply<T, TResult>( Func<T, T, T, T, T, T, T, TResult> fn, T[ ] arguments )
        {
            return _compose.Apply( fn, arguments );
        }

        public TResult Apply<T, TResult>( Func<T, T, T, T, T, T, TResult> fn, T[ ] arguments )
        {
            return _compose.Apply( fn, arguments );
        }

        public TResult Apply<T, TResult>( Func<T, T, T, T, T, TResult> fn, T[ ] arguments )
        {
            return _compose.Apply( fn, arguments );
        }

        public TResult Apply<T, TResult>( Func<T, T, T, T, TResult> fn, T[ ] arguments )
        {
            return _compose.Apply( fn, arguments );
        }

        public TResult Apply<T, TResult>( Func<T, T, T, TResult> fn, T[ ] arguments )
        {
            return _compose.Apply( fn, arguments );
        }

        public TResult Apply<T, TResult>( Func<T, T, TResult> fn, T[ ] arguments )
        {
            return _compose.Apply( fn, arguments );
        }

        public TResult Apply<T, TResult>( Func<T, TResult> fn, T[ ] arguments )
        {
            return _compose.Apply( fn, arguments );
        }

        public Func<TStart, TResult> Compose<TStart, TMid, TResult>(Func<TStart, TMid> start, Func<TMid, TResult> end)
        {
            return _compose.Compose(start, end);
        }

        public Func<TStart, TResult> Compose<TStart, TLink1, TLink2, TResult>(Func<TStart, TLink1> start, Func<TLink1, TLink2> mid, Func<TLink2, TResult> end)
        {
            return _compose.Compose(start, mid, end);
        }

        public Func<TStart, TResult> Compose<TStart, TLink1, TLink2, TLink3, TResult>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TResult> end)
        {
            return _compose.Compose(start, a, b, end);
        }

        public Func<TStart, TResult> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TResult>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TResult> end)
        {
            return _compose.Compose(start, a, b, c, end);
        }

        public Func<TStart, TResult> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TResult>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d,
            Func<TLink5, TResult> end)
        {
            return _compose.Compose(start, a, b, c, d, end);
        }

        public System.Action ToAction(Func<object> function)
        {
            return _convert.ToAction(function);
        }

        public Action<T1> ToAction<T1>(Func<T1, object> function)
        {
            return _convert.ToAction(function);
        }

        public Action<T1, T2> ToAction<T1, T2>(Func<T1, T2, object> function)
        {
            return _convert.ToAction(function);
        }

        public Action<T1, T2, T3> ToAction<T1, T2, T3>(Func<T1, T2, T3, object> function)
        {
            return _convert.ToAction(function);
        }

        public Action<T1, T2, T3, T4> ToAction<T1, T2, T3, T4>(Func<T1, T2, T3, T4, object> function)
        {
            return _convert.ToAction(function);
        }

        public Action<T1, T2, T3, T4, T5> ToAction<T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5, object> function)
        {
            return _convert.ToAction(function);
        }

        public Action<T1, T2, T3, T4, T5, T6> ToAction<T1, T2, T3, T4, T5, T6>(Func<T1, T2, T3, T4, T5, T6, object> function)
        {
            return _convert.ToAction(function);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7> ToAction<T1, T2, T3, T4, T5, T6, T7>(Func<T1, T2, T3, T4, T5, T6, T7, object> function)
        {
            return _convert.ToAction(function);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8> ToAction<T1, T2, T3, T4, T5, T6, T7, T8>(Func<T1, T2, T3, T4, T5, T6, T7, T8, object> function)
        {
            return _convert.ToAction(function);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> ToAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, object> function)
        {
            return _convert.ToAction(function);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ToAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, object> function)
        {
            return _convert.ToAction(function);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ToAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, object> function)
        {
            return _convert.ToAction(function);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ToAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, object> function)
        {
            return _convert.ToAction(function);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ToAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, object> function)
        {
            return _convert.ToAction(function);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ToAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, object> function)
        {
            return _convert.ToAction(function);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ToAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, object> function)
        {
            return _convert.ToAction(function);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> ToAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, object> function)
        {
            return _convert.ToAction(function);
        }

        public Func<Task<TResult>> After<TResult>(Func<TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        public Func<T1, Task<TResult>> After<T1, TResult>(Func<T1, TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        public Func<T1, T2, Task<TResult>> After<T1, T2, TResult>(Func<T1, T2, TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        public Func<T1, T2, T3, Task<TResult>> After<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        public Func<T1, T2, T3, T4, Task<TResult>> After<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        public Func<T1, T2, T3, T4, T5, Task<TResult>> After<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        public Func<T1, T2, T3, T4, T5, T6, Task<TResult>> After<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, int count)
        {
            return _synch.After(function, count);
        }

        public Func<TResult> Before<TResult>(Func<TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        public Func<T1, TResult> Before<T1, TResult>(Func<T1, TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        public Func<T1, T2, TResult> Before<T1, T2, TResult>(Func<T1, T2, TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        public Func<T1, T2, T3, TResult> Before<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        public Func<T1, T2, T3, T4, TResult> Before<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        public Func<T1, T2, T3, T4, T5, TResult> Before<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        public Func<T1, T2, T3, T4, T5, T6, TResult> Before<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, TResult> Before<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, int count)
        {
            return _synch.Before(function, count);
        }

        public Func<Task<TResult>> Debounce<TResult>(Func<TResult> function, int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }

        public Func<T, Task<TResult>> Debounce<T, TResult>(Func<T, TResult> function, int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }

        public Func<T1, T2, Task<TResult>> Debounce<T1, T2, TResult>(Func<T1, T2, TResult> function, int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }

        public Func<T1, T2, T3, Task<TResult>> Debounce<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, Task<TResult>> Debounce<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, Task<TResult>> Debounce<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function,
            int milliseconds)
        {
            return _synch.Debounce(function, milliseconds);
        }

        public Func<Task<TResult>> Throttle<TResult>(Func<TResult> function, int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        public Func<Task<TResult>> Throttle<TResult>(Func<TResult> function, int milliseconds, bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        public Func<T, Task<TResult>> Throttle<T, TResult>(Func<T, TResult> function, int milliseconds, bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        public Func<T, Task<TResult>> Throttle<T, TResult>(Func<T, TResult> function, int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        public Func<T1, T2, Task<TResult>> Throttle<T1, T2, TResult>(Func<T1, T2, TResult> function, int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        public Func<T1, T2, Task<TResult>> Throttle<T1, T2, TResult>(Func<T1, T2, TResult> function, int milliseconds, bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        public Func<T1, T2, T3, Task<TResult>> Throttle<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        public Func<T1, T2, T3, Task<TResult>> Throttle<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, int milliseconds, bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        public Func<T1, T2, T3, T4, Task<TResult>> Throttle<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, Task<TResult>> Throttle<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, int milliseconds, bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        public Func<T1, T2, T3, T4, T5, Task<TResult>> Throttle<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, Task<TResult>> Throttle<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, int milliseconds, bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        public Func<T1, T2, T3, T4, T5, T6, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, int milliseconds, bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, int milliseconds, bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, int milliseconds, bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, int milliseconds, bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, int milliseconds, bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, int milliseconds, bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, int milliseconds, bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, int milliseconds,
            bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, int milliseconds,
            bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, int milliseconds,
            bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function,
            int milliseconds)
        {
            return _synch.Throttle(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function,
            int milliseconds, bool leading)
        {
            return _synch.Throttle(function, milliseconds, leading);
        }

        public Func<Task<TResult>> Delay<TResult>(Func<TResult> function, int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }

        public Func<T, Task<TResult>> Delay<T, TResult>(Func<T, TResult> function, int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }

        public Func<T1, T2, Task<TResult>> Delay<T1, T2, TResult>(Func<T1, T2, TResult> function, int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }

        public Func<T1, T2, T3, Task<TResult>> Delay<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, Task<TResult>> Delay<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, Task<TResult>> Delay<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function,
            int milliseconds)
        {
            return _synch.Delay(function, milliseconds);
        }

        public Func<TResult> Once<TResult>(Func<TResult> function)
        {
            return _synch.Once(function);
        }

        public Func<T, TResult> Once<T, TResult>(Func<T, TResult> function)
        {
            return _synch.Once(function);
        }

        public Func<T1, T2, TResult> Once<T1, T2, TResult>(Func<T1, T2, TResult> function)
        {
            return _synch.Once(function);
        }

        public Func<T1, T2, T3, TResult> Once<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function)
        {
            return _synch.Once(function);
        }

        public Func<T1, T2, T3, T4, TResult> Once<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function)
        {
            return _synch.Once(function);
        }

        public Func<T1, T2, T3, T4, T5, TResult> Once<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function)
        {
            return _synch.Once(function);
        }

        public Func<T1, T2, T3, T4, T5, T6, TResult> Once<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function)
        {
            return _synch.Once(function);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, TResult> Once<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function)
        {
            return _synch.Once(function);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function)
        {
            return _synch.Once(function);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function)
        {
            return _synch.Once(function);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function)
        {
            return _synch.Once(function);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function)
        {
            return _synch.Once(function);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function)
        {
            return _synch.Once(function);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function)
        {
            return _synch.Once(function);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function)
        {
            return _synch.Once(function);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function)
        {
            return _synch.Once(function);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function)
        {
            return _synch.Once(function);
        }

        public Func<TArg, TResult> Memoize<TArg, TResult>(Func<TArg, TResult> function)
        {
            return _cache.Memoize(function);
        }

        public Func<TArg1, TArg2, TResult> Memoize<TArg1, TArg2, TResult>(Func<TArg1, TArg2, TResult> function)
        {
            return _cache.Memoize(function);
        }

        public Func<TArg1, TArg2, TArg3, TResult> Memoize<TArg1, TArg2, TArg3, TResult>(Func<TArg1, TArg2, TArg3, TResult> function)
        {
            return _cache.Memoize(function);
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TResult> function)
        {
            return _cache.Memoize(function);
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> function)
        {
            return _cache.Memoize(function);
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> function)
        {
            return _cache.Memoize(function);
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> function)
        {
            return _cache.Memoize(function);
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> function)
        {
            return _cache.Memoize(function);
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> function)
        {
            return _cache.Memoize(function);
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> function)
        {
            return _cache.Memoize(function);
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> function)
        {
            return _cache.Memoize(function);
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> function)
        {
            return _cache.Memoize(function);
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> function)
        {
            return _cache.Memoize(function);
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> Memoize
            <TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> function)
        {
            return _cache.Memoize(function);
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> Memoize
            <TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15,
                TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> function)
        {
            return _cache.Memoize(function);
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> Memoize
            <TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15,
                TArg16, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> function)
        {
            return _cache.Memoize(function);
        }
    }
}
