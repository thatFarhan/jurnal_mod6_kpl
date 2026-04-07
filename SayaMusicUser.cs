using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;

public class SayaMusicUser
{
	private int id;
	public string username;
	private List<SayaMusicTrack> uploadedTracks;

	public SayaMusicUser(string username)
	{
		Debug.Assert(username.Length <= 100, "Username must be 100 characters or less.");
		Debug.Assert(username != null, "Username cannot be null.");

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
        Debug.Assert(track != null, "Track cannot be null.");
		Debug.Assert(track.getPlayCount() <= int.MaxValue, "Play count must be a valid integer.");
        uploadedTracks.Add(track);
    }

	public void PrintAllTracks()
	{
		Console.WriteLine($"User: {username}");
        int i = 1;
		foreach (SayaMusicTrack track in uploadedTracks)
		{
			if (i > 8) break;
            Console.WriteLine($"Track {i} judul: {track.title}");
			i++;
        }
    }
}
