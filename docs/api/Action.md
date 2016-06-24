# Action Module
## Bind
### Action Bind\<T1\>(Action\<T1\> action, T1 a)
Binds action to given variables. When called with more variables (and a action with a param list of matching size), binds all of the variables to the given action.
```
string foo = "Hello, World!";
Action<string> myAction = foo => Console.WriteLine(foo);

Action boundAction = _.Action.Bind(myAction, foo);

boundAction(); // prints "Hello, World!" to console
```

### Action<T2> Partial<T1, T2>( Action<T1, T2> action, T1 a )
Partially binds the given parameters to action, from left to right. Works with any combination of Action parameter counts and number of parameters to partially bind (if you want to partially bind 11 parameters to a 14 parameter function, you can).
```
Action<int, string> myAction = (i, s) => Console.WriteLine("{0} {1}", i, s);

Action<string> boundAction = _.Action.Partial(myAction, 1);

boundAction("foo"); // prints "1 foo"
```
