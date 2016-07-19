using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.Reflection;
using System.Linq;
using Underscore.Object.Reflection;

namespace Underscore.Test.Object.Reflection
{
	[TestClass]
	public class PropertyTest
	{
		public class Person
		{

			public string FirstName { get; set; }

			public string LastName { get; set; }

			public string NickName { get; set; }

			public string MiddleName { get; set; }

			public string Title { get; set; }

			public string Suffix { get; set; }

			public int Age { get; set; }

		}

		[TestMethod]
		public void Object_Property_Has()
		{

			var person = new Person();
			

			Assert.IsTrue(_.Object.Property.Has(person, "FirstName"));
			Assert.IsFalse(_.Object.Property.Has(person, "DoesNotHave"));
			Assert.IsTrue(_.Object.Property.Has(person, "firstname", false));
			Assert.IsFalse(_.Object.Property.Has(person, "firstname", true));

		}

		[TestMethod]
		public void Object_Property_Find()
		{
			var properties = typeof(Person).GetProperties(BindingFlags.Public | BindingFlags.Instance);
			var person = new Person();

			var _prop = new PropertyComponent();

			var expecting = properties.First(a => a.Name == "FirstName");
			var result = _.Object.Property.Find(person, "FirstName");
			Assert.AreEqual(expecting, result);

			result = _.Object.Property.Find(person, "firstname", false);
			Assert.AreEqual(expecting, result);

			result = _.Object.Property.Find(person, "DoesNotHave");

			Assert.IsNull(result);

			result = _prop.Find(person, "firstname", true);
			Assert.IsNull(result);

			result = _prop.Find(person, "firstname");
			Assert.IsNull(result);

		}


		[TestMethod]
		public void Object_Property_GetValue_Generic()
		{
			var person = new Person
			{
				FirstName = "FirstName",
				LastName = "LastName",
				MiddleName = "MiddleName",
				NickName = "NickName",
				Suffix = "Suffix",
				Title = "Title",
				Age = 24
			};

			int intExpecting = person.Age;
			int intResult = _.Object.Property.GetValue<int>(person, "Age");
			Assert.AreEqual(intExpecting, intResult);

			string expecting = person.FirstName;
			string result = _.Object.Property.GetValue<string>(person, "FirstName");
			Assert.AreEqual(expecting, result);

			expecting = person.MiddleName;
			result = _.Object.Property.GetValue<string>(person, "MiddleName");
			Assert.AreEqual(expecting, result);

			expecting = person.LastName;
			result = _.Object.Property.GetValue<string>(person, "LastName");
			Assert.AreEqual(expecting, result);

			expecting = person.NickName;
			result = _.Object.Property.GetValue<string>(person, "NickName");
			Assert.AreEqual(expecting, result);

			expecting = person.Suffix;
			result = _.Object.Property.GetValue<string>(person, "Suffix");
			Assert.AreEqual(expecting, result);

			expecting = person.Title;
			result = _.Object.Property.GetValue<string>(person, "Title");
			Assert.AreEqual(expecting, result);
		}


		[TestMethod]
		public void Object_Property_GetValue_NonGeneric()
		{
			var person = new Person
			{
				FirstName = "FirstName",
				LastName = "LastName",
				MiddleName = "MiddleName",
				NickName = "NickName",
				Suffix = "Suffix",
				Title = "Title",
				Age = 24
			};

			object intExpecting = person.Age;
			object intResult = _.Object.Property.GetValue(person, "Age");
			Assert.AreEqual(intExpecting, intResult);

			object expecting = person.FirstName;
			object result = _.Object.Property.GetValue(person, "FirstName");
			Assert.AreEqual(expecting, result);

			expecting = person.MiddleName;
			result = _.Object.Property.GetValue(person, "MiddleName");
			Assert.AreEqual(expecting, result);

			expecting = person.LastName;
			result = _.Object.Property.GetValue(person, "LastName");
			Assert.AreEqual(expecting, result);

			expecting = person.NickName;
			result = _.Object.Property.GetValue(person, "NickName");
			Assert.AreEqual(expecting, result);

			expecting = person.Suffix;
			result = _.Object.Property.GetValue(person, "Suffix");
			Assert.AreEqual(expecting, result);

			expecting = person.Title;
			result = _.Object.Property.GetValue(person, "Title");
			Assert.AreEqual(expecting, result);
		}



