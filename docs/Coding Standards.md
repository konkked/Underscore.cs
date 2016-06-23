# Code Quality Standards for Underscore.cs
***This is an incomplete work. We're going to update it as we flesh out the coding standards we'd like to have as we go through the project rework/expansion***

## Writing Unit Tests
### Naming Conventions
When naming a test, the format should be Module_SubModule_Function_Description, where SubModule is optional depending on whether it applies.

An example of this format would be Function_Compose_Apply_9Arguments, where the function being tested is Function.Compose.Apply(), and the implementation being tested is the one with 9 arguments.

For tests where there are edge cases, such as Collection.Partition.Partition(), you'll want to include that in the description section. For example, Collection_Partition_Partition_CorrectlySplitsAtBeginning().

### How many tests do I write for a function?
Rather than necessitating trying to write edge cases for functions that don't really have them, such as Function.Compose.Apply() and Function.Compose.Bind(), we're going to only test edge cases for functions that have them, such as Collection.Partition.Partition function.

A new TestMethod should be made for every edge case, so that failure logs are more informative.
