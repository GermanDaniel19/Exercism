public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        bool IsNewYork = ("212" == phoneNumber.Substring(0,3));
        bool IsFake = ("555" == phoneNumber.Substring(4,3));
        string LocalNumber = phoneNumber.Substring(8);

        Console.WriteLine(phoneNumber.Substring(4,3));
        return (IsNewYork,IsFake,LocalNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        
        return phoneNumberInfo.IsFake;
    }
}