		[TestMethod]
		public void Object_Property_SetValue_Generic()
		{
			var person = new Person
			{
				FirstName = "FirstName",
				LastName = "LastName",
				MiddleName = "MiddleName",
				NickName = "NickName",
				Suffix = "Suffix",
				Title = "Title",
				Age = 24
			};

			int intExpecting = 12;
			_.Object.Property.SetValue<int>(person, "Age", intExpecting);
			int intResult = person.Age;

			Assert.AreEqual(intExpecting, intResult);

			string expecting = "Jon";
			_.Object.Property.SetValue<string>(person, "FirstName", expecting);
			string result = person.FirstName;

			Assert.AreEqual(expecting, result);

			expecting = "Midding";
			_.Object.Property.SetValue<string>(person, "MiddleName", expecting);
			result = person.MiddleName;

			Assert.AreEqual(expecting, result);

			expecting = "DurpDurp";
			_.Object.Property.SetValue<string>(person, "LastName", expecting);
			result = person.LastName;

			Assert.AreEqual(expecting, result);

			expecting = "NewNickName";
			_.Object.Property.SetValue<string>(person, "NickName", expecting);
			result = person.NickName;

			Assert.AreEqual(expecting, result);

			expecting = "NewSuffix";
			_.Object.Property.SetValue<string>(person, "Suffix", expecting);
			result = person.Suffix;

			Assert.AreEqual(expecting, result);

			expecting = "NewTitle";
			_.Object.Property.SetValue<string>(person, "Title", expecting);
			result = person.Title;


			Assert.AreEqual(expecting, result);

		}

		[TestMethod]
		public void Object_Property_SetValue_NonGeneric()
		{

			var person = new Person
			{
				FirstName = "FirstName",
				LastName = "LastName",
				MiddleName = "MiddleName",
				NickName = "NickName",
				Suffix = "Suffix",
				Title = "Title",
				Age = 24
			};

			object intExpecting = 12;
			_.Object.Property.SetValue(person, "Age", intExpecting);
			object intResult = person.Age;

			Assert.AreEqual(intExpecting, intResult);

			object expecting = "Jon";
			_.Object.Property.SetValue(person, "FirstName", expecting);
			object result = person.FirstName;

			Assert.AreEqual(expecting, result);

			expecting = "Midding";
			_.Object.Property.SetValue(person, "MiddleName", expecting);
			result = person.MiddleName;

			Assert.AreEqual(expecting, result);

			expecting = "DurpDurp";
			_.Object.Property.SetValue(person, "LastName", expecting);
			result = person.LastName;

			Assert.AreEqual(expecting, result);

			expecting = "NewNickName";
			_.Object.Property.SetValue(person, "NickName", expecting);
			result = person.NickName;

			Assert.AreEqual(expecting, result);

			expecting = "NewSuffix";
			_.Object.Property.SetValue(person, "Suffix", expecting);
			result = person.Suffix;

			Assert.AreEqual(expecting, result);

			expecting = "NewTitle";
			_.Object.Property.SetValue(person, "Title", expecting);
			result = person.Title;

			Assert.AreEqual(expecting, result);
		}
		

		[TestMethod]
		public void Object_Property_Has_ForTypeTarget()
		{
			var testing = _.Object.Property;

			Assert.IsTrue(testing.Has(typeof(Person), "FirstName"));
			Assert.IsTrue(testing.Has(typeof(Person), "LastName"));
			Assert.IsTrue(testing.Has(typeof(Person), "MiddleName"));
			Assert.IsTrue(testing.Has(typeof(Person), "Suffix"));
			Assert.IsTrue(testing.Has(typeof(Person), "Title"));
			Assert.IsTrue(testing.Has(typeof(Person), "Age"));

		}

