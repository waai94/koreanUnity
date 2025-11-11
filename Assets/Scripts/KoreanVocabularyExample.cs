using System;

namespace KoreanUnity
{
    /// <summary>
    /// Example usage and verification of the KoreanVocabulary class
    /// </summary>
    public class KoreanVocabularyExample
    {
        public static void TestVocabulary()
        {
            // Create a noun example
            var noun = new KoreanVocabulary("사과", "リンゴ", PartOfSpeech.Noun);
            Console.WriteLine($"Korean: {noun.KoreanWord}, Japanese: {noun.JapaneseTranslation}, Type: {noun.PartOfSpeech}");

            // Create a verb example
            var verb = new KoreanVocabulary("먹다", "食べる", PartOfSpeech.Verb);
            Console.WriteLine($"Korean: {verb.KoreanWord}, Japanese: {verb.JapaneseTranslation}, Type: {verb.PartOfSpeech}");

            // Create an adjective example
            var adjective = new KoreanVocabulary("아름답다", "美しい", PartOfSpeech.Adjective);
            Console.WriteLine($"Korean: {adjective.KoreanWord}, Japanese: {adjective.JapaneseTranslation}, Type: {adjective.PartOfSpeech}");
        }
    }
}
