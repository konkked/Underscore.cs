using System;
using NUnit.Framework;
using System.Threading.Tasks;
using Underscore.Function;

namespace Underscore.Test.Function
{
    [TestFixture]
    public class ComposeTest 
    {
        private ComposeComponent component;

        [SetUp]
        public void Initialize()
        {
            component = new ComposeComponent();
        }

        public string Add(string l, string r) 
        {
            return l + r;
        }

        public Func<string,string> Add(string left) 
        {
            return (r) => left + r;
        }


        [Test]
        public void Function_Compose_Compose_2Arguments()
        {
            var composeResult = _.Function.Compose(
                    Add("1"),
                    Add("2")
           );

            var result = composeResult("0");

            Assert.AreEqual("210", result);
        }

        [Test]
        public void Function_Compose_Compose_3Arguments()
        {
            var composeResult = _.Function.Compose(
                    Add("1"),
                    Add("2"),
                    Add("3")
           );

            var result  = composeResult("0");

            Assert.AreEqual("3210", result);
        }

        [Test]
        public void Function_Compose_Compose_4Arguments()
        {
            var component = new ComposeComponent();

            var composeResult = _.Function.Compose(
                Add("1"),
                Add("2"),
                Add("3"),
                Add("4")
           );

            var result = composeResult("0");

            Assert.AreEqual("43210", result);
        }

        [Test]
        public void Function_Compose_Compose_5Arguments()
        {   
            var component = new ComposeComponent();

            var composeResult = _.Function.Compose (
                Add ("1"),    
                Add ("2"),
                Add ("3"),
                Add ("4"),
                Add ("5")
           );

            var result = composeResult("0");

            Assert.AreEqual("543210", result);
        }

        [Test]
        public void Function_Compose_Compose_6Arguments()
        {
            var composeResult = _.Function.Compose(
                Add("1"),
                Add("2"),
                Add("3"),
                Add("4"),
                Add("5"),
                Add("6")
           );

            var result = composeResult("0");

            Assert.AreEqual("6543210", result);
        }

        [Test]
        public void Function_Compose_Compose_7Arguments()
        {
            var composeResult = _.Function.Compose(
                Add("1"),
                Add("2"),
                Add("3"),
                Add("4"),
                Add("5"),
                Add("6"),
                Add("7")
           );

            var result = composeResult("0");

            Assert.AreEqual("76543210", result);
        }

        [Test]
        public void Function_Compose_Compose_8Arguments()
        {
            var composeResult = _.Function.Compose(
                Add("1"),
                Add("2"),
                Add("3"),
                Add("4"),
                Add("5"),
                Add("6"),
                Add("7"),
                Add("8")
           );

            var result = composeResult("0");

            Assert.AreEqual("876543210", result);
            
        }

        [Test]
        public void Function_Compose_Compose_9Arguments()
        {   
            var composeResult = _.Function.Compose(
                Add("1"),
                Add("2"),
                Add("3"),
                Add("4"),
                Add("5"),
                Add("6"),
                Add("7"),
                Add("8"),
                Add("9")
           );

            var result = composeResult("0");

            Assert.AreEqual("9876543210", result);
        }

        [Test]
        public void Function_Compose_Compose_10Arguments()
        {
            var composeResult = _.Function.Compose(
                Add("1"),
                Add("2"),
                Add("3"),
                Add("4"),
                Add("5"),
                Add("6"),
                Add("7"),
                Add("8"),
                Add("9"),
                Add("10")
           );

            var result = composeResult("0");

            Assert.AreEqual("109876543210", result);
        }

        [Test]
        public void Function_Compose_Compose_11Arguments()
        {
            var composeResult = _.Function.Compose(
                Add("1"),
                Add("2"),
                Add("3"),
                Add("4"),
                Add("5"),
                Add("6"),
                Add("7"),
                Add("8"),
                Add("9"),
                Add("10"),
                Add("11")
           );

            var result = composeResult("0");

            Assert.AreEqual("11109876543210", result);
        }

        [Test]
        public void Function_Compose_Compose_12Arguments()
        {
            var composeResult = _.Function.Compose(
                Add("1"),
                Add("2"),
                Add("3"),
                Add("4"),
                Add("5"),
                Add("6"),
                Add("7"),
                Add("8"),
                Add("9"),
                Add("10"),
                Add("11"),
                Add("12")
           );

            var result = composeResult("0");

            Assert.AreEqual("1211109876543210", result);
        }

        [Test]
        public void Function_Compose_Compose_13Arguments()
        {
            var composeResult = _.Function.Compose(
                Add("1"),
                Add("2"),
                Add("3"),
                Add("4"),
                Add("5"),
                Add("6"),
                Add("7"),
                Add("8"),
                Add("9"),
                Add("10"),
                Add("11"),
                Add("12"),
                Add("13")
           );

            var result = composeResult("0");

            Assert.AreEqual("131211109876543210", result);
        }

        [Test]
        public void Function_Compose_Compose_14Arguments()
        {
            var composeResult = _.Function.Compose(
                Add("1"),
                Add("2"),
                Add("3"),
                Add("4"),
                Add("5"),
                Add("6"),
                Add("7"),
                Add("8"),
                Add("9"),
                Add("10"),
                Add("11"),
                Add("12"),
                Add("13"),
                Add("14")
           );

            var result = composeResult("0");

            Assert.AreEqual("14131211109876543210", result);
        }

        [Test]
        public void Function_Compose_Compose_15Arguments()
        {
            var composeResult = _.Function.Compose(
                Add("1"),
                Add("2"),
                Add("3"),
                Add("4"),
                Add("5"),
                Add("6"),
                Add("7"),
                Add("8"),
                Add("9"),
                Add("10"),
                Add("11"),
                Add("12"),
                Add("13"),
                Add("14"),
                Add("15")
           );

            var result = composeResult("0");

            Assert.AreEqual("1514131211109876543210", result);
        }

        [Test]
        public void Function_Compose_Compose_16Arguments()
        {
            var composeResult = _.Function.Compose(
                Add("1"),
                Add("2"),
                Add("3"),
                Add("4"),
                Add("5"),
                Add("6"),
                Add("7"),
                Add("8"),
                Add("9"),
                Add("10"),
                Add("11"),
                Add("12"),
                Add("13"),
                Add("14"),
                Add("15"),
                Add("16")
           );

            var result = composeResult("0");

            Assert.AreEqual("161514131211109876543210", result);
        }

        [Test]
        public void Function_Compose_Compose_17Arguments()
        {
            var composeResult = _.Function.Compose(
                Add("1"),
                Add("2"),
                Add("3"),
                Add("4"),
                Add("5"),
                Add("6"),
                Add("7"),
                Add("8"),
                Add("9"),
                Add("10"),
                Add("11"),
                Add("12"),
                Add("13"),
                Add("14"),
                Add("15"),
                Add("16"),
                Add("17")
           );

            var result = composeResult("0");

            Assert.AreEqual("17161514131211109876543210", result);
        }
    }
}
