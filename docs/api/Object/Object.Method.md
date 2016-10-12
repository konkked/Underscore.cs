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

## Find

### MethodInfo Find(Type target[, string name, object query, bool caseSensitive, BindingFlags flags])
Find a method on `target` which matches the name and/or [query](./Query.md), as well as the passed binding flags. Either name, query, or both must be passed to this method. If no flags are passed, this method defaults to looking for public instance methods.
```cs
```

## Has

### bool Has(Type target, [string name, object query, BindingFlags flags])

## Query

## IEnumerable\<MethodInfo> Query(Type target, object query[, string name, bool caseSensitive, BindingFlags flags])

## Invoke

### object Invoke(object target, string name[, BindingFlags flags, params object\[] arguments])

### T Invoke\<T>(object target, string name[, BindingFlags flags, params object\[] arguments])

## InvokeForAll

### IEnumerable\<object> InvokeForAll(object target, string name[, BindingFlags flags, object\[]\[] argumentSets, bool greedy])

### IEnumerable\<T> InvokeForAll(object target, string name[, BindingFlags flags, object\[]\[] argumentSets, bool greedy])
