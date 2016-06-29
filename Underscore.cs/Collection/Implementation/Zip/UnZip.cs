using System;
using System.Collections.Generic;
using Underscore.Collection.Contract.Zip;

namespace Underscore.Collection.Implementation.Zip
{
	public partial class ZipComponent : IZipComponent
	{
		public Tuple<IEnumerable<T1>, IEnumerable<T2>> UnZip<T1, T2>(IEnumerable<Tuple<T1, T2>> zipped)
		{
			var a = new List<T1>();
			var b = new List<T2>();

			foreach (var tuple in zipped)
			{
				a.Add(tuple.Item1);
				b.Add(tuple.Item2);
			}

			return Tuple.Create(
				(IEnumerable<T1>)a,
				(IEnumerable<T2>)b
			);
		}

		public Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>> UnZip<T1, T2, T3>(IEnumerable<Tuple<T1, T2, T3>> zipped)
		{
			var a = new List<T1>();
			var b = new List<T2>();
			var c = new List<T3>();

			foreach (var tuple in zipped)
			{
				a.Add(tuple.Item1);
				b.Add(tuple.Item2);
				c.Add(tuple.Item3);
			}

			return Tuple.Create(
				(IEnumerable<T1>)a,
				(IEnumerable<T2>)b,
				(IEnumerable<T3>)c
			);
		}

		public Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>> UnZip<T1, T2, T3, T4>(IEnumerable<Tuple<T1, T2, T3, T4>> zipped)
		{
			var a = new List<T1>();
			var b = new List<T2>();
			var c = new List<T3>();
			var d = new List<T4>();

			foreach (var tuple in zipped)
			{
				a.Add(tuple.Item1);
				b.Add(tuple.Item2);
				c.Add(tuple.Item3);
				d.Add(tuple.Item4);
			}

			return Tuple.Create(
				(IEnumerable<T1>)a,
				(IEnumerable<T2>)b,
				(IEnumerable<T3>)c,
				(IEnumerable<T4>)d
			);
		}

		public Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>> UnZip<T1, T2, T3, T4, T5>(IEnumerable<Tuple<T1, T2, T3, T4, T5>> zipped)
		{
			var a = new List<T1>();
			var b = new List<T2>();
			var c = new List<T3>();
			var d = new List<T4>();
			var e = new List<T5>();

			foreach (var tuple in zipped)
			{
				a.Add(tuple.Item1);
				b.Add(tuple.Item2);
				c.Add(tuple.Item3);
				d.Add(tuple.Item4);
				e.Add(tuple.Item5);
			}

			return Tuple.Create(
				(IEnumerable<T1>)a,
				(IEnumerable<T2>)b,
				(IEnumerable<T3>)c,
				(IEnumerable<T4>)d,
				(IEnumerable<T5>)e
			);
		}

		public Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>> UnZip<T1, T2, T3, T4, T5, T6>(IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>> zipped)
		{
			var a = new List<T1>();
			var b = new List<T2>();
			var c = new List<T3>();
			var d = new List<T4>();
			var e = new List<T5>();
			var f = new List<T6>();

			foreach (var tuple in zipped)
			{
				a.Add(tuple.Item1);
				b.Add(tuple.Item2);
				c.Add(tuple.Item3);
				d.Add(tuple.Item4);
				e.Add(tuple.Item5);
				f.Add(tuple.Item6);
			}

			return Tuple.Create(
				(IEnumerable<T1>)a,
				(IEnumerable<T2>)b,
				(IEnumerable<T3>)c,
				(IEnumerable<T4>)d,
				(IEnumerable<T5>)e,
				(IEnumerable<T6>)f
			);
		}

		public Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>> UnZip<T1, T2, T3, T4, T5, T6, T7>(IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>> zipped)
		{
			var a = new List<T1>();
			var b = new List<T2>();
			var c = new List<T3>();
			var d = new List<T4>();
			var e = new List<T5>();
			var f = new List<T6>();
			var g = new List<T7>();

			foreach (var tuple in zipped)
			{
				a.Add(tuple.Item1);
				b.Add(tuple.Item2);
				c.Add(tuple.Item3);
				d.Add(tuple.Item4);
				e.Add(tuple.Item5);
				f.Add(tuple.Item6);
				g.Add(tuple.Item7);
			}

			return Tuple.Create(
				(IEnumerable<T1>)a,
				(IEnumerable<T2>)b,
				(IEnumerable<T3>)c,
				(IEnumerable<T4>)d,
				(IEnumerable<T5>)e,
				(IEnumerable<T6>)f,
				(IEnumerable<T7>)g
			);
		}
	}
}