		[TestMethod]
		public void Object_Property_Get_ForTypeTarget()
		{
			var testing = _.Object.Property;

			Assert.AreEqual(typeof(Person).GetProperty("FirstName"), testing.Find(typeof(Person), "FirstName"));
			Assert.AreEqual(typeof(Person).GetProperty("LastName"), testing.Find(typeof(Person), "LastName"));
			Assert.AreEqual(typeof(Person).GetProperty("MiddleName"), testing.Find(typeof(Person), "MiddleName"));
			Assert.AreEqual(typeof(Person).GetProperty("Suffix"), testing.Find(typeof(Person), "Suffix"));
			Assert.AreEqual(typeof(Person).GetProperty("Title"), testing.Find(typeof(Person), "Title"));
			Assert.AreEqual(typeof(Person).GetProperty("Age"), testing.Find(typeof(Person), "Age"));

		}

		[TestMethod]
		public void Object_Property_Get_ForTypeTargetCaseInsensitive()
		{
			var testing = _.Object.Property;

			Assert.AreEqual(typeof(Person).GetProperty("FirstName"), testing.Find(typeof(Person), "firstname", false));
			Assert.AreEqual(typeof(Person).GetProperty("LastName"), testing.Find(typeof(Person), "lastname", false));
			Assert.AreEqual(typeof(Person).GetProperty("MiddleName"), testing.Find(typeof(Person), "middlename", false));
			Assert.AreEqual(typeof(Person).GetProperty("Suffix"), testing.Find(typeof(Person), "suffix", false));
			Assert.AreEqual(typeof(Person).GetProperty("Title"), testing.Find(typeof(Person), "title", false));
			Assert.AreEqual(typeof(Person).GetProperty("Age"), testing.Find(typeof(Person), "age", false));

		}

		[TestMethod]
		public void Object_Property_OfType_ForType()
		{
			var testing = _.Object.Property;

			Assert.IsTrue(testing.OfType(typeof(Person), typeof(string)).Any(a => a.Name == "FirstName"));
			Assert.IsTrue(testing.OfType(typeof(Person), typeof(string)).Any(a => a.Name == "LastName"));
			Assert.IsTrue(testing.OfType(typeof(Person), typeof(string)).Any(a => a.Name == "MiddleName"));
			Assert.IsTrue(testing.OfType(typeof(Person), typeof(string)).Any(a => a.Name == "Suffix"));
			Assert.IsTrue(testing.OfType(typeof(Person), typeof(string)).Any(a => a.Name == "Title"));
			Assert.IsTrue(testing.OfType(typeof(Person), typeof(int)).Any(a => a.Name == "Age"));

		}

		[TestMethod]
		public void Object_Property_GetValues()
		{
			var testing = _.Object.Property;
			var testTarget = new Person
			{
				FirstName = "FirstName",
				LastName = "LastName",
				MiddleName = "MiddleName",
				NickName = "NickName",
				Suffix = "Suffix",
				Title = "Title",
				Age = 24
			};

			Assert.AreEqual(                                            //order of decl
				string.Join("", testing.Values<string>(testTarget)), "FirstNameLastNameNickNameMiddleNameTitleSuffix");
			Assert.AreEqual(24, testing.Values<int>(testTarget).FirstOrDefault());

		}

