using NUnit.Framework;
using Underscore.Object;
using Underscore.Object.Comparison;
using Underscore.Object.Reflection;

namespace Underscore.Test.Module
{
    [TestFixture]
    public class ObjectTest
    {

        [Test]
        public void ObjectCreate()
        {
            var property = new PropertyComponent();
            var example = new Underscore.Module.Object(
				new PropertyComponent(),
				new MethodComponent(),
				new FieldComponent(),
				new ConstructorComponent(),
				new TransposeComponent(),
				new AttributeComponent(),
				new DynamicComponent(),
                new EqualityComponent(property)
            ) ;
        }


        public class GenericConstructorTestObject<TParam>
        {
            public static string LastCalledMethod { get; private set; }

            public static string[] ArgumentsCalledWith { get; private set; }

            public GenericConstructorTestObject()
            {
                LastCalledMethod = "default";
            }

            public GenericConstructorTestObject(string arg1)
            {
                LastCalledMethod = "one parameter";
                ArgumentsCalledWith = new[] {arg1};
            }

            public GenericConstructorTestObject(string arg1, string arg2)
            {
                LastCalledMethod = "two parameters";
                ArgumentsCalledWith = new[] {arg1, arg2};
            }
        }

        public class GenericConstructorTestObjectTwo<TParam1,TParam2>
        {
            public static string LastCalledMethod { get; private set; }

            public static string[] ArgumentsCalledWith { get; private set; }

            public GenericConstructorTestObjectTwo()
            {
                LastCalledMethod = "default";
            }

            public GenericConstructorTestObjectTwo(string arg1)
            {
                LastCalledMethod = "one parameter";
                ArgumentsCalledWith = new[] { arg1 };
            }

            public GenericConstructorTestObjectTwo(string arg1, string arg2)
            {
                LastCalledMethod = "two parameters";
                ArgumentsCalledWith = new[] { arg1, arg2 };
            }
        }

        [Test]
        public void ObjectModule_NewGenericFromDefinition_OneTypeParameter()
        {
            var property = new PropertyComponent();
			var example = new Underscore.Module.Object(
				new PropertyComponent(),
				new MethodComponent(),
				new FieldComponent(),
				new ConstructorComponent(),
				new TransposeComponent(),
				new AttributeComponent(),
				new DynamicComponent(),
				new EqualityComponent(property)
			);

            var targeting = typeof (GenericConstructorTestObject<>);

            var defaultResult = (GenericConstructorTestObject<string>) example.NewGenericFromDefinition(targeting, typeof (string));
            Assert.AreEqual("default",GenericConstructorTestObject<string>.LastCalledMethod);

            var oneArgumentResult =
                (GenericConstructorTestObject<string>)
                    example.NewGenericFromDefinition(targeting, new[] {typeof (string)}, "arg1");

            Assert.AreEqual("one parameter", GenericConstructorTestObject<string>.LastCalledMethod);
            Assert.AreEqual("arg1",GenericConstructorTestObject<string>.ArgumentsCalledWith[0]);

            var twoArgumentResult =
                (GenericConstructorTestObject<string>)
                    example.NewGenericFromDefinition(typeof (GenericConstructorTestObject<>), new[] {typeof (string)},
                        "arg1", "arg2");

            Assert.AreEqual("two parameters", GenericConstructorTestObject<string>.LastCalledMethod);
            Assert.AreEqual("arg1", GenericConstructorTestObject<string>.ArgumentsCalledWith[0]);
            Assert.AreEqual("arg2", GenericConstructorTestObject<string>.ArgumentsCalledWith[1]);


            var twoArgumentResultSkipFirst =
                    (GenericConstructorTestObject<string>)
                        example.NewGenericFromDefinition(typeof(GenericConstructorTestObject<>), new[] { typeof(string) },
                           null, "arg2");

            Assert.AreEqual("two parameters", GenericConstructorTestObject<string>.LastCalledMethod);
            Assert.AreEqual(null, GenericConstructorTestObject<string>.ArgumentsCalledWith[0]);
            Assert.AreEqual("arg2", GenericConstructorTestObject<string>.ArgumentsCalledWith[1]);


            var twoArgumentResultSkipSecond =
                    (GenericConstructorTestObject<string>)
                        example.NewGenericFromDefinition(typeof(GenericConstructorTestObject<>), new[] { typeof(string) },
                           "arg1", null);

            Assert.AreEqual("two parameters", GenericConstructorTestObject<string>.LastCalledMethod);
            Assert.AreEqual("arg1", GenericConstructorTestObject<string>.ArgumentsCalledWith[0]);
            Assert.AreEqual(null, GenericConstructorTestObject<string>.ArgumentsCalledWith[1]);

        }

