# Action.Convert

***All methods in this section are called from _.Action***

### Func\<object\> ToFunction(Action action);
Converts the given action into a function which performs the action then returns null. Useful for overloading functions to accept both Func and Action inputs.
```csharp
Action action = () => Console.WriteLine("I'm hit!");

object result = _.Action.ToFunction(action); // prints "I'm hit!" and result == null
```