		[TestMethod]
		public void Object_Property_All_TargetInstance()
		{
			var example1 = new { A = 'A', B = "B", C = 1 };
			var props = _.Object.Property.All(example1);

			var propA = props.FirstOrDefault(a =>
				a.Name == "A"
				&& a.PropertyType == typeof(char)
				&& ((char)a.GetValue(example1) == 'A'));

			var propB = props.FirstOrDefault(a =>
				a.Name == "B"
				&& a.PropertyType == typeof(string)
				&& ((string)a.GetValue(example1)) == "B");

			var propC = props.FirstOrDefault(a =>
				a.Name == "C"
				&& a.PropertyType == typeof(int)
				&& ((int)a.GetValue(example1)) == 1);

				Assert.IsNotNull(propA);
				Assert.IsNotNull(propB);
				Assert.IsNotNull(propC);
			}


		[TestMethod]
		public void Object_Property_OfType_TargetInstance()
		{
			var example2 = new Person
			{
				Title = "Mr.",
				FirstName = "Charles",
				MiddleName = "Henry",
				LastName = "Keyser",
				Suffix = "IV",
				NickName = "Chip",
				Age = 24,
			};
			var props = _.Object.Property.OfType(example2, typeof(string));

			Func<string, string, PropertyInfo, bool> strvaluematchfilter =
				(n, v, a) =>
					a.PropertyType == typeof(string) &&
					a.Name == n &&
					((string)a.GetGetMethod().Invoke(example2, new object[0])) == v
				;

			Func<string, string, Func<PropertyInfo, bool>> createStrTest = (n, v) => (a) => strvaluematchfilter(n, v, a);

			var propertyInfos = props as PropertyInfo[] ?? props.ToArray();
			var title = propertyInfos.FirstOrDefault(createStrTest("Title", "Mr."));
			var firstName = propertyInfos.FirstOrDefault(createStrTest("FirstName", "Charles"));
			var lastName = propertyInfos.FirstOrDefault(createStrTest("LastName", "Keyser"));
			var nickName = propertyInfos.FirstOrDefault(createStrTest("NickName", "Chip"));
			var middleName = propertyInfos.FirstOrDefault(createStrTest("MiddleName", "Henry"));
			var suffix = propertyInfos.FirstOrDefault(createStrTest("Suffix", "IV"));

			var shouldBe0 = propertyInfos.Count(a => a.PropertyType != typeof(string));

			foreach (var item in new[] { title, firstName, lastName, nickName, middleName, suffix })
				Assert.IsNotNull(item);

			Assert.AreEqual(0, shouldBe0);
		}

		private static PropertyComponent SetupPropertiesTarget()
		{
			var testing = new PropertyComponent();
			return testing;
		}

		class OtherPerson2
		{
			private readonly int _age;

			public OtherPerson2(int age)
			{
				_age = age;
			}

			public string FirstName { get; set; }

			public string LastName { get; set; }

			public string NickName { get; set; }

			public string MiddleName { get; set; }

			public string Title { get; set; }

			public string Suffix { get; set; }

			public int Age { get { return _age; } }

			public int NumberOfKids { get; set; }
		}
		
