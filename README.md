# stackoverflow_1332454

Performance test

https://stackoverflow.com/questions/1332454/replace-multiple-characters-in-string-in-one-line-of-code-in-vb-net/13488658#13488658

Result:
|      Method |      Mean |     Error |    StdDev |
|------------ |----------:|----------:|----------:|
| LinqToArray | 652.21 ns | 12.339 ns | 11.542 ns |
|     ForEach | 122.23 ns |  2.387 ns |  2.653 ns |
|     Regexer | 395.62 ns |  6.927 ns |  6.479 ns |
|      Hasher | 407.29 ns |  4.542 ns |  4.248 ns |
|   Splitting | 113.99 ns |  2.240 ns |  2.580 ns |
|   Aggregate | 143.04 ns |  2.309 ns |  2.160 ns |
