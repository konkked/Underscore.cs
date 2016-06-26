using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Action;

namespace Underscore.Test.Action
{
    [TestClass]
    public class BindTest
    {
	    private BindComponent component;

	    [TestInitialize]
	    public void Initialize()
	    {
		    component = new BindComponent();
	    }


        #region Bind.Action


        private static readonly bool[] _didRun = new bool[5];


        // actual action is basically useless, 
        // but want it to do something so compiler doesn't just throw out a statement

        #region Bind.Action.TestHelpers

        public static void TestingAction<T0, T1, T2, T3, T4>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            _didRun[4] = true;
        }

        public static Action<T0, T1, T2, T3, T4> CreateTestingAction<T0, T1, T2, T3, T4>(int index, bool[] target)
        {
            return (a, b, c, d, e) =>
            {
                TestingAction(a, b, c, d, e);
                target[index] = true;
            };
        }

        public static void TestingAction<T0, T1, T2, T3>(T0 arg0, T1 arg1, T2 arg2, T3 arg3)
        {
            _didRun[3] = true;
        }

        public static Action<T0, T1, T2, T3> CreateTestingAction<T0, T1, T2, T3>(int index, bool[] target)
        {
            return (a, b, c, d) =>
            {
                TestingAction(a, b, c, d);
                target[index] = true;
            };
        }

        public static void TestingAction<T0, T1, T2>(T0 arg0, T1 arg1, T2 arg2)
        {
            _didRun[2] = true;
        }

        public static Action<T0, T1, T2> CreateTestingAction<T0, T1, T2>(int index, bool[] target)
        {
            return (a, b, c) =>
            {
                TestingAction(a, b, c);
                target[index] = true;
            };
        }

        public static void TestingAction<T0, T1>(T0 arg0, T1 arg1)
        {
            _didRun[1] = true;
        }

        public static Action<T0, T1> CreateTestingAction<T0, T1>(int index, bool[] target)
        {
            return ( a, b ) =>
            {
                TestingAction(a, b);
                target[index] = true;
            };
        }

        public static void TestingAction<T>(T value)
        {
            _didRun[0] = true;
        }

        public static Action<TParam> CreateTestingAction<TParam>(int index, bool[] target)
        {
            return a =>
            {
                TestingAction(a);
                target[index] = true;
            };
        }

        #endregion

		[TestMethod]
		public void Action_Bind_OneParameter()
		{
			var didRun = new bool[1];

			component.Bind(CreateTestingAction<string>(0, didRun), "").Invoke();

			foreach (var b in didRun)
				Assert.IsTrue(b, "One of the testing methods failed to execute");
		}

		[TestMethod]
		public void Action_Bind_2Parameters()
        {
	        var didRun = new bool[2];


			component.Bind(CreateTestingAction<string, string>(0, didRun), "a", "b").Invoke();
            //2 types
			component.Bind(CreateTestingAction<string, int>(1, didRun), "a", 1).Invoke();


            foreach ( var b in didRun )
                Assert.IsTrue( b, "One of the testing methods failed to execute" );
        }

		[TestMethod]
        public void Action_Bind_3Parameters()
        {
            var didRun = new bool[3];


			component.Bind(CreateTestingAction<string, string, string>(0, didRun), "a", "b", "c").Invoke();
            //2 types
			component.Bind(CreateTestingAction<string, int, string>(1, didRun), "a", 1, "b").Invoke();
            //3 types
			component.Bind(CreateTestingAction<string, int, char>(2, didRun), "a", 1, 'b').Invoke();


	        foreach (var b in didRun)
		        Assert.IsTrue(b, "One of the testing methods failed to execute");
        }

        [TestMethod]
        public void Action_Bind_4Parameters()
        {
            var didRun = new bool[4];


			component.Bind(CreateTestingAction<string, string, string, string>(0, didRun), "a", "b", "c", "d").Invoke();
            //2 types
			component.Bind(CreateTestingAction<string, int, string, int>(1, didRun), "a", 1, "b", 2).Invoke();
            //3 types
			component.Bind(CreateTestingAction<string, int, char, string>(2, didRun), "a", 1, 'b', "2").Invoke();
            //4 types
			component.Bind(CreateTestingAction<double, int, char, string>(3, didRun), 0.0, 1, 'b', "2").Invoke();

	        foreach (var b in didRun)
		        Assert.IsTrue(b, "One of the testing methods failed to execute");
        }
        #endregion
    }
}