		[TestMethod]
		public void Object_Property_Foreach_NonGeneric_JustValues()
		{
			var person = new OtherPerson2(25)
			{
				FirstName = "FirstName",
				LastName = "LastName",
				MiddleName = "MiddleName",
				NickName = "NickName",
				Suffix = "Suffix",
				Title = "Title",
				NumberOfKids = 3
			};

			//25 added for the age property
			var allPropertyValues = new List<object> {"FirstName", "LastName", "MiddleName", "NickName", "Suffix", "Title", 3, 25};
			var allPropertyNames = new List<string> { "FirstName", "LastName", "MiddleName", "NickName", "Suffix", "Title", "NumberOfKids", "Age" };
			var allPropertiesTouched = Enumerable.Repeat(false, 8).ToList();

			_.Object.Property.Each(person, (value) =>
			{
				var indexOf = allPropertyValues.IndexOf(value);

				if (indexOf == -1)
				{
					Assert.Fail("Could not find property with value " + value);
				}
				else
				{
					allPropertiesTouched[indexOf] = true;
				}

			});

			//then check all expected properties were called
			var propertiesMissed = new List<string>();

			for (int i = 0; i < allPropertiesTouched.Count; i++)
			{
				if (!allPropertiesTouched[i])
				{
					propertiesMissed.Add(allPropertyNames[i]);
				}
			}


			if (propertiesMissed.Any())
			{
				Assert.Fail("Could not match values to the following properties " + string.Join(", ", propertiesMissed));
			}

		}

		
		[TestMethod]
		public void Object_Property_Foreach_NonGeneric_ValueAndName()
		{
			var person = new OtherPerson2(25)
			{
				FirstName = "FirstName",
				LastName = "LastName",
				MiddleName = "MiddleName",
				NickName = "NickName",
				Suffix = "Suffix",
				Title = "Title",
				NumberOfKids = 3
			};

			//25 added for the age property
			var allPropertyNames = new List<string> {"FirstName", "LastName", "MiddleName", "NickName", "Suffix", "Title", "NumberOfKids", "Age"};
			var allPropertiesTouched = Enumerable.Repeat(false, 8).ToList();


			_.Object.Property.Each(person, (value, name) =>
			{
				var indexOf = allPropertyNames.IndexOf(name);

				if (indexOf == -1)
				{
					Assert.Fail("Could not find property " + name);
				}
				else
				{
					allPropertiesTouched[indexOf] = true;
				}

				var actualValue = typeof (OtherPerson2).GetProperty(name).GetValue(person);

				Assert.IsTrue(actualValue.Equals(value));

			});

			//then check all expected properties were called
			var propertiesMissed = new List<string>();

			for (int i = 0; i < allPropertiesTouched.Count; i++)
			{
				if (!allPropertiesTouched[i])
				{
					propertiesMissed.Add(allPropertyNames[i]);
				}
			}


			if (propertiesMissed.Any())
			{
				Assert.Fail("Missed the following properties " + string.Join(", ", propertiesMissed));
			}


		}

		
		[TestMethod]
		public void Object_Property_Foreach_NonGeneric_ValueAndNameAndSetter()
		{
			var person = new OtherPerson2(25)
			{
				FirstName = "FirstName",
				LastName = "LastName",
				MiddleName = "MiddleName",
				NickName = "NickName",
				Suffix = "Suffix",
				Title = "Title",
				NumberOfKids = 3
			};

			//25 added for the age property
			var allPropertyNames = new List<string> { "FirstName", "LastName", "MiddleName", "NickName", "Suffix", "Title", "NumberOfKids", "Age" };

			var strProperties =
				new HashSet<string>(new[]
				{"FirstName", "LastName", "MiddleName", "NickName", "Suffix", "Title"});

			var intProperties = new HashSet<string>(new[]
			{
				"NumberOfKids", "Age"
			});
			var allPropertiesTouched = Enumerable.Repeat(false, 8).ToList();

			int increment = 0;
			_.Object.Property.Each(person, (value, name,setter) =>
			{
				var indexOf = allPropertyNames.IndexOf(name);

				if (indexOf == -1)
				{
					Assert.Fail("Could not find property " + name);
				}
				else
				{
					allPropertiesTouched[indexOf] = true;
				}

				var actualValue = typeof(OtherPerson2).GetProperty(name).GetValue(person);

				Assert.IsTrue(actualValue.Equals(value));

				//if the property is NOT a settable property then the set method will be null
				if (name == "Age")
				{

					Assert.IsNull(setter,
						"Setter should be null for the 'Age' property because it does not have a setter");
				}
				else
				{
					//testing to see if the property setting works
					if (strProperties.Contains(name))
					{
						// doing this in case an error happens where multiple values are assigned or
						// all of them are assigned a value (using the same value for everything would give false positive result then)
						var newValue = "Some value " + increment;
						setter(newValue);
						increment++;
						//now get the new value see if it matches
						var newActualValue = typeof(OtherPerson2).GetProperty(name).GetValue(person);

						Assert.IsTrue(newActualValue.Equals(newValue));
					}
					else if (intProperties.Contains(name))
					{
						//incrementing for the same reason as before, don't want to test with the same value if something is wrong
						//might give false pass result
						var newValue = 100 + increment;

						setter(newValue);
						increment++;

						var newActualValue = typeof (OtherPerson2).GetProperty(name).GetValue(person);
						Assert.IsTrue(newActualValue.Equals(newValue));

					}
					else
					{
						//test was possibly updated but forgot to add property to one of the fields
						//or new hashset needs to be made etc

						Assert.Fail("Property " + name +
									" is not included in any of the possible test cases, add property to either set or handle it explicitly ");
					}
				}


			});

			//then check all expected properties were called
			var propertiesMissed = new List<string>();

			for (int i = 0; i < allPropertiesTouched.Count; i++)
			{
				if (!allPropertiesTouched[i])
				{
					propertiesMissed.Add(allPropertyNames[i]);
				}
			}


			if (propertiesMissed.Any())
			{
				Assert.Fail("Missed the following properties " + string.Join(", ", propertiesMissed));
			}


		}




