using System.Runtime.CompilerServices;

namespace AwaitAnything;

internal static class MyExtensions
{
    internal static TaskAwaiter GetAwaiter(this MyDelay myDelay)
    {
        return Task.Delay(myDelay._timeSpan).GetAwaiter();
    }
    internal static TaskAwaiter GetAwaiter(this TimeSpan timeSpan)
    {
        return Task.Delay(timeSpan).GetAwaiter();
    }
    internal static TimeSpan Seconds(this int integer)
    {
        return TimeSpan.FromSeconds(integer);
    }
    internal static TaskAwaiter GetAwaiter(this int integer) 
    {
        return Task.Delay(TimeSpan.FromSeconds(integer)).GetAwaiter();
    }
}
