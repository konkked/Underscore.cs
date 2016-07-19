# I'm sure there's a more elegant way to do this
# but this is a lot easier to implement

find ../Underscore.Test/Action -type f -name *Test.cs -exec sed -i 's/component\./_\.Action\./g' {} \;
find ../Underscore.Test/Collection -type f -name *Test.cs -exec sed -i 's/component\./_\.Collection\./g' {} \;
find ../Underscore.Test/Function -type f -name *Test.cs -exec sed -i 's/component\./_\.Function\./g' {} \;
find ../Underscore.Test/List -type f -name *Test.cs -exec sed -i 's/component\./_\.List\./g' {} \;
find ../Underscore.Test/Object -type f -name *Test.cs -exec sed -i 's/component\./_\.Object\./g' {} \;
find ../Underscore.Test/Utility -type f -name *Test.cs -exec sed -i 's/component\./_\.Utility\./g' {} \;
