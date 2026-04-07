// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        string[] judulLagu = { "twenty something", "me & u", "tailspin", "heaven", "what can i do", "playing dead", "terrible4u", "say that", "shoes", "arizona" };
        string namaUser = "Farhan";
        SayaMusicUser user = new SayaMusicUser(namaUser);
        foreach (string judul in judulLagu)
        {
            string judulLengkap = $"Review Lagu {judul} oleh {namaUser}";
            SayaMusicTrack track = new SayaMusicTrack(judulLengkap);
            user.AddTrack(track);
        }

        user.PrintAllTracks();
    }
}
