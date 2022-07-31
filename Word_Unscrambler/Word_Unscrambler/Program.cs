using System;
using System.Collections.Generic;
using System.Linq;
using Word_Unscrambler.Data;
using Word_Unscrambler.Workers;

namespace Word_Unscrambler
{
    class Program
    {
        private static readonly FileReader _fileReader = new FileReader();
        private static readonly WordMatcher _wordMatcher = new WordMatcher();

        static void Main(string[] args)
        {
            try
            {
                bool continueWordUnscrumble = true;

                do
                {
                    Console.WriteLine(Constant.OptionsOnHowToEnterScrambledWords);
                    var option = Console.ReadLine() ?? string.Empty;

                    switch (option.ToUpper())
                    {
                        case Constant.File:
                            Console.WriteLine(Constant.EnterScrambledWordsViaFile);
                            executeScrubledWordsInFileSenario();
                            break;
                        case Constant.Manual:
                            Console.WriteLine(Constant.EnterScrambledWordsManually);
                            executeScrubledWordsInManualSenario();
                            break;
                        default:
                            Console.WriteLine(Constant.EnterScrambledWordsOptionNotRecognized);
                            break;
                    }

                    var continueWordScrumbleDecision = string.Empty;

                    do
                    {
                        Console.WriteLine(Constant.OptionsOnContinuingTheProgram);
                        continueWordScrumbleDecision = Console.ReadLine() ?? string.Empty;
                    } while (
                            !continueWordScrumbleDecision.Equals(Constant.Yes, StringComparison.OrdinalIgnoreCase) &&
                            !continueWordScrumbleDecision.Equals(Constant.No, StringComparison.OrdinalIgnoreCase));

                    continueWordUnscrumble = continueWordScrumbleDecision.Equals(Constant.Yes, StringComparison.OrdinalIgnoreCase);

                } while (continueWordUnscrumble);

            }
            catch (Exception ex)
            {

                Console.WriteLine(Constant.ErrorProgramWillBeTerminated + ex.Message);
            }

           
        }

        private static void executeScrubledWordsInManualSenario()
        {
            var manualInput = Console.ReadLine() ?? string.Empty;
            string[] scrambledwords = manualInput.Split(',');
            DisplayMatchedUnscrambledWords(scrambledwords);

        }

        private static void executeScrubledWordsInFileSenario()
        {
            try
            {   
                var fileName = Console.ReadLine() ?? string.Empty;
                string[] scrambledwords = _fileReader.Read(fileName);
                DisplayMatchedUnscrambledWords(scrambledwords);
            }
            catch (Exception ex)
            {
                Console.WriteLine(Constant.ErrorScrambledWordsCannotBeLoaded + ex.Message);
            }

        }

        private static void DisplayMatchedUnscrambledWords(string[] scrambledWords)
        {
            string[] wordList = _fileReader.Read(Constant.wordListFileName);
            List<MatchedWord> matchedWords = _wordMatcher.Match(scrambledWords, wordList);

            if (matchedWords.Any())
            {
                foreach (var matchedWord in matchedWords)
                {
                    Console.WriteLine(Constant.MatchFound, matchedWord.ScrabledWord, matchedWord.Word);
                }
            }   
            else
            {
                Console.WriteLine(Constant.MatchNotFound);
            }
        }
    }
}