		[TestMethod]
		public void Object_Property_Foreach_Generic_JustValues()
		{
			var person = new OtherPerson2(25)
			{
				FirstName = "FirstName",
				LastName = "LastName",
				MiddleName = "MiddleName",
				NickName = "NickName",
				Suffix = "Suffix",
				Title = "Title",
				NumberOfKids = 3
			};

			//have to get the property based off of the value, so use two arrays
			//seperating values by types because the tests are going to iterate over the properties based off of their type
			var allStrValues = new List<string> {"FirstName", "LastName", "MiddleName", "NickName", "Suffix", "Title"};
			var strPropNames = new List<string> { "FirstName", "LastName", "MiddleName", "NickName", "Suffix", "Title"};



			//25 added for the age property
			var intPropNames = new List<string> { "NumberOfKids", "Age" };
			var allIntValues = new List<int> { 3, 25 };

			var allPropertiesTouched = new Dictionary<string,bool>();

			//initialize the dictionary to have all properties as not touched
			foreach (var prop in strPropNames)
				allPropertiesTouched[prop] = false;

			foreach (var prop in intPropNames)
				allPropertiesTouched[prop] = true;

			_.Object.Property.Each<string>(person, (value) =>
			{
				var indexOf = allStrValues.IndexOf(value);

				if (indexOf == -1)
				{
					Assert.Fail("Could not find property with value " + value);
				}
				else
				{
					allPropertiesTouched[strPropNames[indexOf]] = true;
				}

			});



			_.Object.Property.Each<int>(person, (value) =>
			{
				var indexOf = allIntValues.IndexOf(value);

				if (indexOf == -1)
				{
					Assert.Fail("Could not find property with value " + value);
				}
				else
				{
					allPropertiesTouched[intPropNames[indexOf]] = true;
				}

			});

			//get all of the properties that were missed
			var propertiesMissed = allPropertiesTouched.Where(a => !a.Value).Select(a => a.Key);

			//if any were miseed print out an error message with the names of the missed properties
			if (propertiesMissed.Any())
			{
				Assert.Fail("Could not match values to the following properties " + string.Join(", ", propertiesMissed));
			}

		}


