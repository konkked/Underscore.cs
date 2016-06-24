using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Action;
using System.Linq;

namespace Underscore.Test.Action
{
    [TestClass]
    public class PartialTest
    {
        private static string Join( params string[ ] args )
        {
	        return string.Join(" ", args.Where(trg => trg != null));
        }

		private const string Arg1 = "a";
		private const string Arg2 = "b";
		private const string Arg3 = "c";
		private const string Arg4 = "d";
	    private const string Arg5 = "e";

	    private PartialComponent component;
		private string[] output;

		[TestInitialize]
	    public void Initialize()
		{
			component = new PartialComponent();
			output = new string[1];
		}


        #region BindPartialAction.Helpers

        private static Action<string, string, string, string, string> BindPartialActionTarget( string[ ] result, Func<string, string, string, string, string, string> fn )
        {
            return ( a, b, c, d, e ) => result[ 0 ] = fn( a, b, c, d, e );
        }

        private static Action<string, string, string, string> BindPartialActionTarget( string[ ] result, Func<string, string, string, string, string> fn )
        {
            return ( a, b, c, d ) => result[ 0 ] = fn( a, b, c, d );
        }

        private static Action<string, string, string> BindPartialActionTarget( string[ ] result, Func<string, string, string, string> fn )
        {
            return ( a, b, c ) => result[ 0 ] = fn( a, b, c );
        }

        #endregion

        #region BindPartialAction.Tests

		[TestMethod]
		public void Action_Bind_Partial_2Params1Given()
		{
			const string expected = "a b";

			Action<string, string> toBind = (a, b) => output[0] = Join(a, b);

			var binding = component.Partial(toBind, Arg1);
			binding(Arg2);

			var result = output[0];

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Action_Bind_Partial_3Params1Given()
		{
			const string expected = "a b c";

			Action<string, string, string> toBind = (a, b, c) => output[0] = Join(a, b, c);

			var binding = component.Partial(toBind, Arg1);
			binding(Arg2, Arg3);

			var result = output[0];

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Action_Bind_Partial_3Params2Given()
		{
			const string expected = "a b c";

			Action<string, string, string> toBind = (a, b, c) => output[0] = Join(a, b, c);

			var binding = component.Partial(toBind, Arg1, Arg2);
			binding(Arg3);

			var result = output[0];

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Action_Bind_Partial_4Params1Given()
		{
			const string expected = "a b c d";

			Action<string, string, string, string> toBind = (a, b, c, d) => output[0] = Join(a, b, c, d);

			var binding = component.Partial(toBind, Arg1);
			binding(Arg2, Arg3, Arg4);

			var result = output[0];

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Action_Bind_Partial_4Params2Given()
		{
			const string expected = "a b c d";

			Action<string, string, string, string> toBind = (a, b, c, d) => output[0] = Join(a, b, c, d);

			var binding = component.Partial(toBind, Arg1, Arg2);
			binding(Arg3, Arg4);

			var result = output[0];

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Action_Bind_Partial_4Params3Given()
		{
			const string expected = "a b c d";

			Action<string, string, string, string> toBind = (a, b, c, d) => output[0] = Join(a, b, c, d);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3);
			binding(Arg4);

			var result = output[0];

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
	    public void Action_Bind_Partial_5Params1Given()
	    {
			const string expected = "a b c d e";

			Action<string, string, string, string, string> toBind = (a, b, c, d, e) => output[0] = Join(a, b, c, d, e);

			var binding = component.Partial(toBind, Arg1);
			binding(Arg2, Arg3, Arg4, Arg5);

			var result = output[0];

			Assert.AreEqual(expected, result);
	    }

		[TestMethod]
		public void Action_Bind_Partial_5Params2Given()
		{
			const string expected = "a b c d e";

			Action<string, string, string, string, string> toBind = (a, b, c, d, e) => output[0] = Join(a, b, c, d, e);

			var binding = component.Partial(toBind, Arg1, Arg2);
			binding(Arg3, Arg4, Arg5);

			var result = output[0];

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Action_Bind_Partial_5Params3Given()
		{
			const string expected = "a b c d e";

			Action<string, string, string, string, string> toBind = (a, b, c, d, e) => output[0] = Join(a, b, c, d, e);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3);
			binding(Arg4, Arg5);

			var result = output[0];

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Action_Bind_Partial_5Params4Given()
		{
			const string expected = "a b c d e";

			Action<string, string, string, string, string> toBind = (a, b, c, d, e) => output[0] = Join(a, b, c, d, e);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4);
			binding(Arg5);

			var result = output[0];

			Assert.AreEqual(expected, result);
		}
        #endregion
    }
}
