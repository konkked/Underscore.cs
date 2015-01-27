Underscore.cs
=============

Started as a port to Underscore.js and changed into basically a library object

Though a lot of the functionality does not map back to Underscore.js, most of the 
function functions are here, as well as their corresponding action siblings

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
            _chainOCommand = _approvers.Zip(
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
