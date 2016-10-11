##Object.Method
***All Methods called from _.Object.Method property***

***All Methods which take a Type target can also take an object as target***

 - [All](#all)
 - [Find](#find)
 - [Has](#has)
 - [Query](#query)
 - [Invoke](#invoke)

## All

### IEnumerable\<MethodInfo> All(Type target)

### IEnumerable\<MethodInfo> All(Type target, BindingFlags flags)

## Find

### MethodInfo Find(Type target, string name)

### MethodInfo Find(Type target, string name, bool caseSensitive)

### MethodInfo Find(Type target, string name, BindingFlags flags)

### MethodInfo Find(Type target, string name, bool caseSensitive, BindingFlags flags)

### MethodInfo Find(Type target, object query)

### MethodInfo Find(Type target, string name, object query)

### MethodInfo Find(Type target, string name, object query, BindingFlags flags)

### MethodInfo Find(Type target, object query, BindingFlags flags)

## Has

### bool Has(Type target, string name)

### bool Has(Type target, string name, BindingFlags flags)

### bool Has(Type target, object query)

### bool Has(Type target, string name, object query)

### bool Has(Type target, string name, object query, BindingFlags flags)

### bool Has(Type target, object query, BindingFlags flags)

## Query

## IEnumerable\<MethodInfo> Query(Type target, object query)

## IEnumerable\<MethodInfo> Query(Type target, object query, BindingFlags flags)

## IEnumerable\<MethodInfo> Query(Type target, object query, string name, bool caseSensitive)

## IEnumerable\<MethodInfo> Query(Type target, object query, string name, bool caseSensitive, BindingFlags flags)

## IEnumerable\<MethodInfo> Query(Type target, object query, string name)

## IEnumerable\<MethodInfo> Query(Type target, object query, string name, BindingFlags flags)

## Invoke

### object Invoke(object target, string name)

### object Invoke(object target, string name, BindingFlags flags)

### object Invoke(object target, string name, params object\[] arguments)

### object Invoke(object target, string name, BindingFlags flags, params object\[] arguments)

### T Invoke\<T>(object target, string name, BindingFlags flags)

### T Invoke\<T>(object target, string name, params object\[] arguments)

### T Invoke\<T>(object target, string name, BindingFlags flags, params object\[] arguments)

## InvokeForAll

### IEnumerable\<object> InvokeForAll(object target, string name, object\[]\[] argumentSets)

### IEnumerable\<object> InvokeForAll(object target, string name, BindingFlags flags, object\[]\[] argumentSets)

### IEnumerable\<object> InvokeForAll(object target, string name, BindingFlags flags, object\[]\[] argumentSets, bool greedy)

### IEnumerable\<object> InvokeForAll(object target, string name, object\[]\[] argumentSets[], bool greedy)

### IEnumerable\<T> InvokeForAll\<T>(object target, string name, object\[]\[] argumentSets)

### IEnumerable\<T> InvokeForAll\<T>(object target, string name, BindingFlags flags, object\[]\[] argumentSets)

### IEnumerable\<T> object target, string name, object\[]\[] argumentSets, bool greedy)

### IEnumerable\<T> object target, string name, BindingFlags flags, object\[]\[] argumentSets, bool greedy)
