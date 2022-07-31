using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Unscrambler
{
    class Constant
    {
        public const string OptionsOnHowToEnterScrambledWords = "Enter scrambled word() manually or as a file: f-File/m-Manual: ";
        public const string OptionsOnContinuingTheProgram = "Would you like to contiune? Y/N";

        public const string EnterScrambledWordsViaFile = "Enter full path including the file name: ";
        public const string EnterScrambledWordsManually = "Enter word(s) manually (separated by commas): ";
        public const string EnterScrambledWordsOptionNotRecognized = "The option was not recognized: ";

        public const string ErrorScrambledWordsCannotBeLoaded = "Scrambled words were not loaded because there was an error";
        public const string ErrorProgramWillBeTerminated = "Program will be terminated";

        public const string MatchFound = "Match found for {0} : {1}";
        public const string MatchNotFound = "No matches have been found";

        public const string Yes = "Y";
        public const string No = "N";
        public const string File = "F";
        public const string Manual = "M";

        public const string wordListFileName = "wordlist.txt";
    }
}
