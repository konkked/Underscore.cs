# Utility.String

- [ToCamelCase](#tocamelcase)
- [IsCamelCase](#iscamelcase)
- [ToPascalCase](#topascalcase)
- [IsPascalCase](#ispascalcase)
- [IsCapitalized](#iscapitalized)
- [Capitalize](#capitalize)
- [ToSnakeCase](#tosnakecase)
- [IsSnakeCase](#issnakecase)
- [ToKebabCase](#tokebabcase)
- [IsKebabCase](#iskebabcase)
- [Words](#words)

## ToCamelCase

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

## IsCamelCase

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

## ToPascalCase

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

## IsPascalCase

### string IsPascalCase(string s)
Checks if a string is PascalCase. Does not consider numbers to be valid characters for PascalCase, so will return false if any are contained.
```csharp
string pascalCase = "PascalCase";
string notPascalCaseNumbers = "PascalCase1";
string notPascalCaseSpaces = "Pascal case";
string notPascalCaseCaps = "pascalCase";

_.Utility.IsPascalCase(pascalCase); // true
_.Utility.IsPascalCase(notPascalCaseNumbers); // false
_.Utility.IsPascalCase(notPascalCaseSpaces); // false
_.Utility.IsPascalCase(notPascalCaseCaps); // false
```

## IsCapitalized

### bool IsCapitalized(string s)
Checks if the first character of a string is capitalized.
```csharp
string capitalized = "Hello, world!";
string uncapitalized = "hello, world!";

_.Utility.IsCapitalized(capitalized); // true
_.Utility.IsCapitalized(uncapitalized); // false
```

## Capitalize

### string Capitalize(string s)
Capitalizes the first character of a string.
```csharp
string uncapitalized = "hello, world!";

_.Utility.Capitalize(uncapitalized); // "Hello, world!"
```

## ToSnakeCase

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

## IsSnakeCase

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

## ToKebabCase

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

## IsKebabCase

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

## Words

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
