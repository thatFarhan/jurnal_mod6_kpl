using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;

public class SayaMusicTrack
{
	private int id;
	public string title;
	private int playCount;

	public SayaMusicTrack(string title)
	{
		Debug.Assert(title.Length <= 200, "Title must be 200 characters or less.");
		Debug.Assert(title != null, "Title cannot be null.");

        this.id = new Random().Next(10000, 99999);
        this.title = title;
		this.playCount = 0;
    }

	public void increasePlayCount(int count)
	{
		Debug.Assert(count <= 25_000_000, "Count must be 25 million or less.");
		Debug.Assert(count >= 0, "Count must be non-negative.");
		Debug.Assert(playCount + count <= int.MaxValue, "Total play count must not exceed int.MaxValue.");
        playCount += count;
    }
	public void printTrackDetails()
	{
		Console.WriteLine($"Track ID: {id}, Title: {title}, Play Count: {playCount}");
    }

    public int getPlayCount()
	{
		return playCount;
	}
}
