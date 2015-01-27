Underscore.cs
=============

Started out as a port of the open source JavaScript Library Underscore.js to C#,
but now is really a library (or helper object) inspired by Underscore.js.

Currently the documentation is sparse because I am not sure how much of it is going 
to change in the future so not worth investing heavily into it until things get a little
more stable

Currently is broken up into the following sections

Action
-------


Function
--------

List 
--------

Collection
----------

Object
------

Utility
-------
```cs
            var chainOCommand = _approvers.Zip(
                _.List.Chunk(_preparers,
                    _.Utility.Random(2, 3)
                    ),
                (approver, prepers) => new
                {
                    Approver = approver,
                    Preparers = prepers
                })
                .ToDictionary(
                    a => a.Approver, 
                    a => a.Preparers
             );
```
If you have any questions or suggestions they would be greatly apperciated 