		[TestMethod]
		public void Object_Property_Foreach_Generic_ValueAndName()
		{
			var person = new OtherPerson2(25)
			{
				FirstName = "FirstName",
				LastName = "LastName",
				MiddleName = "MiddleName",
				NickName = "NickName",
				Suffix = "Suffix",
				Title = "Title",
				NumberOfKids = 3
			};

			//25 added for the age property
			var allPropertyNames = new List<string> { "FirstName", "LastName", "MiddleName", "NickName", "Suffix", "Title", "NumberOfKids", "Age" };
			var allPropertiesTouched = Enumerable.Repeat(false, 8).ToList();


			_.Object.Property.Each<string>(person, (value, name) =>
			{
				var indexOf = allPropertyNames.IndexOf(name);

				if (indexOf == -1)
				{
					Assert.Fail("Could not find property " + name);
				}
				else
				{
					allPropertiesTouched[indexOf] = true;
				}

				var actualValue = (string)typeof(OtherPerson2).GetProperty(name).GetValue(person);

				Assert.AreEqual(actualValue, value);

			});

			_.Object.Property.Each<int>(person, (value, name) =>
			{
				var indexOf = allPropertyNames.IndexOf(name);

				if (indexOf == -1)
				{
					Assert.Fail("Could not find property " + name);
				}
				else
				{
					allPropertiesTouched[indexOf] = true;
				}

				var actualValue = (int)typeof(OtherPerson2).GetProperty(name).GetValue(person);

				Assert.AreEqual(actualValue, value);

			});

			//then check all expected properties were called
			var propertiesMissed = new List<string>();

			for (int i = 0; i < allPropertiesTouched.Count; i++)
			{
				if (!allPropertiesTouched[i])
				{
					propertiesMissed.Add(allPropertyNames[i]);
				}
			}


			if (propertiesMissed.Any())
			{
				Assert.Fail("Missed the following properties " + string.Join(", ", propertiesMissed));
			}


		}


		[TestMethod]
		public void Object_Property_Foreach_Generic_ValueAndNameAndSetter()
		{
			var person = new OtherPerson2(25)
			{
				FirstName = "FirstName",
				LastName = "LastName",
				MiddleName = "MiddleName",
				NickName = "NickName",
				Suffix = "Suffix",
				Title = "Title",
				NumberOfKids = 3
			};

			//25 added for the age property
			var allPropertyNames = new List<string> { "FirstName", "LastName", "MiddleName", "NickName", "Suffix", "Title", "NumberOfKids", "Age" };

			var strProperties =
				new HashSet<string>(new[]
				{"FirstName", "LastName", "MiddleName", "NickName", "Suffix", "Title", "NumberOfKids"});

			var intProperties = new HashSet<string>(new[]
			{
				"NumberOfKids", "Age"
			});
			var allPropertiesTouched = Enumerable.Repeat(false, 8).ToList();

			int increment = 0;
			_.Object.Property.Each<string>(person, (value, name, setter) =>
			{
				var indexOf = allPropertyNames.IndexOf(name);

				if (indexOf == -1)
				{
					Assert.Fail("Could not find property " + name);
				}
				else
				{
					allPropertiesTouched[indexOf] = true;
				}

				var actualValue = typeof(OtherPerson2).GetProperty(name).GetValue(person);

				Assert.IsTrue(actualValue.Equals(value));
				
				// doing this in case an error happens where multiple values are assigned or
				// all of them are assigned a value (using the same value for everything would give false positive result then)
				var newValue = "Some value " + increment;
				setter(newValue);
				increment++;

				//now get the new value see if it matches
				var newActualValue = typeof(OtherPerson2).GetProperty(name).GetValue(person);

				Assert.IsTrue(newActualValue.Equals(newValue));

			});


			_.Object.Property.Each<int>(person, (value, name, setter) =>
			{

				var indexOf = allPropertyNames.IndexOf(name);

				if (indexOf == -1)
				{
					Assert.Fail("Could not find property " + name);
				}
				else
				{
					allPropertiesTouched[indexOf] = true;
				}

				var actualValue = typeof(OtherPerson2).GetProperty(name).GetValue(person);

				Assert.IsTrue(actualValue.Equals(value));

				
				if (name == "Age")
				{

					Assert.IsNull(setter,
						"Setter should be null for the 'Age' property because it does not have a setter");
				}
				else
				{
					// doing this in case an error happens where multiple values are assigned or
					// all of them are assigned a value (using the same value for everything would give false positive result then)
					var newValue = 100 + increment;
					setter(newValue);
					increment++;

					//now get the new value see if it matches
					var newActualValue = typeof(OtherPerson2).GetProperty(name).GetValue(person);

					Assert.IsTrue(newActualValue.Equals(newValue));
				}

			});

			//then check all expected properties were called
			var propertiesMissed = new List<string>();

			for (int i = 0; i < allPropertiesTouched.Count; i++)
			{
				if (!allPropertiesTouched[i])
				{
					propertiesMissed.Add(allPropertyNames[i]);
				}
			}


			if (propertiesMissed.Any())
			{
				Assert.Fail("Missed the following properties " + string.Join(", ", propertiesMissed));
			}


		}

