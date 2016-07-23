using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using NUnit.Framework;
using System.Threading.Tasks;
using Moq;
using System.Reflection;
using System.Linq;
using System.Runtime.InteropServices;
using Underscore.Function;
using Underscore.Object.Reflection;

namespace Underscore.Test.Object.Reflection
{
	[TestFixture]
	public class FieldTest
	{
#pragma warning disable 0649, 0169
		private class FieldMethodsTestFixture
		{
			public FieldMethodsTestFixture(int privateInt, string privateString)
			{
				ShouldntShowInt = privateInt;
				ShouldntShowString = privateString;
			}

			public FieldMethodsTestFixture()
			{
			}

			public string ShouldShowString;
			private string ShouldntShowString;

			public int ShouldShowInt;
			private int ShouldntShowInt;

			public string ShouldNotShowProperty { get; set; }
			private string ShouldNotShowPrivateProperty { get; set; }

			public void ShouldNotShow()
			{
			}
		}

#pragma warning restore 0649, 0169

		[Test]
		public void Object_Fields_All_TargetType()
		{

			

			var allPublicFields = _.Object.Field.All(typeof (FieldMethodsTestFixture));


			Assert.AreEqual(2, allPublicFields.Count());
			Assert.AreEqual(0, allPublicFields.Count(a => a.Name.StartsWith("Shouldnt")));
			Assert.AreEqual(0, allPublicFields.Count(a => a.FieldType == typeof (decimal)));
			Assert.AreEqual(0, allPublicFields.Count(a => a.FieldType == typeof (float)));
			Assert.AreEqual(1,
				allPublicFields.Count(a => a.Name == "ShouldShowString" && a.FieldType == typeof (string)));
			Assert.AreEqual(1, allPublicFields.Count(a => a.Name == "ShouldShowInt" && a.FieldType == typeof (int)));

		}


		[Test]
		public void Object_Fields_Has_TargetType_Name()
		{


			var boundTesting = _.Function.Partial<Type, string, bool>(_.Object.Field.Has, typeof (FieldMethodsTestFixture));

			//check the pub fields exist
			Assert.IsTrue(boundTesting("ShouldShowString"));
			//make sure it is not using the wrong default capitalization check
			Assert.IsFalse(boundTesting("shouldshowstring"));

			//check the private fields do not exist
			Assert.IsTrue(boundTesting("ShouldShowInt"));
			//check again the spelling match is working right
			Assert.IsFalse(boundTesting("shouldshowint"));

			//check the private fields
			Assert.IsFalse(boundTesting("ShouldntShowString"));
			Assert.IsFalse(boundTesting("ShouldntShowInt"));
		}


		[Test]
		public void Object_Fields_Has_TargetType_NameBindingFlags()
		{


			var boundTesting = _.Function.Partial<Type, string, BindingFlags, bool>(_.Object.Field.Has,
				typeof (FieldMethodsTestFixture));

			var publicInstance = BindingFlags.Instance | BindingFlags.Public;
			var protectedInstance = BindingFlags.Instance | BindingFlags.NonPublic;

			//check the pub fields exist when the flags are public default
			Assert.IsTrue(boundTesting("ShouldShowString", publicInstance));

			//make sure it is not using the wrong default capitalization check
			Assert.IsFalse(boundTesting("shouldshowstring", publicInstance));

			//make sure it is not showing when the flags do not match
			Assert.IsFalse(boundTesting("ShouldShowString", protectedInstance));


			//check the private fields do not exist
			Assert.IsTrue(boundTesting("ShouldShowInt", publicInstance));

			//check again the spelling match is working right
			Assert.IsFalse(boundTesting("shouldshowint", publicInstance));

			//again check to make sure is filtered when flags don't match
			Assert.IsFalse(boundTesting("ShoudShowInt", protectedInstance));

			//check the private fields
			Assert.IsTrue(boundTesting("ShouldntShowString", protectedInstance));
			Assert.IsTrue(boundTesting("ShouldntShowInt", protectedInstance));
		}

		[Test]
		public void Object_Fields_Has_TargetType_NameAndCaseSenstive()
		{

			var boundTesting = _.Function.Partial<Type, string, bool, bool>(_.Object.Field.Has,
				typeof (FieldMethodsTestFixture));

			//check the pub fields exist
			Assert.IsTrue(boundTesting("ShouldShowString", true));
			Assert.IsTrue(boundTesting("shouldshowstring", false));

			//check that case sensitive flag is actual working
			Assert.IsFalse(boundTesting("shouldshowstring", true));



			//check on the int property as well
			Assert.IsTrue(boundTesting("ShouldShowInt", true));
			Assert.IsTrue(boundTesting("shouldshowint", false));

			//check that case sensitive flag is actual working
			Assert.IsFalse(boundTesting("shouldshowsint", true));

			//check the private fields are not accessible
			Assert.IsFalse(boundTesting("ShouldntShowString", true));
			Assert.IsFalse(boundTesting("shouldntshowstring", false));

			Assert.IsFalse(boundTesting("ShouldntShowInt", true));
			Assert.IsFalse(boundTesting("shouldntshowint", false));

		}

