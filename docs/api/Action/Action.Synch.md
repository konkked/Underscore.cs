# Action.Synch

***All methods in this section are called from _.Action***

- [Before](#before)
- [After](#after)
- [Once](#once)
- [Debounce](#debounce)
- [Throttle](#throttle)
- [Delay](#delay)

## Before

### Action Before(Action action, int count)
Returns a version of the action which will only invoke a limited number of times. Any invocations past the given limit perform a no-op instead (do nothing).
```csharp
// we'll use this to see how many times the function is invoked
int counter = 0;

Action action = () => counter++;

Action befored = _.Action.Before(action, 3);

for(int i = 0; i < 10; i++)
    befored();

Console.WriteLine(counter); // prints "3"
```

## After

### Func\<Task\> After(Action action, int count)
Returns a function which returns a task that only starts performing the given action after it is invoked count times.
```csharp
// we'll use this to see how many times the function is invoked
int counter = 0;

// we'll use this to store the tasks produced by the aftered function
Task[] tasks = new Task[6];

Action action = () => counter++;

Func<Task> aftered = _.Action.After(action, 3);

// set up a list of aftered tasks to run
for(int i = 0; i < tasks.Length; i++)
    tasks[i] = aftered();

for(int i = 0; i < tasks.Length; i++)
    tasks[i].Wait();

Console.WriteLine(counter); // prints 3
```

## Once

### Action Once(Action action)
Returns of the given action which will only invoke once. Any times it is called after the first, it instead just performs a no-op.
```csharp
int counter = 0;
Action action = () => counter++;
Action onced = _.Once(action);

// call it repeatedly
for(int i = 0; i < 100; i++)
    onced();

Console.WriteLine(counter); // 1
```

## Debounce

### Func\<Task\> Debounce(Action action, int milliseconds)
Returns a function which acts as a debounced version of the given function. A debounced function is throttled to only be allowed to be invoked once within the given time frame.
```csharp
int[] result = {0}

Action<int> toDebounce = n => result[0] += n

var debounced = _.Debounce(toDebounce, 50);

var tasksRunning = new List<Task>>();

for(int i = 0; i < 100; i++)
    tasksRunning.Add(debounced(i))

Console.WriteLine(result[0]) // 0

foreach(task in tasksRunning)
    await task;

Console.WriteLine(result[0]); // 99, because only the last task was processed
```

## Throttle

## Delay

### Func\<Task\> Delay(Action action, int milliseconds)
Returns a function which executes the given action after the given delay, asynchronously.
```csharp
bool invoked = false;
Action action = () => invoked = true;
Func<Task> delayed = _.Delay(action, 100);

var timer = new Stopwatch();

timer.Start();
delayed.Wait();
timer.Stop();

Console.WriteLine(timer.ElapsedMilliseconds); // somewhere in the range of 105-115ms
```
