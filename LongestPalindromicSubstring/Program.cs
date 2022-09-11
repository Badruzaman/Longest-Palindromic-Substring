
string str = "abaxyzzyxf";

string result = LongestPalindromicSubsting(str);
Console.WriteLine(result);
Console.ReadKey();


string LongestPalindromicSubsting(string str)
{
    string longest = string.Empty;
    for (int i = 0; i < str.Length; i++)
    {
        for (int j = i; j < str.Length; j++)
        {
            string substring = str.Substring(i, j + 1 - i);
            if(longest.Length < substring.Length && IsPalindrome(substring))
            {
                longest = substring;
            }
        }
    }
    return longest;
}

bool IsPalindrome(string str)
{
    int left = 0;
    int right = str.Length - 1;
    while (left < right)
    {
        if (str[left] != str[right])
        {
            return false;
        }
        left++;
        right--;
    }
    return true;
}

