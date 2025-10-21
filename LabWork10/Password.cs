namespace LabWork10
{
    public class Password
    {
        public static bool IsValid(string password) 
            => password.Length >= 8 && password.Any(char.IsDigit) && password.Any(char.IsLetter);
    }
}
