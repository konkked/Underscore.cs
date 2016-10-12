# Object.Method
***All Methods called from _.Object.Method property***

***All Methods which take a Type target can also take an object as target***

 - [All](#all)
 - [Find](#find)
 - [Has](#has)
 - [Query](#query)
 - [Invoke](#invoke)

## All

### IEnumerable\<MethodInfo> All(Type target[, BindingFlags flags])
Gets the [MethodInfo](https://msdn.microsoft.com/en-us/library/system.reflection.methodinfo.aspx) of all methods on `target`.
```cs

```

## Find

### MethodInfo Find(Type target[, string name, object query, bool caseSensitive, BindingFlags flags])
Find a method on `target` which matches the name and/or [query](./Query.md) and return its [MethodInfo](https://msdn.microsoft.com/en-us/library/system.reflection.methodinfo.aspx). Either name, query, or both must be passed to this method. If no `flags` are passed, this method defaults to looking for public instance methods. Either `name`, `query` or both must be passed to the function. If no matching methods are found, returns `null`.
```cs

```

## Has

### bool Has(Type target, [string name, object query, BindingFlags flags])
Check if a method exists on `target` which matches the name and/or [query](./Query.md). Either name, query, or both must be passed to this method. If no `flags` are passed, this method defaults to looking for public instance methods. Either `name`, `query` or both must be passed to the function. If no matching methods are found, returns `null`.
```cs

```


## Query

## IEnumerable\<MethodInfo> Query(Type target, object query[, string name, bool caseSensitive, BindingFlags flags])
Query for all methods on `target` which match the given query (and optionally, name). If no `flags` are passed, this method defaults to looking for public instance methods. If no matching results are found, returns an empty IEnumerable.
```cs

```

## Invoke
Invokes the given method from the given object and returns the result.

### object Invoke(object target, string name[, BindingFlags flags, params object\[] arguments])
Returns an object containing the return value of the invocation. If arguments are provided, the method is invoked with those arguments. If the method is not found on the object, returns null.
```cs
```

### T Invoke\<T>(object target, string name[, BindingFlags flags, params object\[] arguments])
Returns a `T` containing the return value of the invocation, where `T` is the return type of the desired method. If arguments are provided, the method is invoked with those arguments. If the method is not found on the object, returns the default value of `T`.
```cs
```

## InvokeForAll

### IEnumerable\<object> InvokeForAll(object target, string name[, BindingFlags flags], object\[]\[] argumentSets[, bool greedy])
Returns an `IEnumerable<object>` consisting of the results of invoking the method with the given `name` with each array of arguments in `argumentSets`. If `greedy` is `true`, all invocations are done on call of InvokeForAll(), else invocations are done as objects are yielded by the `IEnumerable`.
```cs

```

### IEnumerable\<T> InvokeForAll(object target, string name[, BindingFlags flags, object\[]\[] argumentSets, bool greedy])
Returns an `IEnumerable<T>` consisting of the results of invoking the method with the given `name` with each array of arguments in `argumentSets`, where `T` is the expected return type of the method you want to invoke. If `greedy` is `true`, all invocations are done on call of InvokeForAll(), else invocations are done as objects are yielded by the `IEnumerable`.
```cs

```