		[Test]
		public void Object_Fields_Has_TargetType_NameAndCaseSenstiveBindingFlags()
		{

			var boundTesting = _.Function.Partial<Type, string, bool, BindingFlags, bool>(_.Object.Field.Has,
				typeof (FieldMethodsTestFixture));

			var publicInstance = BindingFlags.Instance | BindingFlags.Public;
			var nonpublicInstance = BindingFlags.Instance | BindingFlags.NonPublic;


			//check the pub fields exist
			Assert.IsTrue(boundTesting("ShouldShowString", true, publicInstance));
			Assert.IsTrue(boundTesting("shouldshowstring", false, publicInstance));

			//check that case sensitive flag is actual working
			Assert.IsFalse(boundTesting("shouldshowstring", true, publicInstance));

			//check that the binding flags are no showing public on non public lookup
			Assert.IsFalse(boundTesting("shouldshowstring", false, nonpublicInstance));


			//check on the int property as well
			Assert.IsTrue(boundTesting("ShouldShowInt", true, publicInstance));
			Assert.IsTrue(boundTesting("shouldshowint", false, publicInstance));

			//check that case sensitive flag is actual working
			Assert.IsFalse(boundTesting("shouldshowsint", true, publicInstance));

			//check the binding flags are not showing public on nonpublic lookup
			Assert.IsFalse(boundTesting("shouldshowint", false, nonpublicInstance));

			//check the private fields are not accessible when accessing public 
			Assert.IsFalse(boundTesting("ShouldntShowString", true, publicInstance));
			Assert.IsFalse(boundTesting("shouldntshowstring", false, publicInstance));

			//but are when accessing non-public
			Assert.IsTrue(boundTesting("ShouldntShowString", true, nonpublicInstance));
			Assert.IsTrue(boundTesting("shouldntshowstring", false, nonpublicInstance));

			//now do the same thing for the int fields
			//first make sure nothing shows on public lookup
			Assert.IsFalse(boundTesting("ShouldntShowInt", true, publicInstance));
			Assert.IsFalse(boundTesting("shouldntshowint", false, publicInstance));

			//then check if lookup works when checking protected fields
			Assert.IsTrue(boundTesting("ShouldntShowInt", true, nonpublicInstance));
			Assert.IsTrue(boundTesting("shouldntshowint", false, nonpublicInstance));

		}

		[Test]
		public void Object_Fields_All_Object()
		{

			

			var allPublicFields = _.Object.Field.All(new FieldMethodsTestFixture());


			Assert.AreEqual(2, allPublicFields.Count());
			Assert.AreEqual(0, allPublicFields.Count(a => a.Name.StartsWith("Shouldnt")));
			Assert.AreEqual(0, allPublicFields.Count(a => a.FieldType == typeof (decimal)));
			Assert.AreEqual(0, allPublicFields.Count(a => a.FieldType == typeof (float)));
			Assert.AreEqual(1,
				allPublicFields.Count(a => a.Name == "ShouldShowString" && a.FieldType == typeof (string)));
			Assert.AreEqual(1, allPublicFields.Count(a => a.Name == "ShouldShowInt" && a.FieldType == typeof (int)));

		}

		[Test]
		public void Object_Fields_Has_TargetObject_Name()
		{


			var boundTesting = _.Function.Partial<object, string, bool>(_.Object.Field.Has, new FieldMethodsTestFixture());

			//check the pub fields exist
			Assert.IsTrue(boundTesting("ShouldShowString"));
			//make sure it is not using the wrong default capitalization check
			Assert.IsFalse(boundTesting("shouldshowstring"));

			//check the private fields do not exist
			Assert.IsTrue(boundTesting("ShouldShowInt"));
			//check again the spelling match is working right
			Assert.IsFalse(boundTesting("shouldshowint"));

			//check the private fields
			Assert.IsFalse(boundTesting("ShouldntShowString"));
			Assert.IsFalse(boundTesting("ShouldntShowInt"));
		}

		[Test]
		public void Object_Fields_Has_TargetObject_NameBindingFlags()
		{


			var boundTesting = _.Function.Partial<object, string, BindingFlags, bool>(_.Object.Field.Has,
				new FieldMethodsTestFixture());

			var publicInstance = BindingFlags.Instance | BindingFlags.Public;
			var protectedInstance = BindingFlags.Instance | BindingFlags.NonPublic;

			//check the pub fields exist when the flags are public default
			Assert.IsTrue(boundTesting("ShouldShowString", publicInstance));

			//make sure it is not using the wrong default capitalization check
			Assert.IsFalse(boundTesting("shouldshowstring", publicInstance));

			//make sure it is not showing when the flags do not match
			Assert.IsFalse(boundTesting("ShouldShowString", protectedInstance));


			//check the private fields do not exist
			Assert.IsTrue(boundTesting("ShouldShowInt", publicInstance));

			//check again the spelling match is working right
			Assert.IsFalse(boundTesting("shouldshowint", publicInstance));

			//again check to make sure is filtered when flags don't match
			Assert.IsFalse(boundTesting("ShoudShowInt", protectedInstance));

			//check the private fields
			Assert.IsTrue(boundTesting("ShouldntShowString", protectedInstance));
			Assert.IsTrue(boundTesting("ShouldntShowInt", protectedInstance));
		}

		[Test]
		public void Object_Fields_Has_TargetObject_NameAndCaseSenstive()
		{

			var boundTesting = _.Function.Partial<object, string, bool, bool>(_.Object.Field.Has,
				new FieldMethodsTestFixture());

			//check the pub fields exist
			Assert.IsTrue(boundTesting("ShouldShowString", true));
			Assert.IsTrue(boundTesting("shouldshowstring", false));

			//check that case sensitive flag is actual working
			Assert.IsFalse(boundTesting("shouldshowstring", true));



			//check on the int property as well
			Assert.IsTrue(boundTesting("ShouldShowInt", true));
			Assert.IsTrue(boundTesting("shouldshowint", false));

			//check that case sensitive flag is actual working
			Assert.IsFalse(boundTesting("shouldshowsint", true));

			//check the private fields are not accessible
			Assert.IsFalse(boundTesting("ShouldntShowString", true));
			Assert.IsFalse(boundTesting("shouldntshowstring", false));

			Assert.IsFalse(boundTesting("ShouldntShowInt", true));
			Assert.IsFalse(boundTesting("shouldntshowint", false));

		}

