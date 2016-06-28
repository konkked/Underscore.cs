Underscore.cs
=============

Started out as a port of the open source JavaScript Library Underscore.js to C#,
but now is really a library (or helper object) inspired by [underscore.js]


Getting Started
--------------
Solution is available as a NuGet package

```powershell
Install-Package Underscore.cs
```

An overview of the project's modules and capabilities can be found [here](https://github.com/konkked/Underscore.cs/blob/master/docs/Overview.md).

More specific API documentation with examples for each function can be found in the [documents here](https://github.com/konkked/Underscore.cs/tree/action-test-cleanup/docs/api).

Here is a simple example of using the library's list chunking and random:

```
            var chainOCommand = _approvers.Zip(
                _.List.Chunk(_workers,
                    _.Utility.Random(2, 3)
                    ),
                (approver, workerChunk) => new
                {
                    Approver = approver,
                    Workers = workerChunk
                })
                .ToDictionary(
                    a => a.Approver,
                    a => a.Workers
             );
```

[underscore.js]:http://underscorejs.org/
