public static class ReverseString
{
    public static string Reverse(string input)
    {
        string rever = "" ;

        for (int i = input.Length -1 ; i >= 0 ; i --)
        {
            rever += input[i] ;  
        }

        return rever;
    }
}