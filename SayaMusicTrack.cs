using System;

public class SayaMusicTrack
{
	private int id;
	public string title;
	private int playCount;

	public SayaMusicTrack(string title)
	{
		this.id = new Random().Next(10000, 99999);
        this.title = title;
		this.playCount = 0;
    }

	public void increasePlayCount(int count)
	{
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
