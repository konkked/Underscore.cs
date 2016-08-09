find ../../Underscore.Test/Action -type f -name *Test.cs -exec sed -i 's/component\./_\.Action\./g' {} \;
find ../../Underscore.Test/Action -type f -name *Test.cs -exec sed -i 's/testing\./_\.Action\./g' {} \;
find ../../Underscore.Test/Collection -type f -name *Test.cs -exec sed -i 's/component\./_\.Collection\./g' {} \;
find ../../Underscore.Test/Collection -type f -name *Test.cs -exec sed -i 's/testing\./_\.Collection\./g' {} \;
find ../../Underscore.Test/Function -type f -name *Test.cs -exec sed -i 's/component\./_\.Function\./g' {} \;
find ../../Underscore.Test/Function -type f -name *Test.cs -exec sed -i 's/testing\./_\.Function\./g' {} \;
find ../../Underscore.Test/List -type f -name *Test.cs -exec sed -i 's/component\./_\.List\./g' {} \;
find ../../Underscore.Test/List -type f -name *Test.cs -exec sed -i 's/testing\./_\.List\./g' {} \;
find ../../Underscore.Test/Object -type f -name *Test.cs -exec sed -i 's/component\./_\.Object\./g' {} \;
find ../../Underscore.Test/Object -type f -name *Test.cs -exec sed -i 's/testing\./_\.Object\./g' {} \;
find ../../Underscore.Test/Utility -type f -name *Test.cs -exec sed -i 's/component\./_\.Utility\./g' {} \;
find ../../Underscore.Test/Utility -type f -name *Test.cs -exec sed -i 's/testing\./_\.Utility\./g' {} \;

find ../../Underscore.Test -type f -name *Test.cs -exec sed -i 's/var component.*;//g' {} \;
find ../../Underscore.Test -type f -name *Test.cs -exec sed -i 's/var testing.*;//g' {} \;
