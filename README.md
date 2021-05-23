# Max degree of parallelism

A demo to take input from user and use that as max degree of parallelism
with `Parallel.ForEach()` method.

`Parallel.ForEach()` method can process items in a collection in multiple
threads parallelly but we can specify the max number of parallel threads
in that.

## Output

```
---- PrintSingleThread
Thread id: 1, Id: 1, Name: f1 l1
Thread id: 1, Id: 2, Name: f2 l2
Thread id: 1, Id: 3, Name: f3 l3
Thread id: 1, Id: 4, Name: f4 l4
Thread id: 1, Id: 5, Name: f5 l5
Thread id: 1, Id: 6, Name: f6 l6
Thread id: 1, Id: 7, Name: f7 l7
Thread id: 1, Id: 8, Name: f8 l8
Thread id: 1, Id: 9, Name: f9 l9
Thread id: 1, Id: 10, Name: f10 l10
Time took: 20 sec

---- PrintMultiThread
Thread id: 1, Id: 1, Name: f1 l1
Thread id: 4, Id: 6, Name: f6 l6
Thread id: 5, Id: 2, Name: f2 l2
Thread id: 6, Id: 7, Name: f7 l7
Thread id: 1, Id: 3, Name: f3 l3
Thread id: 7, Id: 5, Name: f5 l5
Thread id: 4, Id: 8, Name: f8 l8
Thread id: 5, Id: 10, Name: f10 l10
Thread id: 1, Id: 4, Name: f4 l4
Thread id: 4, Id: 9, Name: f9 l9
Time took: 6 sec

Provide max degree df parallelism value: 2
---- PrintMultiThreadWithMaxDegreeOfParallelism
Thread id: 4, Id: 1, Name: f1 l1
Thread id: 1, Id: 6, Name: f6 l6
Thread id: 1, Id: 7, Name: f7 l7
Thread id: 5, Id: 2, Name: f2 l2
Thread id: 1, Id: 8, Name: f8 l8
Thread id: 5, Id: 3, Name: f3 l3
Thread id: 1, Id: 9, Name: f9 l9
Thread id: 5, Id: 4, Name: f4 l4
Thread id: 1, Id: 10, Name: f10 l10
Thread id: 5, Id: 5, Name: f5 l5
Time took: 10 sec
```