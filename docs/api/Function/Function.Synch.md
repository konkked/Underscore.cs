# Function.Synch

- [After](#after)
- [Before](#before)
- [Delay](#delay)
- [Debounce](#debounce)
- [Once](#once)
- [Throttle](#throttle)

## After

## Func\<Task\<TResult\>\> After\<TResult\>(Func\<TResult\> function, int count)
Returns a function which returns a task that only performs the given function after it is called with all of the calls before count times yielding a result equal to the result of the first working invocation, with every subsequent execution just returning the last invocation's result.
```
Func<string, string> function = (a) => a + a;

var aftered = _.Function.After(function, 3);

List<Task<string>> tasks = new List<Task<string>>();

for(int i = 0; i < 10; i++)
    tasks.Add(aftered(i.ToString()));

foreach(var task in tasks)
    task.Wait();

var results = new List<string>();

foreach(var task in tasks)
    results.Add(task.Result);

results; // { "2", "2", "2", "3", "4", "5", "6", "7", "8", "9" }
```

## Before

### Func<TResult> Before<TResult>(Func\<TResult\> function, int count)
Returns a function which performs the initial function up until the given number of invocations is reached, after which time it will return the result of the last invocation that was performed.
```
int counter = 0;
Func<int> toBefore = ++counter;


Func<int> befored = _.Function.Before(toOnce, 3);

int result;

for(int i = 0; i < 100; i++)
    result = onced();

result; // 3
counter; // 3
```

## Debounce
*TODO*

## Delay
*TODO*

## Once

### Func<TResult> Once<TResult>(Func\<TResult\> function)
Returns a function which is the equivalent of the passed function, except it will only execute once.
```
int counter = 0;
Func<int> toOnce = ++counter;


Func<int> onced = _.Function.Once(toOnce);

int result;

for(int i = 0; i < 100; i++)
    result = onced();

result; // 1
counter; // 1
```

## Throttle
*TODO*
