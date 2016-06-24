## Action Module
### Action Bind\<T1\>(Action\<T1\> action, T1 a)
Binds action to given variables. When called with more variables (and a action with a param list of matching size), binds all of the variables to the given action.
```
string foo = "Hello, World!";
Action<string> myAction = foo => Console.WriteLine(foo);

Action boundAction = _.Action.Bind(myAction, foo);

boundAction(); // prints "Hello, World!" to console
```
