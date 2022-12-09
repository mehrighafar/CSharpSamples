namespace AwaitAnything;

internal struct MyDelay
{
    internal readonly TimeSpan _timeSpan;
	private MyDelay(TimeSpan timeSpan)
	{
		_timeSpan = timeSpan;
	}
	public static MyDelay Seconds(int seconds)
	{
		return new MyDelay(TimeSpan.FromSeconds(seconds));
	}
	//public TaskAwaiter GetAwaiter()
	//{
	//	return Task.Delay(_timeSpan).GetAwaiter();
	//}
}
