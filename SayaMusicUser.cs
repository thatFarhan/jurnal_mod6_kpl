using System;

public class SayaMusicUser
{
	private int id;
	public string username;
	private List<SayaMusicTrack> uploadedTracks;

	public SayaMusicUser(string username)
	{
        this.id = new Random().Next(10000, 99999);
        this.username = username;
		this.uploadedTracks = new List<SayaMusicTrack>();
    }

	public int GetTotalPlayCount()
	{
		int totalPlayCount = 0;
		foreach (SayaMusicTrack track in uploadedTracks)
		{
			totalPlayCount += track.getPlayCount();
        }
		return totalPlayCount;
    }

	public void AddTrack(SayaMusicTrack track)
	{
		uploadedTracks.Add(track);
    }

	public void PrintAllTracks()
	{
		Console.WriteLine($"User: {username}");
        int i = 1;
		foreach (SayaMusicTrack track in uploadedTracks)
		{
			Console.WriteLine($"Track {i} judul: {track.title}");
			i++;
        }
    }
}
