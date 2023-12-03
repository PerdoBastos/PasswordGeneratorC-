internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Password generator");

        int passwordlenght = 8;
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_-+=";

        Random random = new Random();
        char[] pass = new char[passwordlenght];

        for (int i = 0; i < passwordlenght; i++)
        {
            pass[i] = chars[random.Next(chars.Length)];
        }

        Console.WriteLine(pass);
    }
}