		[Test]
		public void Object_Fields_Has_TargetObject_NameAndCaseSenstiveBindingFlags()
		{

			var boundTesting = _.Function.Partial<object, string, bool, BindingFlags, bool>(_.Object.Field.Has,
				new FieldMethodsTestFixture());

			var publicInstance = BindingFlags.Instance | BindingFlags.Public;
			var nonpublicInstance = BindingFlags.Instance | BindingFlags.NonPublic;


			//check the pub fields exist
			Assert.IsTrue(boundTesting("ShouldShowString", true, publicInstance));
			Assert.IsTrue(boundTesting("shouldshowstring", false, publicInstance));

			//check that case sensitive flag is actual working
			Assert.IsFalse(boundTesting("shouldshowstring", true, publicInstance));

			//check that the binding flags are no showing public on non public lookup
			Assert.IsFalse(boundTesting("shouldshowstring", false, nonpublicInstance));


			//check on the int property as well
			Assert.IsTrue(boundTesting("ShouldShowInt", true, publicInstance));
			Assert.IsTrue(boundTesting("shouldshowint", false, publicInstance));

			//check that case sensitive flag is actual working
			Assert.IsFalse(boundTesting("shouldshowsint", true, publicInstance));

			//check the binding flags are not showing public on nonpublic lookup
			Assert.IsFalse(boundTesting("shouldshowint", false, nonpublicInstance));

			//check the private fields are not accessible when accessing public 
			Assert.IsFalse(boundTesting("ShouldntShowString", true, publicInstance));
			Assert.IsFalse(boundTesting("shouldntshowstring", false, publicInstance));

			//but are when accessing non-public
			Assert.IsTrue(boundTesting("ShouldntShowString", true, nonpublicInstance));
			Assert.IsTrue(boundTesting("shouldntshowstring", false, nonpublicInstance));

			//now do the same thing for the int fields
			//first make sure nothing shows on public lookup
			Assert.IsFalse(boundTesting("ShouldntShowInt", true, publicInstance));
			Assert.IsFalse(boundTesting("shouldntshowint", false, publicInstance));

			//then check if lookup works when checking protected fields
			Assert.IsTrue(boundTesting("ShouldntShowInt", true, nonpublicInstance));
			Assert.IsTrue(boundTesting("shouldntshowint", false, nonpublicInstance));

		}


		[Test]
		public void Object_Fields_Find_TargetType_Name()
		{

			var target = typeof (FieldMethodsTestFixture);

			var bound = _.Function.Partial<Type, string, FieldInfo>(_.Object.Field.Find, target);

			//default should only show public instance fields by default
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldShowString"), bound("ShouldShowString"));
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldShowInt"), bound("ShouldShowInt"));

			//check the non public fields are being protected

			Assert.IsNull(bound("ShouldntShowString"));
			Assert.IsNull(bound("ShouldntShowInt"));


		}

		[Test]
		public void Object_Fields_Find_TargetType_NameBindingFlags()
		{
			var target = typeof (FieldMethodsTestFixture);

			var bound = _.Function.Partial<Type, string, BindingFlags, FieldInfo>(_.Object.Field.Find, target);

			var publicInstance = BindingFlags.Public | BindingFlags.Instance;
			var nonpublicInstance = BindingFlags.NonPublic | BindingFlags.Instance;

			//check positive cases
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldShowString", publicInstance),
				bound("ShouldShowString", publicInstance));
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldShowInt", publicInstance),
				bound("ShouldShowInt", publicInstance));

			//check that nonpublic fields aren't showing up when doing a search for public fields
			Assert.IsNull(bound("ShouldntShowString", publicInstance));
			Assert.IsNull(bound("ShouldntShowInt", publicInstance));

