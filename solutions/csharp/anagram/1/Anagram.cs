public class Anagram
{
    private string _word;
    List<string> temporalList = new List<string>();
    
    public Anagram(string baseWord)
    {
        _word = baseWord;
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        
        foreach(string potentialMatche in potentialMatches)
        {
            if(IsMatch(_word,potentialMatche))
            {
                temporalList.Add(potentialMatche);
            }
        }
        Console.WriteLine(temporalList.ToArray());
        return temporalList.ToArray();
    }

    public bool IsMatch(string baseWord , string potentialWord){

        //largo de palabras
        bool areEqualsLength = baseWord.Length == potentialWord.Length;
        //son diferentes
        bool areDiferent = !(string.Equals(baseWord, potentialWord, StringComparison.OrdinalIgnoreCase));
        
        string comparedWord = "";
        bool findedLetter = false;
        List<int> numerosProhibidos = new List<int>();

        if (areEqualsLength && areDiferent)
        {
            for(int i = 0; i < baseWord.Length; i++)
            {
                //Console.WriteLine(baseWord[i]);
                for(int j = 0 ; j < potentialWord.Length ; j++)
                {
                    if(char.ToLower(baseWord[i]) == char.ToLower(potentialWord[j])
                       && findedLetter == false
                       && !(numerosProhibidos.Contains(j))
                      )
                    {
                        comparedWord += baseWord[i];
                        findedLetter = true;
                        numerosProhibidos.Add(j);
                    }
                }
    
                findedLetter = false;
            }
                
            return comparedWord == baseWord 
                && numerosProhibidos.Count == potentialWord.Length;
        }else
        {
            return false;
        }
    }
}