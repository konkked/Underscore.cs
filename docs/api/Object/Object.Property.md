# Object.Property
***All Methods called from _.Object.Method property***

***All Methods which take a Type target can also take an object as target***

- [All](#all)
- [Each](#each)
- [Find](#find)
- [Has](#has)
- [OfType](#oftype)
- [GetValue](#getvalue)
- [SetValue](#setvalue)
- [Pairs](#pairs)
- [Values](#values)

## All

### IEnumerable\<PropertyInfo> All(Type target)

## Each
Performs the given action on each property of `target`.

### void Each\<T>(object target, Action<T> onEach[, BindingFlags flags])
Performs the given action on each property of `target`, taking the value of `target` as a parameter.

### void Each\<T>(object target, Action<T, string> onEach[, BindingFlags flags])

### void Each\<T>(object target, Action\<T, string, Action\<T>>[, BindingFlags flags])

### void Each(object target, Action<T> onEach[, BindingFlags flags])

### void Each(object target, Action<T, string> onEach[, BindingFlags flags])

### void Each(object target, Action\<object, string, Action\<object>>[, BindingFlags flags])


## Find

## Has

## OfType

## GetValue

## SetValue

## Pairs

## Values
