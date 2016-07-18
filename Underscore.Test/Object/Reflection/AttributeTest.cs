using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Underscore.Object.Reflection;

namespace Underscore.Test.Object.Reflection
{
	[TestClass]
	public class AttributeTest
	{
		[AttributeUsage(AttributeTargets.All,AllowMultiple=true)]
		public class TestMultipleAttribute : Attribute 
		{
			public string Info { get; set; }
		}

		[AttributeUsage(AttributeTargets.All , AllowMultiple = true)]
		public class TestSingleAttribute : Attribute
		{
			public string Info { get; set; }
		}

		[TestSingle(Info="OnClass")]
		public class Person
		{

			[TestSingle(Info = "OnField")]
			public string Field { get; set; }

			[TestSingle(Info="OnProperty")]
			public string FirstName { get; set; }

			public string LastName { get; set; }

			public string NickName { get; set; }

			public string MiddleName { get; set; }

			public string Title { get; set; }

			public string Suffix { get; set; }

			public int Age { get; set; }

		}

		[TestMultiple(Info="First")]
		[TestMultiple(Info="Second")]
		class Employee
		{
			public string FirstName { get; set; }
			public string LastName { get; set; }
			public decimal Salary { get; set; }
		}

		class MixedAttributesExample 
		{
			[TestMultiple(Info="First")]
			[TestMultiple(Info="Second")]
			[TestSingle(Info="Single")]
			public string A { get; set; }
		}

		[TestMethod]
		public void AttributeHasCustomAttribute()
		{

			var testing = new Underscore.Object.Reflection.AttributeComponent(new MockUtilFunctionComponent());

			Assert.IsFalse(
				testing.Has<TestMultipleAttribute>(typeof(Person)) 
		   );

			Assert.IsFalse(
				testing.Has<TestMultipleAttribute>(new Person())
		   );

			Assert.IsFalse(
				testing.Has<TestMultipleAttribute>(null)
		   );

			var fnProp = typeof(Person).GetMember("FirstName").FirstOrDefault();

			Assert.IsFalse(
			   testing.Has<TestMultipleAttribute>(fnProp)
		   );

			Assert.IsTrue(
				testing.Has<TestSingleAttribute>(fnProp)
		   );

			var mp = typeof(MixedAttributesExample).GetMember("A").First();

			Assert.IsTrue(
				testing.Has<TestSingleAttribute>(mp)
		   );

			Assert.IsTrue(
				testing.Has<TestMultipleAttribute>(mp)
		   );

		}

		[TestMethod]
		public void AttributeGetCustomAttribute()
		{

			var testing = new AttributeComponent(new MockUtilFunctionComponent());

			var multiAttr = testing.Find<TestMultipleAttribute>(typeof(Person));

			Assert.IsNull(multiAttr);

			multiAttr = testing.Find<TestMultipleAttribute>(new Person());

			Assert.IsNull(multiAttr);

			multiAttr = testing.Find<TestMultipleAttribute>(null);

			var fnProp = typeof(Person).GetMember("FirstName").FirstOrDefault();

			multiAttr = testing.Find<TestMultipleAttribute>(fnProp);

			Assert.IsNull(multiAttr);

			var sattr = testing.Find<TestSingleAttribute>(fnProp);

			Assert.IsNotNull(sattr);
			Assert.AreEqual("OnProperty" , sattr.Info);

			var mp = typeof(MixedAttributesExample).GetMember("A").First();

			sattr = testing.Find<TestSingleAttribute>(mp);

			Assert.IsNotNull(sattr);
			Assert.AreEqual("Single" , sattr.Info);

			multiAttr = testing.Find<TestMultipleAttribute>(mp);

			Assert.IsNotNull(multiAttr);
			Assert.IsTrue("First" ==  multiAttr.Info  || "Second" == multiAttr.Info);
		}

		[TestMethod]
		public void AttributeGetCustomAttributes()
		{
			var testing = new AttributeComponent(new MockUtilFunctionComponent());

			var multiAttr = testing.All<TestMultipleAttribute>(typeof(Person));

			Assert.IsNotNull(multiAttr);
			Assert.AreEqual(0 , multiAttr.Count());

			multiAttr = testing.All<TestMultipleAttribute>(new Person());

			Assert.IsNotNull(multiAttr);
			Assert.AreEqual(0 , multiAttr.Count());

			multiAttr = testing.All<TestMultipleAttribute>(null);

			Assert.IsNotNull(multiAttr);
			Assert.AreEqual(0 , multiAttr.Count());

			var fnProp = typeof(Person).GetMember("FirstName").FirstOrDefault();
			multiAttr = testing.All<TestMultipleAttribute>(fnProp);

			Assert.IsNotNull(multiAttr);
			Assert.AreEqual(0 , multiAttr.Count());

			var sattr = testing.All<TestSingleAttribute>(fnProp);

			Assert.IsNotNull(sattr);
			Assert.AreEqual(1 , sattr.Count());
			Assert.AreEqual("OnProperty" , sattr.First().Info);

			var mp = typeof(MixedAttributesExample).GetMember("A").First();

			sattr = testing.All<TestSingleAttribute>(mp);

			Assert.IsNotNull(sattr);
			Assert.AreEqual(1 , sattr.Count());
			Assert.AreEqual("Single" , sattr.First().Info);

			multiAttr = testing.All<TestMultipleAttribute>(mp);

			Assert.IsNotNull(multiAttr);
			Assert.AreEqual(2 , multiAttr.Count());
			var firstOne = multiAttr.First().Info;
			var secondOne = multiAttr.Skip(1).First().Info;
			Assert.IsTrue("First" == firstOne || "Second" == firstOne);
			Assert.IsTrue("Second"  == secondOne || "First" == secondOne);
			Assert.IsTrue(firstOne != secondOne);
		}
	}
}
