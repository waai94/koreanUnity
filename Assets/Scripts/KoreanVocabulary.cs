namespace KoreanUnity
{
    /// <summary>
    /// Class for managing Korean vocabulary in Unity
    /// </summary>
    public class KoreanVocabulary
    {
        /// <summary>
        /// Korean word
        /// </summary>
        public string KoreanWord { get; set; }

        /// <summary>
        /// Japanese translation of the Korean word
        /// </summary>
        public string JapaneseTranslation { get; set; }

        /// <summary>
        /// Part of speech for the vocabulary word
        /// </summary>
        public PartOfSpeech PartOfSpeech { get; set; }

        /// <summary>
        /// Constructor to initialize a Korean vocabulary entry
        /// </summary>
        /// <param name="koreanWord">The Korean word</param>
        /// <param name="japaneseTranslation">The Japanese translation</param>
        /// <param name="partOfSpeech">The part of speech</param>
        public KoreanVocabulary(string koreanWord, string japaneseTranslation, PartOfSpeech partOfSpeech)
        {
            KoreanWord = koreanWord;
            JapaneseTranslation = japaneseTranslation;
            PartOfSpeech = partOfSpeech;
        }
    }
}
