# Utility Module

## Compact
### Tuple\<\<Tuple\<T1, T2, T3, T4\>, T5\> Pack(T1 a, T2 b, T3 c, T4 d, T5 e)
Packs given arguments into tuples, grouped by each 4 arguments. Can take any number of arguments from 1-16, inclusive. If passed 4 or fewer arguments, just packs the given arguments into a single non-nested tuple. If given more than 4 arguments, any arguments that can't be packed into a sub-tuple of 4 are added as extra items to the main tuple (see example).
```csharp
_.Utility.Pack(1, 2, 3, 4, 5); // returns Tuple(Tuple(1, 2, 3, 4), 5)
```

## Function
### Func<T> Constant(T value)
Returns a function which always returns the given value
```csharp
int[] values = {1, 2, 3, 4, 5, 6};
var constFunc = _.Utility.Constant(values);

// change all the array values
for(int i = 0; i < values.Length; i++)
    values[i] *= 3;

constFunc(); // {1, 2, 3, 4, 5, 6}
```

## Object
### bool IsTruthy(object target)
Returns false if target object is the default of its type, with the exception of strings which return false on empty, whitespace or null.
```csharp
_.IsTruthy(0); // false
_.IsTruthy(1); // true

_.IsTruthy(null); // false
_.IsTruthy(new object()); // true

_.IsTruthy(""); // false
_.IsTruthy("    "); // false
_.IsTruthy("something"); // true

_.IsTruthy(false); // false
_.IsTruthy(true); // true
```

## Math
### string UniqueId(string prefix)
Returns a GUID (Globally Unique Identifier) prefixed with the given string and "\_"
```csharp
_.Utility.UniqueId("foobar"); // looks like foobar_F9168C5E-CEB2-4FAA-B6BF-329BF39FA1E4
```

### string UniqueId(string prefix)
Returns a GUID (Globally Unique Identifier)
```csharp
_.Utility.UniqueId(); // looks like F9168C5E-CEB2-4FAA-B6BF-329BF39FA1E4
```

### int Random(int min, int max)
Generates a random integer between the given min and max, where min is inclusive and max is exclusive.
```csharp
_.Random(-100, 100) // can be any integer in [-100..99]
```

### int Random(int max)
Generates a random integer between 0 and the given max, where max is exclusive.
```csharp
_.Random(100); // can be any integer in [0..99]
```

### int Random()
Generates a random integer between 0 and Int32.MaxValue, max bound is exclusive
```csharp
_.Random(); // can be any integer in [0..Integer.MaxValue - 1]
```

### int Abs(int i)
Returns the absolute value of the given value (performant implementation).
```csharp
_.Abs(-100); // 100
_.Abs(100); // 100
```

### int Min(int i)
Returns the smaller of the two given values (performant implementation).
```csharp
_.Min(1, 10); // 1
```

### int Max(int i)
Returns the larger of the two given values (performant implementation).
```csharp
_.Max(1, 10); // 10
```

## String

### string ToCamelCase(string s)
Converts a string to camelCase. If a string that isn't either camelCase, kebab-case, PascalCase, or snake_case is passed in, the following characters are treated as delimiters: ' ', ',', '.', '-', '\_', '/', '\\'
```csharp
string snakeInput = "not_camel_case";
string spaceDelimitedString = "not camel case";
string mixedDelimiters = "im_not-a,camel.case string/for\\real"

_.Utility.ToCamelCase(snakeInput); // "notCamelCase"
_.Utility.ToCamelCase(spaceDelimitedString); // "notCamelCase"
_.Utility.ToCamelCase(mixedDelimiters); // "imNotACamelCaseStringForReal"
```

### string IsCamelCase(string s)
Checks if a string is camelCase. Does not consider numbers to be valid characters for camelCase, so will return false if any are contained.
```csharp
string camelCase = "camelCase";
string notCamelCaseNumbers = "camelCase1";
string notCamelCaseSpaces = "camel case";
string notCamelCaseCaps = "CamelCase";

_.Utility.IsCamelCase(camelCase); // true
_.Utility.IsCamelCase(notCamelCaseNumbers); // false
_.Utility.IsCamelCase(notCamelCaseSpaces); // false
_.Utility.IsCamelCase(notCamelCaseCaps); // false
```