			//check that nonpublic fields show up when doing a nonpublic searched
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldntShowString", nonpublicInstance),
				bound("ShouldntShowString", nonpublicInstance));
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldntShowInt", nonpublicInstance),
				bound("ShouldntShowInt", nonpublicInstance));

			//check to make sure public fields aren't showing up when looking for nonpublic fields
			Assert.IsNull(bound("ShouldShowString", nonpublicInstance));
			Assert.IsNull(bound("ShouldShowInt", nonpublicInstance));

		}

		[Test]
		public void Object_Fields_Find_TargetType_NameBindingFlagsCaseSenstive()
		{
			var target = typeof (FieldMethodsTestFixture);

			var bound = _.Function.Partial<Type, string, bool, BindingFlags, FieldInfo>(_.Object.Field.Find, target);

			var publicInstance = BindingFlags.Public | BindingFlags.Instance;
			var nonpublicInstance = BindingFlags.NonPublic | BindingFlags.Instance;

			//check positive cases
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldShowString", publicInstance),
				bound("ShouldShowString", true, publicInstance));
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldShowString", publicInstance),
				bound("shouldshowstring", false, publicInstance));

			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldShowInt", publicInstance),
				bound("ShouldShowInt", true, publicInstance));
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldShowInt", publicInstance),
				bound("ShouldShowInt", false, publicInstance));

			//check to make sure the case sensitive search is being done correctly
			Assert.IsNull(bound("shouldshowstring", true, publicInstance));
			Assert.IsNull(bound("shouldntshowint", true, publicInstance));

			//check that nonpublic fields aren't showing up when doing a search for public fields
			Assert.IsNull(bound("ShouldntShowString", true, publicInstance));
			Assert.IsNull(bound("ShouldntShowInt", true, publicInstance));


			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldntShowString", nonpublicInstance),
				bound("ShouldntShowString", true, nonpublicInstance));
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldntShowString", nonpublicInstance),
				bound("shouldntshowstring", false, nonpublicInstance));

			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldntShowInt", nonpublicInstance),
				bound("ShouldntShowInt", true, nonpublicInstance));
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldntShowInt", nonpublicInstance),
				bound("shouldntshowint", false, nonpublicInstance));


			//check to make sure the case sensitive search is being done correctly
			Assert.IsNull(bound("shouldntshowstring", true, nonpublicInstance));
			Assert.IsNull(bound("shouldntshowint", true, nonpublicInstance));

			//check that public fields aren't showing up when doing a search for nonpublic fields
			Assert.IsNull(bound("ShoudShowString", true, nonpublicInstance));
			Assert.IsNull(bound("ShouldShowInt", true, nonpublicInstance));

		}


		[Test]
		public void Object_Fields_Find_TargetType_NameType()
		{

			var target = typeof (FieldMethodsTestFixture);

			var bound = _.Function.Partial<object, string, Type, FieldInfo>(_.Object.Field.Find, target);

			//default should only show public instance fields by default
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetProperty("ShouldShowString"),
				bound("ShouldShowString", typeof (string)));
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetProperty("ShouldShowInt"),
				bound("ShouldShowInt", typeof (int)));

			//check mismatching types
			Assert.IsNull(bound("ShouldShowString", typeof (int)));
			Assert.IsNull(bound("ShouldShowInt", typeof (string)));

			//check the non public fields are being protected

			Assert.IsNull(bound("ShouldntShowString", typeof (string)));
			Assert.IsNull(bound("ShouldntShowInt", typeof (int)));


		}

		[Test]
		public void Object_Fields_Find_TargetType_NameTypeBindingFlags()
		{
			var target = typeof (FieldMethodsTestFixture);

			var bound = _.Function.Partial<Type, string, Type, BindingFlags, FieldInfo>(_.Object.Field.Find, target);

			var publicInstance = BindingFlags.Public | BindingFlags.Instance;
			var nonpublicInstance = BindingFlags.NonPublic | BindingFlags.Instance;

			//check positive cases
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldShowString", publicInstance),
				bound("ShouldShowString", typeof (string), publicInstance));
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldShowInt", publicInstance),
				bound("ShouldShowInt", typeof (int), publicInstance));

			//check mismatching types
			Assert.IsNull(bound("ShouldShowString", typeof (int), publicInstance));
			Assert.IsNull(bound("ShouldShowInt", typeof (string), nonpublicInstance));

			//check that nonpublic fields aren't showing up when doing a search for public fields
			Assert.IsNull(bound("ShouldntShowString", typeof (string), publicInstance));
			Assert.IsNull(bound("ShouldntShowInt", typeof (int), publicInstance));


			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldntShowString", nonpublicInstance),
				bound("ShouldntShowString", typeof (string), nonpublicInstance));
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldntShowInt", nonpublicInstance),
				bound("ShouldntShowInt", typeof (int), nonpublicInstance));

			//check to make sure public fields aren't showing up when looking for nonpublic fields
			Assert.IsNull(bound("ShouldShowString", typeof (string), nonpublicInstance));
			Assert.IsNull(bound("ShouldShowInt", typeof (int), nonpublicInstance));

		}

		[Test]
		public void Object_Fields_Find_TargetType_NameTypeBindingFlagsCaseSenstive()
		{
			var target = typeof (FieldMethodsTestFixture);

			var bound = _.Function.Partial<Type, string, Type, bool, BindingFlags, FieldInfo>(_.Object.Field.Find,
				target);

			var publicInstance = BindingFlags.Public | BindingFlags.Instance;
			var nonpublicInstance = BindingFlags.NonPublic | BindingFlags.Instance;

			//check positive cases
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldShowString", publicInstance),
				bound("ShouldShowString", typeof (string), true, publicInstance));
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldShowString", publicInstance),
				bound("shouldshowstring", typeof (string), false, publicInstance));

			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldShowInt", publicInstance),
				bound("ShouldShowInt", typeof (int), true, publicInstance));
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldShowInt", publicInstance),
				bound("ShouldShowInt", typeof (int), false, publicInstance));

			//check to make sure the case sensitive search is being done correctly
			Assert.IsNull(bound("shouldshowstring", typeof (string), true, publicInstance));
			Assert.IsNull(bound("shouldntshowint", typeof (int), true, publicInstance));

			//check that nonpublic fields aren't showing up when doing a search for public fields
			Assert.IsNull(bound("ShouldntShowString", typeof (string), true, publicInstance));
			Assert.IsNull(bound("ShouldntShowInt", typeof (int), true, publicInstance));


			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldntShowString", nonpublicInstance),
				bound("ShouldntShowString", typeof (string), true, nonpublicInstance));
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldntShowString", nonpublicInstance),
				bound("shouldntshowstring", typeof (string), false, nonpublicInstance));

			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldntShowInt", nonpublicInstance),
				bound("ShouldntShowInt", typeof (int), true, nonpublicInstance));
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldntShowInt", nonpublicInstance),
				bound("shouldntshowint", typeof (int), false, nonpublicInstance));


			//check to make sure the case sensitive search is being done correctly
			Assert.IsNull(bound("shouldntshowstring", typeof (string), true, nonpublicInstance));
			Assert.IsNull(bound("shouldntshowint", typeof (int), true, nonpublicInstance));

			//check that public fields aren't showing up when doing a search for nonpublic fields
			Assert.IsNull(bound("ShoudShowString", typeof (string), true, nonpublicInstance));
			Assert.IsNull(bound("ShouldShowInt", typeof (string), true, nonpublicInstance));

		}


		[Test]
		public void Object_Fields_OfType_TargetType()

		{
			var target = typeof (FieldMethodsTestFixture);


			var result = _.Object.Field.OfType(target, typeof (int));
			Assert.IsTrue(result.Any(a => a == typeof (FieldMethodsTestFixture).GetField("ShouldShowInt")));
			Assert.IsFalse(result.Any(a => a == typeof (FieldMethodsTestFixture).GetField("ShouldShowString")));
			Assert.AreEqual(1, result.Count());

			result = _.Object.Field.OfType(target, typeof (string));
			Assert.IsTrue(result.Any(a => a == typeof (FieldMethodsTestFixture).GetField("ShouldShowString")));
			Assert.IsFalse(result.Any(a => a == typeof (FieldMethodsTestFixture).GetField("ShouldShowInt")));
			Assert.AreEqual(1, result.Count());
		}

		[Test]
		public void Object_Field_OfType_TargetType_BindingFlags()
		{
			var target = typeof(FieldMethodsTestFixture);

			var publicInstance = BindingFlags.Public | BindingFlags.Instance;
			var nonpublicInstance = BindingFlags.NonPublic | BindingFlags.Instance;


			var result = _.Object.Field.OfType(target, typeof(int), publicInstance);

			Assert.IsTrue(result.Any(a => a == typeof(FieldMethodsTestFixture).GetField("ShouldShowInt")));

			//check it doesn't pick up the wrong type
			Assert.IsFalse(result.Any(a => a == typeof(FieldMethodsTestFixture).GetField("ShouldShowString")));

			//and that it doesn't pick up the wrong accesiblity
			Assert.IsFalse(result.Any(a => a == typeof(FieldMethodsTestFixture).GetField("ShouldntShowInt")));

			//check that the only field it did pick up was the right one
			Assert.AreEqual(1, result.Count());


			//check less accessible string 
			result = _.Object.Field.OfType(target, typeof(int), nonpublicInstance);

			//check the right one was found
			Assert.IsTrue(result.Any(a => a == typeof(FieldMethodsTestFixture).GetField("ShouldntShowInt", nonpublicInstance)));

			//check wrong type didn't happen
			Assert.IsFalse(result.Any(a => a == typeof(FieldMethodsTestFixture).GetField("ShouldntShowString")));

			//check that the wrong accesiblity wasn't picked up
			Assert.IsFalse(result.Any(a => a == typeof(FieldMethodsTestFixture).GetField("ShouldShowInt")));

			//check that was the only field picked up
			Assert.AreEqual(1, result.Count());

		}

		[Test]
		public void Object_Fields_Values_Generic()
		{
			var target = new FieldMethodsTestFixture();

			target.ShouldShowInt = 1;
			target.ShouldShowString = "A String";

			var allInts = _.Object.Field.Values<int>(target);

			Assert.IsTrue(allInts.Any(a => a == target.ShouldShowInt));
			Assert.AreEqual(1, allInts.Count());

			var allStrings = _.Object.Field.Values<string>(target);

			Assert.IsTrue(allStrings.Any(a => a == target.ShouldShowString));
			Assert.AreEqual(1, allStrings.Count());

			//check that a field with no matching properties does not magically produce one

			var allDecimals = _.Object.Field.Values<decimal>(target);
			Assert.IsTrue(!allDecimals.Any());
		}


		[Test]
		public void Object_Fields_Values_GenericBindingFlags()
		{
			int privateInt = -1;
			string privateString = "private string";
			var target = new FieldMethodsTestFixture(privateInt, privateString);

			target.ShouldShowInt = 1;
			target.ShouldShowString = "A String";

			var publicInstance = BindingFlags.Public | BindingFlags.Instance;
			var nonpublicInstance = BindingFlags.NonPublic | BindingFlags.Instance;

			var publicInts = _.Object.Field.Values<int>(target, publicInstance);

			Assert.IsTrue(publicInts.Any(a => a == target.ShouldShowInt));
			Assert.AreEqual(1, publicInts.Count());

			var privateInts = _.Object.Field.Values<int>(target, nonpublicInstance);


			Assert.IsTrue(privateInts.Any(a => a == privateInt));
			Assert.AreEqual(1, privateInts.Count());


			var publicStrings = _.Object.Field.Values<string>(target, publicInstance);

			Assert.IsTrue(publicStrings.Any(a => a == target.ShouldShowString));
			Assert.AreEqual(1, publicStrings.Count());

			var privateStrings = _.Object.Field.Values<string>(target, nonpublicInstance);

			Assert.IsTrue(privateStrings.Any(a => a == privateString));
			Assert.AreEqual(1, privateStrings.Count());

			//check that a field with no matching fields does not magically produce one

			var allDecimals = _.Object.Field.Values<decimal>(target, publicInstance);
			Assert.IsTrue(!allDecimals.Any());
		}

		[Test]
		public void Object_Fields_Values_NonGeneric()
		{
			var target = new FieldMethodsTestFixture();

			target.ShouldShowInt = 1;
			target.ShouldShowString = "A String";

			var allValues = _.Object.Field.Values(target);

			Assert.IsTrue(allValues.Any(a => a.Equals(target.ShouldShowInt)));
			Assert.IsTrue(allValues.Any(a => a.Equals(target.ShouldShowString)));
			Assert.AreEqual(2, allValues.Count());

		}

		[Test]
		public void Object_Fields_Values_NonGenericBindingFlags()
		{
			int privateInt = 1;
			string privateString = "private string";

			var target = new FieldMethodsTestFixture(privateInt, privateString);

			target.ShouldShowInt = 1;
			target.ShouldShowString = "A String";

			var publicInstance = BindingFlags.Instance | BindingFlags.Public;
			var nonpublicInstance = BindingFlags.Instance | BindingFlags.NonPublic;

			var allValues = _.Object.Field.Values(target, publicInstance);

			Assert.IsTrue(allValues.Any(a => a.Equals(target.ShouldShowInt)));
			Assert.IsTrue(allValues.Any(a => a.Equals(target.ShouldShowString)));
			Assert.AreEqual(2, allValues.Count());


			var allNonPublicValues = _.Object.Field.Values(target, nonpublicInstance);
			Assert.IsTrue(allNonPublicValues.Any(a => a.Equals(privateInt)));
			Assert.IsTrue(allNonPublicValues.Any(a => a.Equals(privateString)));
			Assert.AreEqual(2, allNonPublicValues.Count());

		}

		[Test]
		public void Object_Fields_Find_TargetObject_Name()
		{

			var target = new FieldMethodsTestFixture();

			var bound = _.Function.Partial<object, string, FieldInfo>(_.Object.Field.Find, target);

			//default should only show public instance fields by default
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldShowString"), bound("ShouldShowString"));
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldShowInt"), bound("ShouldShowInt"));

			//check the non public fields are being protected

			Assert.IsNull(bound("ShouldntShowString"));
			Assert.IsNull(bound("ShouldntShowInt"));


		}

		[Test]
		public void Object_Fields_Find_TargetObject_NameBindingFlags()
		{
			var target = new FieldMethodsTestFixture();

			var bound = _.Function.Partial<object, string, BindingFlags, FieldInfo>(_.Object.Field.Find, target);

			var publicInstance = BindingFlags.Public | BindingFlags.Instance;
			var nonpublicInstance = BindingFlags.NonPublic | BindingFlags.Instance;

			//check positive cases
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldShowString", publicInstance),
				bound("ShouldShowString", publicInstance));
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldShowInt", publicInstance),
				bound("ShouldShowInt", publicInstance));

			//check that nonpublic fields aren't showing up when doing a search for public fields
			Assert.IsNull(bound("ShouldntShowString", publicInstance));
			Assert.IsNull(bound("ShouldntShowInt", publicInstance));

			//check that they do show up when doing a check against nonpublic fields
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldntShowString", nonpublicInstance),
				bound("ShouldntShowString", nonpublicInstance));
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldntShowInt", nonpublicInstance),
				bound("ShouldntShowInt", nonpublicInstance));

			//check to make sure public fields aren't showing up when looking for nonpublic fields
			Assert.IsNull(bound("ShouldShowString", nonpublicInstance));
			Assert.IsNull(bound("ShouldShowInt", nonpublicInstance));

		}

		[Test]
		public void Object_Fields_Find_TargetObject_NameBindingFlagsCaseSenstive()
		{
			var target = new FieldMethodsTestFixture();

			var bound = _.Function.Partial<object, string, bool, BindingFlags, FieldInfo>(_.Object.Field.Find, target);

			var publicInstance = BindingFlags.Public | BindingFlags.Instance;
			var nonpublicInstance = BindingFlags.NonPublic | BindingFlags.Instance;

			//check positive cases
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldShowString", publicInstance),
				bound("ShouldShowString", true, publicInstance));
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldShowString", publicInstance),
				bound("shouldshowstring", false, publicInstance));

			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldShowInt", publicInstance),
				bound("ShouldShowInt", true, publicInstance));
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldShowInt", publicInstance),
				bound("ShouldShowInt", false, publicInstance));

			//check to make sure the case sensitive search is being done correctly
			Assert.IsNull(bound("shouldshowstring", true, publicInstance));
			Assert.IsNull(bound("shouldntshowint", true, publicInstance));

			//check that nonpublic fields aren't showing up when doing a search for nonpublic fields
			Assert.IsNull(bound("ShouldntShowString", true, publicInstance));
			Assert.IsNull(bound("ShouldntShowInt", true, publicInstance));


			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldntShowString", nonpublicInstance),
				bound("ShouldntShowString", true, nonpublicInstance));
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldntShowString", nonpublicInstance),
				bound("shouldntshowstring", false, nonpublicInstance));

			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldntShowInt", nonpublicInstance),
				bound("ShouldntShowInt", true, nonpublicInstance));
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldntShowInt", nonpublicInstance),
				bound("ShouldntShowInt", false, nonpublicInstance));


			//check to make sure the case sensitive search is being done correctly
			Assert.IsNull(bound("shouldntshowstring", true, nonpublicInstance));
			Assert.IsNull(bound("shouldntshowint", true, nonpublicInstance));

			//check that public fields aren't showing up when doing a search for public fields
			Assert.IsNull(bound("ShoudShowString", true, nonpublicInstance));
			Assert.IsNull(bound("ShouldShowInt", true, nonpublicInstance));

		}

		[Test]
		public void Object_Fields_Find_TargetObject_NameType()
		{

			var target = new FieldMethodsTestFixture();

			var bound = _.Function.Partial<object, string, Type, FieldInfo>(_.Object.Field.Find, target);

			//default should only show public instance fields by default
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldShowString"),
				bound("ShouldShowString", typeof (string)));
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldShowInt"),
				bound("ShouldShowInt", typeof (int)));

			//check mismatching types
			Assert.IsNull(bound("ShouldShowString", typeof (int)));
			Assert.IsNull(bound("ShouldShowInt", typeof (string)));

			//check the non public fields are being protected

			Assert.IsNull(bound("ShouldntShowString", typeof (string)));
			Assert.IsNull(bound("ShouldntShowInt", typeof (int)));


		}

		[Test]
		public void Object_Fields_Find_TargetObject_NameTypeBindingFlags()
		{
			var target = new FieldMethodsTestFixture();

			var bound = _.Function.Partial<object, string, Type, BindingFlags, FieldInfo>(_.Object.Field.Find, target);

			var publicInstance = BindingFlags.Public | BindingFlags.Instance;
			var nonpublicInstance = BindingFlags.NonPublic | BindingFlags.Instance;

			//check positive cases
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldShowString", publicInstance),
				bound("ShouldShowString", typeof (string), publicInstance));
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldShowInt", publicInstance),
				bound("ShouldShowInt", typeof (int), publicInstance));

			//check mismatching types
			Assert.IsNull(bound("ShouldShowString", typeof (int), publicInstance));
			Assert.IsNull(bound("ShouldShowInt", typeof (string), nonpublicInstance));

			//check that nonpublic fields aren't showing up when doing a search for public fields
			Assert.IsNull(bound("ShouldntShowString", typeof (string), publicInstance));
			Assert.IsNull(bound("ShouldntShowInt", typeof (int), publicInstance));


			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldntShowString", nonpublicInstance),
				bound("ShouldntShowString", typeof (string), nonpublicInstance));
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldntShowInt", nonpublicInstance),
				bound("ShouldntShowInt", typeof (int), nonpublicInstance));

			//check to make sure public fields aren't showing up when looking for nonpublic fields
			Assert.IsNull(bound("ShouldShowString", typeof (string), nonpublicInstance));
			Assert.IsNull(bound("ShouldShowInt", typeof (int), nonpublicInstance));

		}

		[Test]
		public void Object_Fields_Find_TargetObject_NameTypeBindingFlagsCaseSenstive()
		{
			var target = new FieldMethodsTestFixture();

			var bound = _.Function.Partial<object, string, Type, bool, BindingFlags, FieldInfo>(_.Object.Field.Find,
				target);

			var publicInstance = BindingFlags.Public | BindingFlags.Instance;
			var nonpublicInstance = BindingFlags.NonPublic | BindingFlags.Instance;

			//check positive cases
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldShowString", publicInstance),
				bound("ShouldShowString", typeof (string), true, publicInstance));
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldShowString", publicInstance),
				bound("shouldshowstring", typeof (string), false, publicInstance));

			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldShowInt", publicInstance),
				bound("ShouldShowInt", typeof (int), true, publicInstance));
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldShowInt", publicInstance),
				bound("ShouldShowInt", typeof (int), false, publicInstance));

			//check to make sure the case sensitive search is being done correctly
			Assert.IsNull(bound("shouldshowstring", typeof (string), true, publicInstance));
			Assert.IsNull(bound("shouldntshowint", typeof (int), true, publicInstance));

			//check that nonpublic fields aren't showing up when doing a search for public fields
			Assert.IsNull(bound("ShouldntShowString", typeof (string), true, publicInstance));
			Assert.IsNull(bound("ShouldntShowInt", typeof (int), true, publicInstance));

			//check nonpublic can be accessed
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldntShowString", nonpublicInstance),
				bound("ShouldntShowString", typeof (string), true, nonpublicInstance));
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldntShowString", nonpublicInstance),
				bound("shouldntshowstring", typeof (string), false, nonpublicInstance));

			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldntShowInt", nonpublicInstance),
				bound("ShouldntShowInt", typeof (int), true, nonpublicInstance));
			Assert.AreEqual(typeof (FieldMethodsTestFixture).GetField("ShouldntShowInt", nonpublicInstance),
				bound("shouldntshowint", typeof (int), false, nonpublicInstance));


			//check to make sure the case sensitive search is being done correctly
			Assert.IsNull(bound("shouldntshowstring", typeof (string), true, nonpublicInstance));
			Assert.IsNull(bound("shouldntshowint", typeof (int), true, nonpublicInstance));

			//check that public fields aren't showing up when doing a search for public fields
			Assert.IsNull(bound("ShoudShowString", typeof (string), true, nonpublicInstance));
			Assert.IsNull(bound("ShouldShowInt", typeof (string), true, nonpublicInstance));

		}


		[Test]
		public void Object_Fields_OfType_TargetObject()

		{
			var target = new FieldMethodsTestFixture();


			var result = _.Object.Field.OfType(target, typeof (int));
			Assert.IsTrue(result.Any(a => a == typeof (FieldMethodsTestFixture).GetField("ShouldShowInt")));
			Assert.IsFalse(result.Any(a => a == typeof (FieldMethodsTestFixture).GetField("ShouldShowString")));
			Assert.AreEqual(1, result.Count());

			result = _.Object.Field.OfType(target, typeof (string));
			Assert.IsTrue(result.Any(a => a == typeof (FieldMethodsTestFixture).GetField("ShouldShowString")));
			Assert.IsFalse(result.Any(a => a == typeof (FieldMethodsTestFixture).GetField("ShouldShowInt")));
			Assert.AreEqual(1, result.Count());
		}


		[Test]
		public void Object_Field_OfType_TargetObject_BindingFlags()
		{
			var target = new FieldMethodsTestFixture();

			var publicInstance = BindingFlags.Public | BindingFlags.Instance;
			var nonpublicInstance = BindingFlags.NonPublic | BindingFlags.Instance;


			var result = _.Object.Field.OfType(target, typeof (int), publicInstance);

			Assert.IsTrue(result.Any(a => a == typeof (FieldMethodsTestFixture).GetField("ShouldShowInt")));

			//check it doesn't pick up the wrong type
			Assert.IsFalse(result.Any(a=>a == typeof(FieldMethodsTestFixture).GetField("ShouldShowString")));

			//and that it doesn't pick up the wrong accesiblity
			Assert.IsFalse(result.Any(a => a == typeof (FieldMethodsTestFixture).GetField("ShouldntShowInt")));

			//check that the only field it did pick up was the right one
			Assert.AreEqual(1,result.Count());


			//check less accessible string 
			result = _.Object.Field.OfType(target, typeof (int), nonpublicInstance);

			//check the right one was found
			Assert.IsTrue(result.Any(a=>a == typeof(FieldMethodsTestFixture).GetField("ShouldntShowInt",nonpublicInstance)));

			//check wrong type didn't happen
			Assert.IsFalse(result.Any(a => a == typeof (FieldMethodsTestFixture).GetField("ShouldntShowString")));

			//check that the wrong accesiblity wasn't picked up
			Assert.IsFalse(result.Any(a=>a == typeof(FieldMethodsTestFixture).GetField("ShouldShowInt")));

			//check that was the only field picked up
			Assert.AreEqual(1,result.Count());

		}


	[Test]
		public async Task ObjectField()
		{
			var target = new FieldMethodsTestFixture();

			

			await Util.Tasks.Start(() =>
			{
				//test true one public string field
				//test no type
				//test with type
				//test not with wrong type
				//test not private method

				var showFieldNoArgs = _.Object.Field.Find(target, "ShouldShowString");
				var showFieldTypeArgs = _.Object.Field.Find(target, "ShouldShowString", typeof(string));
				var shouldNotShowFieldWrongArgs = _.Object.Field.Find(target, "ShouldShowString", typeof(int));
				var shouldntShowFieldPrivate = _.Object.Field.Find(target, "ShoulntShowString");
				var shouldntShowFieldPrivateWrongType = _.Object.Field.Find(target, "ShoulntShowString", typeof(string));

				Assert.IsNotNull(showFieldNoArgs);

				foreach (var item in new[ ] { showFieldTypeArgs })
					Assert.AreEqual(showFieldNoArgs, item);

				foreach (var item in new[ ] { shouldNotShowFieldWrongArgs, shouldntShowFieldPrivate, shouldntShowFieldPrivateWrongType })
					Assert.IsNull(item);

			}, () =>
			{
				//test true one public int field
				//test no type
				//test with type
				//test not with wrong type
				//test not private method

				var showFieldNoArgs = _.Object.Field.Find(target, "ShouldShowInt");
				var showFieldTypeArgs = _.Object.Field.Find(target, "ShouldShowInt", typeof(int));
				var shouldNotShowFieldWrongArgs = _.Object.Field.Find(target, "ShouldntShowInt", typeof(string));
				var shouldntShowFieldPrivate = _.Object.Field.Find(target, "ShouldntShowInt");
				var shouldntShowFieldPrivateWrongType = _.Object.Field.Find(target, "ShouldintShowInt", typeof(string));

				Assert.IsNotNull(showFieldNoArgs);

				foreach (var item in new[ ] { showFieldTypeArgs })
					Assert.AreEqual(showFieldNoArgs, item);

				foreach (var item in new[ ] { shouldNotShowFieldWrongArgs, shouldntShowFieldPrivate, shouldntShowFieldPrivateWrongType })
					Assert.IsNull(item);
			}, () =>
			{
				//test true no properties picked up

				//shouldnt show properties
				Assert.IsNull(_.Object.Field.Find(target, "ShouldNotShowProperty"));
				Assert.IsNull(_.Object.Field.Find(target, "ShouldNotShowProperty", typeof(int)));
				Assert.IsNull(_.Object.Field.Find(target, "ShouldNotShowProperty", typeof(string)));
			});
		}

		[Test]
		public async Task TypeField()
		{
			var target = typeof(FieldMethodsTestFixture);

			

			await Util.Tasks.Start(() =>
			{
				//test true one public string field
				//test no type
				//test with type
				//test not with wrong type
				//test not private method

				var showFieldNoArgs = _.Object.Field.Find(target, "ShouldShowString");
				var showFieldTypeArgs = _.Object.Field.Find(target, "ShouldShowString", typeof(string));
				var shouldNotShowFieldWrongArgs = _.Object.Field.Find(target, "ShouldShowString", typeof(int));
				var shouldntShowFieldPrivate = _.Object.Field.Find(target, "ShoulntShowString");
				var shouldntShowFieldPrivateWrongType = _.Object.Field.Find(target, "ShoulntShowString", typeof(string));

				Assert.IsNotNull(showFieldNoArgs);

				foreach (var item in new[] { showFieldTypeArgs })
					Assert.AreEqual(showFieldNoArgs, item);

				foreach (var item in new[] { shouldNotShowFieldWrongArgs, shouldntShowFieldPrivate, shouldntShowFieldPrivateWrongType })
					Assert.IsNull(item);
			}, () =>
			{
				//test true one public int field
				//test no type
				//test with type
				//test not with wrong type
				//test not private method

				var showFieldNoArgs = _.Object.Field.Find(target, "ShouldShowInt");
				var showFieldTypeArgs = _.Object.Field.Find(target, "ShouldShowInt", typeof(int));
				var shouldNotShowFieldWrongArgs = _.Object.Field.Find(target, "ShouldntShowInt", typeof(string));
				var shouldntShowFieldPrivate = _.Object.Field.Find(target, "ShouldntShowInt");
				var shouldntShowFieldPrivateWrongType = _.Object.Field.Find(target, "ShouldintShowInt", typeof(string));

				Assert.IsNotNull(showFieldNoArgs);

				foreach (var item in new[] { showFieldTypeArgs })
					Assert.AreEqual(showFieldNoArgs, item);

				foreach (var item in new[] { shouldNotShowFieldWrongArgs, shouldntShowFieldPrivate, shouldntShowFieldPrivateWrongType })
					Assert.IsNull(item);
			}, () =>
			{
				//test true no properties picked up

				//shouldnt show properties
				Assert.IsNull(_.Object.Field.Find(target, "ShouldNotShowProperty"));
				Assert.IsNull(_.Object.Field.Find(target, "ShouldNotShowProperty", typeof(int)));
				Assert.IsNull(_.Object.Field.Find(target, "ShouldNotShowProperty", typeof(string)));
			});

		}

