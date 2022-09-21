namespace Assignment2;

public static class Extensions
{
    public static bool IsSecure(this Uri link) 
    {
        if(link.AbsoluteUri.Contains("https")) return true;
        return false;
    }

    public static int WordCount(this string line) 
    {
        var words = Regex.Split(line, @"[a-zA-Z]+");
        return words.Length - 1;
    }
}