### string ToPascalCase(string s)
Converts a string to PascalCase. If a string that isn't either camelCase, kebab-case, PascalCase, or snake_case is passed in, the following characters are treated as delimiters: ' ', ',', '.', '-', '\_', '/', '\\'
```csharp
string snakeInput = "not_pascal_case";
string spaceDelimitedString = "not pascal case";
string mixedDelimiters = "im_not-a,pascal.case string/for\\real"

_.Utility.ToPascalCase(snakeInput); // "NotPascalCase"
_.Utility.ToPascalCase(spaceDelimitedString); // "NotPascalCase"
_.Utility.ToPascalCase(mixedDelimiters); // "ImNotAPascalCaseStringForReal"
```

### string IsPascalCase(string s)
Checks if a string is PascalCase. Does not consider numbers to be valid characters for PascalCase, so will return false if any are contained.
```
string pascalCase = "PascalCase";
string notPascalCaseNumbers = "PascalCase1";
string notPascalCaseSpaces = "Pascal case";
string notPascalCaseCaps = "pascalCase";

_.Utility.IsPascalCase(pascalCase); // true
_.Utility.IsPascalCase(notPascalCaseNumbers); // false
_.Utility.IsPascalCase(notPascalCaseSpaces); // false
_.Utility.IsPascalCase(notPascalCaseCaps); // false
```

### string ToSnakeCase(string s)
Converts a string to snake_case. If a string that isn't either camelCase, kebab-case, PascalCase, or snake_case is passed in, the following characters are treated as delimiters: ' ', ',', '.', '-', '\_', '/', '\\'
```csharp
string camelInput = "notSnakeCase";
string spaceDelimitedString = "not snake case";
string mixedDelimiters = "im_not-a,snake.case string/for\\real"

_.Utility.ToSnakeCase(camelInput); // "not_snake_case"
_.Utility.ToSnakeCase(spaceDelimitedString); // "not_snake_case"
_.Utility.ToSnakeCase(mixedDelimiters); // "im_not_a_snake_case_string_for_real"
```

### string IsSnakeCase(string s)
Checks if a string is snake_case. Does not consider numbers to be valid characters for camelCase, so will return false if any are contained.
```csharp
string snakeCase = "snake_case";
string notSnakeCaseNumbers = "snake_case1";
string notSnakeCaseSpaces = "snake case";
string notSnakeCaseCaps = "SNAKE_case";

_.Utility.IsSnakeCase(snakeCase); // true
_.Utility.IsSnakeCase(notSnakeCaseNumbers); // false
_.Utility.IsSnakeCase(notSnakeCaseSpaces); // false
_.Utility.IsSnakeCase(notSnakeCaseCaps); // false
```

### string ToKebabCase(string s)
Converts a string to kebab-case. If a string that isn't either camelCase, kebab-case, PascalCase, or snake_case is passed in, the following characters are treated as delimiters: ' ', ',', '.', '-', '\_', '/', '\\'
```csharp
string camelInput = "notKebabCase";
string spaceDelimitedString = "not kebab case";
string mixedDelimiters = "im_not-a,kebab.case string/for\\real"

_.Utility.ToKebabCase(camelInput); // "not-kebab-case"
_.Utility.ToKebabCase(spaceDelimitedString); // "not-kebab-case"
_.Utility.ToKebabCase(mixedDelimiters); // "im-not-a-kebab-case-string-for-real"
```

### string IsKebabCase(string s)
Checks if a string is kebab-case. Does not consider numbers to be valid characters for camelCase, so will return false if any are contained.
```csharp
string kebabCase = "kebab-case";
string notKebabCaseNumbers = "kebab-case1";
string notKebabCaseSpaces = "kebab case";
string notKebabCaseCaps = "Kebab-Case";

_.Utility.IsKebabCase(kebabCase); // true
_.Utility.IsKebabCase(notKebabCaseNumbers); // false
_.Utility.IsKebabCase(notKebabCaseSpaces); // false
_.Utility.IsKebabCase(notKebabCaseCaps); // false
```

### IEnumerable<string> Words(string s)
Parses all of the words out of a string, assuming a space delimiter. In this case, "words" refers to filtering out all terms which contain no letters, and filtering the non-letters out of any terms that contain letters.
```csharp
string plainInput = "colorless green ideas sleep furiously";
string nonLetterTerms = "colorless & green + ideas _ sleep ! furiously ."
string mixedTerms = "color-less green, ideas! sleep+ fu@r$i^ously."

_.Utility.Words(plainInput); // { "colorless", "green", "ideas", "sleep", "furiously" }
_.Utility.Words(nonLetterTerms); // { "colorless", "green", "ideas", "sleep", "furiously" }
_.Utility.Words(mixedTerms); // { "colorless", "green", "ideas", "sleep", "furiously" }
```
