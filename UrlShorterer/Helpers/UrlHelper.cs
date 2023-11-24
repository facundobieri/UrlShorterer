using System;

namespace UrlShorterer.Helpers
{
    
    public class UrlHelper
    {

        public const int NumberOfCharsInShortLink = 7;
        public static string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        private readonly Random _random = new();
        public string GetShortURL()
        {
            var codeChars = new char[NumberOfCharsInShortLink];

            for(var i = 0; i < NumberOfCharsInShortLink; i++)

            {
                var randomIndex = _random.Next(Alphabet.Length - 1);
                codeChars[i] = Alphabet[randomIndex];
            }
            string httplink = "http://httplink.ly/";
            var code = new string(codeChars);

            string newUrl = httplink + code;
            return newUrl;
        }
    }
}


