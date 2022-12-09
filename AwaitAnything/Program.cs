using AwaitAnything;
using System.Diagnostics;

var sw = Stopwatch.StartNew();

await MyDelay.Seconds(2);
//await TimeSpan.FromSeconds(2);
await 2.Seconds();
//await 2;

Console.WriteLine($"Waited for {sw.ElapsedMilliseconds}");