using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeConverter
{
    public class Data
    {
        public Dictionary<char, String> morseCodeTable;
        public Dictionary<String, char> invertedMorseCodeTable;

        public Data()
        {
            morseCodeTable = new Dictionary<char, String>()
                {
                    {' ' , " "},
                    {'A' , ".-"},
                    {'B' , "-..."},
                    {'C' , "-.-."},
                    {'D' , "-.."},
                    {'E' , "."},
                    {'F' , "..-."},
                    {'G' , "--."},
                    {'H' , "...."},
                    {'I' , ".."},
                    {'J' , ".---"},
                    {'K' , "-.-"},
                    {'L' , ".-.."},
                    {'M' , "--"},
                    {'N' , "-."},
                    {'O' , "---"},
                    {'P' , ".--."},
                    {'Q' , "--.-"},
                    {'R' , ".-."},
                    {'S' , "..."},
                    {'T' , "-"},
                    {'U' , "..-"},
                    {'V' , "...-"},
                    {'W' , ".--"},
                    {'X' , "-..-"},
                    {'Y' , "-.--"},
                    {'Z' , "--.."},
                    {'0' , "-----"},
                    {'1' , ".----"},
                    {'2' , "..---"},
                    {'3' , "...--"},
                    {'4' , "....-"},
                    {'5' , "....."},
                    {'6' , "-...."},
                    {'7' , "--..."},
                    {'8' , "---.."},
                    {'9' , "----."},
                };

            invertedMorseCodeTable = morseCodeTable.ToDictionary(x => x.Value, x => x.Key);
        }
    }
}
