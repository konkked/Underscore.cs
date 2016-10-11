# Object.Constructor
***All Methods called from _.Object.Constructor property***

***All Methods which take a Type target can also take an object as target***

- [HasParameterless](#hasparameterless)
- [Parameterless](#parameterless)
- [Simplest](#simplest)
- [Find](#find)
- [Query](#query)
- [All](#all)

## HasParameterless

### bool HasParameterless(object target)

### bool HasParameterless(object target, BindingFlags flags)

### bool HasParameterless(Type target)

### bool HasParameterless(Type target, BindingFlags flags)

## Parameterless

### ConstructorInfo Parameterless(object target)

### ConstructorInfo Parameterless(object target, BindingFlags flags)

### ConstructorInfo Parameterless(Type target)

### ConstructorInfo Parameterless(Type target, BindingFlags flags)

## Simplest

### ConstructorInfo Simplest(Type target)

### ConstructorInfo Simplest(object target);

### ConstructorInfo Simplest(Type target, BindingFlags flags)

### ConstructorInfo Simplest(object target, BindingFlags flags)

## Find

### ConstructorInfo Find(Type target, object query);

### ConstructorInfo Find(Type target, object query, BindingFlags flags);

### ConstructorInfo Find(object target, object query);

### ConstructorInfo Find(object target, object query, BindingFlags flags);

## Query

### IEnumerable<ConstructorInfo> Query(Type target, object query);

### IEnumerable<ConstructorInfo> Query(Type target, object query, BindingFlags flags);

### IEnumerable<ConstructorInfo> Query(object target, object query);

### IEnumerable<ConstructorInfo> Query(object target, object query, BindingFlags flags);

## All

### IEnumerable<ConstructorInfo> All(Type target);

### IEnumerable<ConstructorInfo> All(Type target, BindingFlags flags);

### IEnumerable<ConstructorInfo> All(object target);

### IEnumerable<ConstructorInfo> All(object target, BindingFlags flags);
