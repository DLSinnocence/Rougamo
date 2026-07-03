using Issues.Attributes;
using Rougamo;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Issues;

[SkipRefStruct]
public class Issue112
{
    public delegate string ReadOnlySpanInDelegate(List<string> logs, ReadOnlySpan<char> span);

    [_112_]
    public async ValueTask ValueTaskAsync(List<string> logs)
    {
        logs.Add("ValueTaskAsync");
    }

    [_112_]
    public async IAsyncEnumerable<int> AsyncEnumerable(List<string> logs)
    {
        logs.Add("AsyncEnumerable");
        yield return 1;
    }

    [_112_]
    public string ReadOnlySpanIn(List<string> logs, ReadOnlySpan<char> span)
    {
        return span.ToString();
    }
}
