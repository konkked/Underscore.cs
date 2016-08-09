find ../../Underscore.Test -type f -name *Test.cs -exec sed -i 's/TestClass/TestFixture/g' {} \;
find ../../Underscore.Test -type f -name *Test.cs -exec sed -i 's/TestMethod/Test/g' {} \;
find ../../Underscore.Test -type f -name *Test.cs -exec sed -i 's/TestInitialize/SetUp/g' {} \;
find ../../Underscore.Test -type f -name *Test.cs -exec sed -i 's/Microsoft\.VisualStudio\.TestTools\.UnitTesting/NUnit\.Framework/g' {} \;