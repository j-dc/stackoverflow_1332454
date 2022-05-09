# stackoverflow_1332454

Performance test

https://stackoverflow.com/questions/1332454/replace-multiple-characters-in-string-in-one-line-of-code-in-vb-net/13488658#13488658

Result:
|      Method |     Mean |    Error |   StdDev |
|------------ |---------:|---------:|---------:|
| LinqToArray | 635.2 ns | 12.20 ns | 11.42 ns |
|     ForEach | 119.0 ns |  1.58 ns |  1.40 ns |
|     Regexer | 392.0 ns |  7.38 ns |  8.50 ns |
|      Hasher | 402.0 ns |  6.04 ns |  5.65 ns |
|   Splitting | 109.8 ns |  1.84 ns |  1.72 ns |
|   Aggregate | 136.6 ns |  2.62 ns |  2.45 ns |
