using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Underscore.Collection.Contract;

namespace Underscore.Collection.Implementation
{
    public class ZipComponent : IZipComponent
    {
        //TODO: Implement this
        public Tuple<IEnumerable<T1>, IEnumerable<T2>> UnZip<T1, T2>(IEnumerable<Tuple<T1, T2>> zipped)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tuple<T1, T2>> Zip<T1, T2>(IEnumerable<T1> a, IEnumerable<T2> b)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tuple<T1, T2, T3>> Zip<T1, T2, T3>(IEnumerable<T1> a, IEnumerable<T2> b, IEnumerable<T3> c)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tuple<T1, T2, T3, T4>> Zip<T1, T2, T3, T4>(IEnumerable<T1> a, IEnumerable<T2> b, IEnumerable<T3> c, IEnumerable<T4> d)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tuple<T1, T2, T3, T4, T5>> Zip<T1, T2, T3, T4, T5>(IEnumerable<T1> a, IEnumerable<T2> b, IEnumerable<T3> c, IEnumerable<T4> d, IEnumerable<T5> e)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>> Zip<T1, T2, T3, T4, T5, T6>(IEnumerable<T1> a, IEnumerable<T2> b, IEnumerable<T3> c, IEnumerable<T4> d, IEnumerable<T5> e, IEnumerable<T6> f)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TResult> ZipWith<TArg1, TArg2, TResult>(IEnumerable<TArg1> a, IEnumerable<TArg2> b, Func<TArg1, TArg2, TResult> zipper)
        {
            throw new NotImplementedException();
        }
    }
}
