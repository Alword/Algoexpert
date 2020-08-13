namespace Alword.Algoexpert.Tier0
{
    public class PalindromeCheckTask
    {
        public static bool IsPalindrome(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                    return false;
            }
            return true;
        }
    }
}