        [Test]
        public void ObjectModule_NewGenericFromDefinition_MatchingConstructorsWithObjects()
        {
            var property = new PropertyComponent();

			var example = new Underscore.Module.Object(
				new PropertyComponent(),
				new MethodComponent(),
				new FieldComponent(),
				new ConstructorComponent(),
				new TransposeComponent(),
				new AttributeComponent(),
				new DynamicComponent(),
				new EqualityComponent(property)
			);

            var targeting = typeof(GenericConstructorTestObjectTwo<,>);

            var defaultResult = (GenericConstructorTestObjectTwo<string, object>)example.NewGenericFromDefinition(targeting, typeof(string), typeof(object));
            Assert.AreEqual("default", GenericConstructorTestObjectTwo<string,object>.LastCalledMethod);

            var oneArgumentResult =
                (GenericConstructorTestObjectTwo<string,object>)
                    example.NewGenericFromDefinition(targeting, new[] { typeof(string), typeof(object) }, "arg1");

            Assert.AreEqual("one parameter", GenericConstructorTestObjectTwo<string,object>.LastCalledMethod);
            Assert.AreEqual("arg1", GenericConstructorTestObjectTwo<string,object>.ArgumentsCalledWith[0]);

            var twoArgumentResult =
                (GenericConstructorTestObjectTwo<string,object>)
                    example.NewGenericFromDefinition(typeof(GenericConstructorTestObjectTwo<,>), new[] { typeof(string), typeof(object) },
                        "arg1", "arg2");

            Assert.AreEqual("two parameters", GenericConstructorTestObjectTwo<string,object>.LastCalledMethod);
            Assert.AreEqual("arg1", GenericConstructorTestObjectTwo<string,object>.ArgumentsCalledWith[0]);
            Assert.AreEqual("arg2", GenericConstructorTestObjectTwo<string,object>.ArgumentsCalledWith[1]);


            var twoArgumentResultSkipFirst =
                    (GenericConstructorTestObjectTwo<string,object>)
                        example.NewGenericFromDefinition(typeof(GenericConstructorTestObjectTwo<,>), new[] { typeof(string) , typeof(object)},
                           null, "arg2");

            Assert.AreEqual("two parameters", GenericConstructorTestObjectTwo<string,object>.LastCalledMethod);
            Assert.AreEqual(null, GenericConstructorTestObjectTwo<string,object>.ArgumentsCalledWith[0]);
            Assert.AreEqual("arg2", GenericConstructorTestObjectTwo<string,object>.ArgumentsCalledWith[1]);


            var twoArgumentResultSkipSecond =
                    (GenericConstructorTestObjectTwo<string,object>)
                        example.NewGenericFromDefinition(typeof(GenericConstructorTestObjectTwo<,>), new[] { typeof(string), typeof(object) },
                           "arg1", null);

            Assert.AreEqual("two parameters", GenericConstructorTestObjectTwo<string,object>.LastCalledMethod);
            Assert.AreEqual("arg1", GenericConstructorTestObjectTwo<string,object>.ArgumentsCalledWith[0]);
            Assert.AreEqual(null, GenericConstructorTestObjectTwo<string,object>.ArgumentsCalledWith[1]);
        }
    }
}
