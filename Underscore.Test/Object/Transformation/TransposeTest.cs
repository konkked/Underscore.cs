using NUnit.Framework;
using Moq;
using System.Reflection;
using Underscore.Object;
using Underscore.Object.Reflection;

namespace Underscore.Test.Object.Transformation
{
    [TestFixture]
    public class TransposeTest
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

        class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public decimal Salary { get; set; }
        }

        [Test]
        public void Transpose( )
        {
            var mkprop = new Mock<IPropertyComponent>( );

            mkprop.Setup( a => a.All( typeof( Person ) ) )
                .Returns( typeof( Person ).GetProperties( BindingFlags.Instance | BindingFlags.Public ) );

            mkprop.Setup( a => a.All( typeof( Employee ) ) )
                .Returns( typeof( Employee ).GetProperties( BindingFlags.Instance | BindingFlags.Public ) );

            mkprop.Setup( a => a.All( It.IsAny<Person>( ) ) )
                .Returns( typeof( Person ).GetProperties( BindingFlags.Instance | BindingFlags.Public ) );

            mkprop.Setup( a => a.All( It.IsAny<Employee>( ) ) )
                .Returns( typeof( Employee ).GetProperties( BindingFlags.Instance | BindingFlags.Public ) );

            var target = new TransposeComponent( mkprop.Object );

            string title = "Mr.",
                firstName = "Charles",
                middleName = "Henry",
                lastName = "Keyser",
                suffix = "IV",
                nickName = "Chip";

            int age = 24;

            var person = new Person
            {
                Title = title,
                FirstName = firstName,
                MiddleName = middleName,
                LastName = lastName,
                Suffix = suffix,
                NickName = nickName,
                Age = age,
            };

            string shouldnotbehere = "ShouldNotBeHere";
            string shouldbehere = "ShouldBeHere";
            decimal defaultedSalary = 60000m;

            var employeeWithExistingInfo = new Employee
            {
                FirstName = shouldnotbehere,
                LastName = shouldnotbehere,
                Salary = defaultedSalary
            };

            var employeeWithNoInfo = new Employee { };

            var employeeWithOnlySalary = new Employee
            {
                Salary = 60000m
            };

            decimal employeeToPersonSalary=10000m;
            var employeeToPerson = new Employee { FirstName = shouldbehere, LastName = null, Salary = employeeToPersonSalary };

            target.Transpose( person , employeeWithNoInfo);
            target.Transpose( person , employeeWithExistingInfo);
            target.Transpose( person , employeeWithOnlySalary );

            Assert.AreEqual( person.FirstName, employeeWithExistingInfo.FirstName );
            Assert.AreEqual( person.LastName, employeeWithExistingInfo.LastName );
            Assert.AreEqual( 60000m , employeeWithExistingInfo.Salary );

            Assert.AreEqual( person.FirstName , employeeWithNoInfo.FirstName);
            Assert.AreEqual( person.LastName , employeeWithNoInfo.LastName );
            Assert.AreEqual( default( decimal ) , employeeWithNoInfo.Salary);

            Assert.AreEqual( person.FirstName , employeeWithOnlySalary.FirstName);
            Assert.AreEqual( person.LastName , employeeWithOnlySalary.LastName);
            Assert.AreEqual( 60000m , employeeWithOnlySalary.Salary );

            target.Transpose( person, employeeToPerson );

            Assert.AreEqual( person.FirstName, employeeToPerson.FirstName );
            Assert.AreEqual( lastName, person.LastName );
            Assert.AreEqual( employeeToPerson.Salary, employeeToPersonSalary );
            Assert.AreEqual( title, person.Title );
            Assert.AreEqual( middleName, person.MiddleName );
            Assert.AreEqual( suffix, person.Suffix );
            Assert.AreEqual( nickName, person.NickName );
            Assert.AreEqual( age, person.Age );

        }

        [Test]
        public void Coalesce( )
        {
            string middleName = "Henry";
            var coalscing = new { MiddleName = middleName, FirstName = "ShouldNotBeHere", LastName = "ShouldBeHere" };
            var coalscingType = coalscing.GetType( );

            var mkprop = new Mock<IPropertyComponent>( );

            mkprop.Setup( a => a.All( typeof( Person ) ) )
                .Returns( typeof( Person ).GetProperties( BindingFlags.Instance | BindingFlags.Public ) );

            mkprop.Setup( a => a.All( typeof( Employee ) ) )
                .Returns( typeof( Employee ).GetProperties( BindingFlags.Instance | BindingFlags.Public ) );

            mkprop.Setup( a => a.All( coalscingType  ) )
                .Returns( coalscingType.GetProperties( BindingFlags.Instance | BindingFlags.Public ) );

            mkprop.Setup( a => a.All( It.IsAny<Person>( ) ) )
                .Returns( typeof( Person ).GetProperties( BindingFlags.Instance | BindingFlags.Public ) );

            mkprop.Setup( a => a.All( It.IsAny<Employee>( ) ) )
                .Returns( typeof( Employee ).GetProperties( BindingFlags.Instance | BindingFlags.Public ) );

            mkprop.Setup( a => a.All( coalscing ) )
                .Returns( coalscingType.GetProperties( BindingFlags.Instance | BindingFlags.Public ) );

            var target = new TransposeComponent( mkprop.Object );

            string title = "Mr.",
                firstName = "Charles",
                suffix = "IV",
                nickName = "Chip";

            int age = 24;

            var person = new Person
            {
                Title = title,
                FirstName = firstName,
                Suffix = suffix,
                NickName = nickName,
                Age = age,
            };

            string shouldbehere = "ShouldBeHere";
            decimal defaultedSalary = 60000m;

            var employeeWithExistingInfo = new Employee
            {
                FirstName = shouldbehere,
                LastName = shouldbehere,
                Salary = defaultedSalary
            };

            var employeeWithNoInfo = new Employee { };

            var employeeWithOnlySalary = new Employee
            {
                Salary = 60000m
            };

            var result = target.Coalesce( employeeWithExistingInfo, person );

            Assert.AreEqual( employeeWithExistingInfo, result );
            Assert.AreEqual( defaultedSalary, result.Salary );
            Assert.AreEqual( shouldbehere, result.FirstName );
            Assert.AreEqual( shouldbehere, result.LastName );

            var dm = default( decimal );
            var ml = new Employee{};
            var result3 = target.Coalesce( ml, new { Salary = 1000m } );

            // the salary should not be replaced because
            Assert.AreEqual( result3, ml );
            Assert.AreEqual( dm, ml.Salary );

            var result2 = target.Coalesce( person, coalscing );
            Assert.AreEqual    ( person, result2  );
            Assert.AreNotEqual ( "ShouldNotBeHere", result2.FirstName );
            Assert.AreEqual( "ShouldBeHere", result2.LastName );
            Assert.AreEqual( "Henry", result2.MiddleName );
            Assert.AreEqual( "IV", result2.Suffix );

            var result4 = target.Coalesce( person, coalscing, true );
            Assert.AreNotEqual( person, result4 );
            Assert.AreNotEqual( "ShouldNotBeHere", result2.FirstName );
            Assert.AreEqual( "ShouldBeHere", result2.LastName );
            Assert.AreEqual( "Henry", result2.MiddleName );
            Assert.AreEqual( "IV", result2.Suffix );

        }

    }
}
