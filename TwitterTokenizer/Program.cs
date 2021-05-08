using System;

namespace TwitterTokenizer
{
    class Program
    {
        static void Main(string[] args)
        {
            string tweet1 = @"Real Madrid, @Juventus and @Barcelona are threatening to extract #damages from their former partners in a doomed #European_SuperLeague. Via 
@tariqpanja:";
            GetTweetMatches(tweet1, '@');
            GetTweetMatches(tweet1, '#');
        }
        //used to get twitter username mentioned in the tweet and usernames.
        public static void GetTweetMatches(string tweet, char chr)
        {
            string txt = "";
            int textCounter = 0;

            for (int i = 0; i < tweet.Length; i++)
            {
                if (tweet[i] == chr)
                {
                    txt += tweet[i];
                    i++;
                    if (Char.IsLetterOrDigit(tweet[i]) || tweet[i] == '_')
                    {
                        while (i < tweet.Length && (Char.IsLetterOrDigit(tweet[i]) || tweet[i] == '_'))
                        {
                            if (i < tweet.Length - 1)
                            {
                                txt += tweet[i];
                                i++;
                            }
                            else
                            {
                                txt += tweet[i];
                                break;
                            }
                        }
                        i--;

                        if (txt.Length > 0)
                        {
                            textCounter++;
                        }
                        Console.WriteLine(txt);
                        txt = "";
                    }
                }
                
            }
            Console.WriteLine("The number of match(es): " + textCounter);
        }
    }

}

