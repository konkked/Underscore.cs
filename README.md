Here's an improved version of your **README.md** with better documentation, additional usage examples, and details on how developers can contribute and extend the library.  

---

# **Underscore.cs**  

A functional programming utility library for C# inspired by [Underscore.js](http://underscorejs.org/). It provides a rich set of methods for working with collections, arrays, objects, and functions in a functional and expressive way.

## **Getting Started**  

**Installation:**  
Underscore.cs is available as a NuGet package. You can install it via the NuGet Package Manager:

```powershell
Install-Package Underscore.cs
```

Or via .NET CLI:

```sh
dotnet add package Underscore.cs
```

---

## **Modules Overview**  

The library is organized into multiple modules, each focusing on different functional programming utilities:

- **Collections** - Functional operations on collections (`Map`, `Filter`, `Reduce`, etc.).
- **Functions** - Functional programming utilities (`Compose`, `Curry`, `Throttle`, `Debounce`).
- **Objects** - Object manipulation and reflection helpers.
- **Lists** - List processing utilities like chunking, partitioning, and shuffling.
- **Utility** - General utilities such as randomization and memoization.

A complete module overview is available **[here](https://github.com/konkked/Underscore.cs/blob/master/docs/Overview.md)**.

Full API documentation with detailed examples is available **[here](https://github.com/konkked/Underscore.cs/tree/master/docs/api)**.

---

## **Usage Examples**  

### **1. Functional Programming with Collections**  
Use `Map`, `Filter`, and `Reduce` to manipulate collections efficiently.

```csharp
using Underscore;

var numbers = new[] {1, 2, 3, 4, 5};
var squared = _.Collection.Map(numbers, x => x * x); 

Console.WriteLine(string.Join(", ", squared)); 
// Output: 1, 4, 9, 16, 25
```

### **2. List Manipulation - Chunking & Zipping**  
You can partition and zip lists easily.

```csharp
var approvers = new[] { "Alice", "Bob", "Charlie" };
var workers = new[] { "Dave", "Eve", "Frank", "Grace", "Hank" };

var chainOCommand = approvers.Zip(
    _.List.Chunk(workers, _.Utility.Random(2, 3)),
    (approver, workerChunk) => new
    {
        Approver = approver,
        Workers = workerChunk
    })
    .ToDictionary(a => a.Approver, a => a.Workers);

foreach (var entry in chainOCommand)
{
    Console.WriteLine($"{entry.Key} approves: {string.Join(", ", entry.Value)}");
}
```

### **3. Function Composition and Throttling**  
Modify function execution with `Compose`, `Throttle`, and `Debounce`.

```csharp
Func<int, int> doubleNum = x => x * 2;
Func<int, int> addTen = x => x + 10;

// Compose functions
var doubleThenAddTen = _.Function.Compose(addTen, doubleNum);
Console.WriteLine(doubleThenAddTen(5)); // Output: 20

// Throttle function calls
var throttledFunction = _.Function.Throttle(() => Console.WriteLine("Executing..."), 1000);
throttledFunction();
throttledFunction(); // Won't execute immediately if called within 1 second.
```

### **4. Object Reflection and Manipulation**  
Work with object properties dynamically.

```csharp
var person = new { Name = "Alice", Age = 30 };
var age = _.Object.Get(person, "Age");
Console.WriteLine(age); // Output: 30
```

---

## **Why Use Underscore.cs?**  

✅ **Functional Programming in C#** – Brings powerful FP patterns into .NET.  
✅ **Concise & Readable Code** – Reduce boilerplate code while maintaining readability.  
✅ **Well-Organized Modules** – Access utilities in an intuitive, modular way.  
✅ **Inspired by Underscore.js** – If you're familiar with JavaScript's Underscore.js, you'll feel right at home.  
✅ **Actively Maintained** – Continuous improvements and contributions are welcome.  

---

## **Installation and Compatibility**  

Underscore.cs moving forward will only support **.NET Core 8+**, ensuring broad usability across different .NET versions.

| Framework    | Supported |
|--------------|-----------|
| .NET Core 8  | ✅ Yes    |
| .NET Core 9  | ✅ Yes    |


---

## **Contributing**  

We welcome contributions! Here’s how you can help:  

1. **Clone the repo**  
   ```sh
   git clone https://github.com/konkked/Underscore.cs.git
   cd Underscore.cs
   ```

2. **Run tests**  
   ```sh
   dotnet test
   ```

3. **Submit a pull request** with your changes.

More details on contributing **[here](https://github.com/konkked/Underscore.cs/blob/master/CONTRIBUTING.md)**.

---

## **License**  

Underscore.cs is released under the **MIT License**. See the full license **[here](https://github.com/konkked/Underscore.cs/blob/master/LICENSE)**.

---

### **Need Help?**  
- Check the **[API documentation](https://github.com/konkked/Underscore.cs/tree/master/docs/api)**
- Open an **[issue](https://github.com/konkked/Underscore.cs/issues)** on GitHub  
- Contact the maintainer directly via **GitHub Discussions**  

---

This version provides **detailed documentation**, practical **examples**, and a **clear contribution guide**. Let me know if you'd like to highlight any **specific modules or features** in more depth! 🚀