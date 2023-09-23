namespace Leetcode;
public class l1768MergeStringsAlternately
{
    public string MergeAlternately(string word1, string word2)
    {
        string result = "";
        int lenMax = Math.Max(word1.Length, word2.Length);
        for (int i = 0; i < lenMax;)
        {
            if(word1[i] == null && word2[i] == null) result += $"{word1[i]}{word2[i]}";
            else if (word1[i] == null && word2[i] != null) result += $"{word2[i]}";
            else if (word1[i] != null && word2[i] == null) result += $"{word1[i]}";
            i++;
        }
        Console.WriteLine(result);
        return result;
    }
    
}
