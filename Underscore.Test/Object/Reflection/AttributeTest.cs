using System;
using NUnit.Framework;
using System.Linq;
using Underscore.Object.Reflection;

namespace Underscore.Test.Object.Reflection
{
	[TestFixture]
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

		[Test]
		public void AttributeHasCustomAttribute()
		{
			Assert.IsFalse(
				_.Object.Attribute.Has<TestMultipleAttribute>(typeof(Person)) 
		   );

			Assert.IsFalse(
				_.Object.Attribute.Has<TestMultipleAttribute>(new Person())
		   );

			Assert.IsFalse(
				_.Object.Attribute.Has<TestMultipleAttribute>(null)
		   );

			var fnProp = typeof(Person).GetMember("FirstName").FirstOrDefault();

			Assert.IsFalse(
			   _.Object.Attribute.Has<TestMultipleAttribute>(fnProp)
		   );

			Assert.IsTrue(
				_.Object.Attribute.Has<TestSingleAttribute>(fnProp)
		   );

			var mp = typeof(MixedAttributesExample).GetMember("A").First();

			Assert.IsTrue(
				_.Object.Attribute.Has<TestSingleAttribute>(mp)
		   );

			Assert.IsTrue(
				_.Object.Attribute.Has<TestMultipleAttribute>(mp)
		   );

		}

		[Test]
		public void AttributeGetCustomAttribute()
		{
			var multiAttr = _.Object.Attribute.Find<TestMultipleAttribute>(typeof(Person));

			Assert.IsNull(multiAttr);

			multiAttr = _.Object.Attribute.Find<TestMultipleAttribute>(new Person());

			Assert.IsNull(multiAttr);

			multiAttr = _.Object.Attribute.Find<TestMultipleAttribute>(null);

			var fnProp = typeof(Person).GetMember("FirstName").FirstOrDefault();

			multiAttr = _.Object.Attribute.Find<TestMultipleAttribute>(fnProp);

			Assert.IsNull(multiAttr);

			var sattr = _.Object.Attribute.Find<TestSingleAttribute>(fnProp);

			Assert.IsNotNull(sattr);
			Assert.AreEqual("OnProperty" , sattr.Info);

			var mp = typeof(MixedAttributesExample).GetMember("A").First();

			sattr = _.Object.Attribute.Find<TestSingleAttribute>(mp);

			Assert.IsNotNull(sattr);
			Assert.AreEqual("Single" , sattr.Info);

			multiAttr = _.Object.Attribute.Find<TestMultipleAttribute>(mp);

			Assert.IsNotNull(multiAttr);
			Assert.IsTrue("First" ==  multiAttr.Info  || "Second" == multiAttr.Info);
		}

		[Test]
		public void AttributeGetCustomAttributes()
		{
			

			var multiAttr = _.Object.Attribute.All<TestMultipleAttribute>(typeof(Person));

			Assert.IsNotNull(multiAttr);
			Assert.AreEqual(0 , multiAttr.Count());

			multiAttr = _.Object.Attribute.All<TestMultipleAttribute>(new Person());

			Assert.IsNotNull(multiAttr);
			Assert.AreEqual(0 , multiAttr.Count());

			multiAttr = _.Object.Attribute.All<TestMultipleAttribute>(null);

			Assert.IsNotNull(multiAttr);
			Assert.AreEqual(0 , multiAttr.Count());

			var fnProp = typeof(Person).GetMember("FirstName").FirstOrDefault();
			multiAttr = _.Object.Attribute.All<TestMultipleAttribute>(fnProp);

			Assert.IsNotNull(multiAttr);
			Assert.AreEqual(0 , multiAttr.Count());

			var sattr = _.Object.Attribute.All<TestSingleAttribute>(fnProp);

			Assert.IsNotNull(sattr);
			Assert.AreEqual(1 , sattr.Count());
			Assert.AreEqual("OnProperty" , sattr.First().Info);

			var mp = typeof(MixedAttributesExample).GetMember("A").First();

			sattr = _.Object.Attribute.All<TestSingleAttribute>(mp);

			Assert.IsNotNull(sattr);
			Assert.AreEqual(1 , sattr.Count());
			Assert.AreEqual("Single" , sattr.First().Info);

			multiAttr = _.Object.Attribute.All<TestMultipleAttribute>(mp);

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