		[TestMethod]
		public void Object_Property_Pairs_NonGeneric()
		{
			var person = new OtherPerson2(25)
			{
				FirstName = "FirstNameValue",
				LastName = "LastNameValue",
				MiddleName = "MiddleNameValue",
				NickName = "NickNameValue",
				Suffix = "SuffixValue",
				Title = "TitleValue",
				NumberOfKids = 3
			};
			

			var pairs = _.Object.Property.Pairs(person);

			Assert.IsTrue(pairs.Any(a => a.Name == "FirstName" && ((string)a.Value) == "FirstNameValue"));
			Assert.IsTrue(pairs.Any(a => a.Name == "LastName" && ((string)a.Value) == "LastNameValue"));
			Assert.IsTrue(pairs.Any(a => a.Name == "MiddleName" && ((string)a.Value) == "MiddleNameValue"));
			Assert.IsTrue(pairs.Any(a => a.Name == "NickName" && ((string)a.Value) == "NickNameValue"));
			Assert.IsTrue(pairs.Any(a => a.Name == "Suffix" && ((string)a.Value) == "SuffixValue"));
			Assert.IsTrue(pairs.Any(a => a.Name == "Title" && ((string)a.Value) == "TitleValue"));
			Assert.IsTrue(pairs.Any(a => a.Name == "NumberOfKids" && ((int)a.Value) == 3));
			Assert.IsTrue(pairs.Any(a => a.Name == "Age" && ((int)a.Value) == 25));

			//testing that there are no more than the expected properties
			Assert.AreEqual(8,pairs.Count());

		}

		[TestMethod]
		public void Object_Property_Pairs_Generic()
		{
			var person = new OtherPerson2(25)
			{
				FirstName = "FirstNameValue",
				LastName = "LastNameValue",
				MiddleName = "MiddleNameValue",
				NickName = "NickNameValue",
				Suffix = "SuffixValue",
				Title = "TitleValue",
				NumberOfKids = 3
			};

			var testing = SetupPropertiesTarget();

			var pairs = _.Object.Property.Pairs<string>(person);

			Assert.IsTrue(pairs.Any(a => a.Name == "FirstName" && a.Value == "FirstNameValue"));
			Assert.IsTrue(pairs.Any(a => a.Name == "LastName" && a.Value == "LastNameValue"));
			Assert.IsTrue(pairs.Any(a => a.Name == "MiddleName" && a.Value == "MiddleNameValue"));
			Assert.IsTrue(pairs.Any(a => a.Name == "NickName" && a.Value == "NickNameValue"));
			Assert.IsTrue(pairs.Any(a => a.Name == "Suffix" && a.Value == "SuffixValue"));
			Assert.IsTrue(pairs.Any(a => a.Name == "Title" && a.Value == "TitleValue"));


			//testing that there are no more than the expected properties
			Assert.AreEqual(6, pairs.Count());

			var pairs2 = testing.Pairs<int>(person);

			Assert.IsTrue(pairs2.Any(a => a.Name == "NumberOfKids" && a.Value == 3));
			Assert.IsTrue(pairs2.Any(a => a.Name == "Age" && a.Value == 25));


			//testing that there are no more than the expected properties
			Assert.AreEqual(2, pairs2.Count());

		}
		
	}
}