#pragma warning disable 0414

		public class FieldValuesTest
		{
			public string Value1 = "Value1",
				Value2 = "Value2",
				Value3 = "Value3";

			private string PrivateValue1 = "PrivateValue1",
				PrivateValue2 = "PrivateValue2",
				PrivateValue3 = "PrivateValue3";

			public int IntValue1 = 1;
			private int PrivateIntValue1=-1;

			public static int IntValueStatic = 12;
			private static int IntValuePrivateStatic = 122;
		}

#pragma warning restore 0414

		[Test]
		public void FieldValuesPublicStr()
		{
			

			var instance = new FieldValuesTest();

			var testingSets = new[]
			{
				_.Object.Field.Values<string>(instance).ToList(),
				_.Object.Field.Values<string>(instance, BindingFlags.Instance | BindingFlags.Public).ToList(),

			};

			foreach (var pblStrResultLs in testingSets)
			{
				var pblStrResult = new HashSet<string>(pblStrResultLs);
				Assert.AreEqual(3, pblStrResult.Count);

				Assert.IsTrue(pblStrResult.Contains("Value1"));
				Assert.IsTrue(pblStrResult.Contains("Value2"));
				Assert.IsTrue(pblStrResult.Contains("Value3"));

				Assert.IsFalse(pblStrResult.Contains("PrivateValue1"));
				Assert.IsFalse(pblStrResult.Contains("PrivateValue2"));
				Assert.IsFalse(pblStrResult.Contains("PrivateValue3"));

				Assert.AreEqual("Value1Value2Value3", string.Join("", pblStrResultLs));

			}

		}

		[Test]
		public void FieldValuesPrivateStr()
		{
			

			var instance = new FieldValuesTest();
			var resultLs = _.Object.Field.Values<string>(instance, BindingFlags.NonPublic | BindingFlags.Instance).ToList();
			var resultSet = new HashSet<string>(resultLs);
			Assert.AreEqual(3, resultSet.Count);

			Assert.IsTrue(resultSet.Contains("PrivateValue1"));
			Assert.IsTrue(resultSet.Contains("PrivateValue2"));
			Assert.IsTrue(resultSet.Contains("PrivateValue3"));

			Assert.IsFalse(resultSet.Contains("Value1"));
			Assert.IsFalse(resultSet.Contains("Value2"));
			Assert.IsFalse(resultSet.Contains("Value3"));

			Assert.AreEqual("PrivateValue1PrivateValue2PrivateValue3", string.Join("", resultLs));

		}

		[Test]
		public void FieldValuesPublicInt()
		{
			

			var instance = new FieldValuesTest();
			var resultLs = _.Object.Field.Values<int>(instance).ToList();
			var resultSt = new HashSet<int>(resultLs);
			Assert.AreEqual(1, resultSt.Count);

			Assert.IsTrue(resultSt.Contains(1));

		}

		[Test]
		public void FieldValuesPrivateInt()
		{
			

			var instance = new FieldValuesTest();
			var resultLs = _.Object.Field.Values<int>(instance, BindingFlags.NonPublic | BindingFlags.Instance).ToList();
			var resultSt = new HashSet<int>(resultLs);
			Assert.AreEqual(1, resultSt.Count);

			Assert.IsTrue(resultSt.Contains(-1));

		}

		[Test]
		public void FieldValuesStaticInt()
		{
			

			var instance = new FieldValuesTest();
			var resultls = _.Object.Field.Values<int>(instance, BindingFlags.Public | BindingFlags.Static).ToList();
			var resultSet = new HashSet<int>(resultls);
			Assert.AreEqual(1, resultSet.Count);

			Assert.IsTrue(resultSet.Contains(12));

		}

		[Test]
		public void FieldValuesPrivateStaticInt()
		{
			

			var instance = new FieldValuesTest();
			var resultLs = _.Object.Field.Values<int>(instance, BindingFlags.NonPublic | BindingFlags.Static).ToList();
			var resultSet = new HashSet<int>(resultLs);
			Assert.AreEqual(1, resultSet.Count);

			Assert.IsTrue(resultSet.Contains(122));

		}

	}
}
