using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Underscore.Utility;

namespace Underscore.Test.Utility
{
    [TestClass]
    public class CompactTest
    {
        private CompactComponent component;

        [TestInitialize]
        public void Initialize()
        {
            component = new CompactComponent();
        }

        [TestMethod]
        public void Utility_Compact_Pack_2Arguments()
        {
            var expected = Tuple.Create(1, 2);
            var result = component.Pack(1, 2);

            Assert.IsTrue(expected.Equals(result));
        }

        [TestMethod]
        public void Utility_Compact_Pack_3Arguments()
        {
            var expected = Tuple.Create(1, 2, 3);
            var result = component.Pack(1, 2, 3);

            Assert.IsTrue(expected.Equals(result));
        }

        [TestMethod]
        public void Utility_Compact_Pack_4Arguments()
        {
            var expected = Tuple.Create(1, 2, 3, 4);
            var result = component.Pack(1, 2, 3, 4);

            Assert.IsTrue(expected.Equals(result));
        }

        [TestMethod]
        public void Utility_Compact_Pack_5Arguments()
        {
            var expected = Tuple.Create(Tuple.Create(1, 2, 3, 4), 5);
            var result = component.Pack(1, 2, 3, 4, 5);

            Assert.IsTrue(expected.Equals(result));
        }

        [TestMethod]
        public void Utility_Compact_Pack_6Arguments()
        {
            var expected = Tuple.Create(Tuple.Create(1, 2, 3, 4), 5, 6);
            var result = component.Pack(1, 2, 3, 4, 5, 6);

            Assert.IsTrue(expected.Equals(result));
        }

        [TestMethod]
        public void Utility_Compact_Pack_7Arguments()
        {
            var expected = Tuple.Create(Tuple.Create(1, 2, 3, 4), 5, 6, 7);
            var result = component.Pack(1, 2, 3, 4, 5, 6, 7);

            Assert.IsTrue(expected.Equals(result));
        }

        [TestMethod]
        public void Utility_Compact_Pack_8Arguments()
        {
            var expected = Tuple.Create(Tuple.Create(1, 2, 3, 4), Tuple.Create(5, 6, 7, 8));
            var result = component.Pack(1, 2, 3, 4, 5, 6, 7, 8);

            Assert.IsTrue(expected.Equals(result));
        }

        [TestMethod]
        public void Utility_Compact_Pack_9Arguments()
        {
            var expected = Tuple.Create(Tuple.Create(1, 2, 3, 4), Tuple.Create(5, 6, 7, 8), 9);
            var result = component.Pack(1, 2, 3, 4, 5, 6, 7, 8, 9);

            Assert.IsTrue(expected.Equals(result));
        }

        [TestMethod]
        public void Utility_Compact_Pack_10Arguments()
        {
            var expected = Tuple.Create(Tuple.Create(1, 2, 3, 4), Tuple.Create(5, 6, 7, 8), 9, 10);
            var result = component.Pack(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            Assert.IsTrue(expected.Equals(result));
        }

        [TestMethod]
        public void Utility_Compact_Pack_11Arguments()
        {
            var expected = Tuple.Create(Tuple.Create(1, 2, 3, 4), Tuple.Create(5, 6, 7, 8), 9, 10, 11);
            var result = component.Pack(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);

            Assert.IsTrue(expected.Equals(result));
        }

        [TestMethod]
        public void Utility_Compact_Pack_12Arguments()
        {
            var expected = Tuple.Create(Tuple.Create(1, 2, 3, 4), Tuple.Create(5, 6, 7, 8), Tuple.Create(9, 10, 11, 12));
            var result = component.Pack(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);

            Assert.IsTrue(expected.Equals(result));
        }

        [TestMethod]
        public void Utility_Compact_Pack_13Arguments()
        {
            var expected = Tuple.Create(Tuple.Create(1, 2, 3, 4), Tuple.Create(5, 6, 7, 8), Tuple.Create(9, 10, 11, 12), 13);
            var result = component.Pack(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);

            Assert.IsTrue(expected.Equals(result));
        }

        [TestMethod]
        public void Utility_Compact_Pack_14Arguments()
        {
            var expected = Tuple.Create(Tuple.Create(1, 2, 3, 4), Tuple.Create(5, 6, 7, 8), Tuple.Create(9, 10, 11, 12), 13, 14);
            var result = component.Pack(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);

            Assert.IsTrue(expected.Equals(result));
        }

        [TestMethod]
        public void Utility_Compact_Pack_15Arguments()
        {
            var expected = Tuple.Create(Tuple.Create(1, 2, 3, 4), Tuple.Create(5, 6, 7, 8), Tuple.Create(9, 10, 11, 12), 13, 14, 15);
            var result = component.Pack(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

            Assert.IsTrue(expected.Equals(result));
        }

        [TestMethod]
        public void Utility_Compact_Pack_16Arguments()
        {
            var expected = Tuple.Create(Tuple.Create(1, 2, 3, 4), Tuple.Create(5, 6, 7, 8), Tuple.Create(9, 10, 11, 12), Tuple.Create(13, 14, 15, 16));
            var result = component.Pack(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);

            Assert.IsTrue(expected.Equals(result));
        }
    }
}
