// -----------------------------------------------------------------------
// <copyright file="ReplaceSpecialCharactersExtensions.cs" company="dusan">
//  Feel free to use.
// </copyright>
// <summary>
//  Helper Replaces special characters with their non diacritics counterparts and / or replaces spaces with dash.
// </summary>
// -----------------------------------------------------------------------

namespace ReplaceSpecialCharactersLibrary
{
    /// <summary>
    /// Static extension methods helper for ReplaceSpecialCharacters class.
    /// </summary>
    public static class ReplaceSpecialCharactersExtensions
    {
        /// <summary>
        /// Removes the diacritics from supplied string.
        /// </summary>
        /// <param name="str">The input string.</param>
        /// <returns>Output string.</returns>
        public static string RemoveDiacritics(this string str)
        {
            var replace = new ReplaceSpecialCharacters();
            return replace.RemoveDiacritics(str);
        }

        /// <summary>
        /// Replaces the spaces in given string with another string.
        /// </summary>
        /// <param name="str">The input string.</param>
        /// <param name="replaceSpaceWith">The replace space with string.</param>
        /// <returns>Output string.</returns>
        public static string ReplaceSpaces(this string str, string replaceSpaceWith = "-")
        {
            var replace = new ReplaceSpecialCharacters();
            return replace.ReplaceSpaces(str, replaceSpaceWith);
        }

        /// <summary>
        /// Removes the diacritics and replace spaces with supplied string.
        /// </summary>
        /// <param name="str">The input string.</param>
        /// <param name="replaceSpaceWith">The replace space with string.</param>
        /// <returns>Output string.</returns>
        public static string RemoveDiacriticsAndReplaceSpaces(this string str, string replaceSpaceWith = "-")
        {
            var replace = new ReplaceSpecialCharacters();
            return replace.RemoveDiacriticsAndReplaceSpaces(str, replaceSpaceWith);
        }

        /// <summary>
        /// Trims and removes diacritics from supplied string.
        /// </summary>
        /// <param name="str">The input string.</param>
        /// <returns>Output string.</returns>
        public static string TrimAndRemoveDiacritics(this string str)
        {
            var replace = new ReplaceSpecialCharacters();
            return replace.TrimAndRemoveDiacritics(str);
        }

        /// <summary>
        /// Trims and replaces the spaces in given string with another string.
        /// </summary>
        /// <param name="str">The input string.</param>
        /// <param name="replaceSpaceWith">The replace space with string.</param>
        /// <returns>Output string.</returns>
        public static string TrimAndReplaceSpaces(this string str, string replaceSpaceWith = "-")
        {
            var replace = new ReplaceSpecialCharacters();
            return replace.TrimAndReplaceSpaces(str, replaceSpaceWith);
        }

        /// <summary>
        /// Trims and removes the diacritics and replace spaces with supplied string.
        /// </summary>
        /// <param name="str">The input string.</param>
        /// <param name="replaceSpaceWith">The replace space with string.</param>
        /// <returns>Output string.</returns>
        public static string TrimAndRemoveDiacriticsAndReplaceSpaces(this string str, string replaceSpaceWith = "-")
        {
            var replace = new ReplaceSpecialCharacters();
            return replace.TrimAndRemoveDiacriticsAndReplaceSpaces(str, replaceSpaceWith);
        }

        /// <summary>
        /// Makes the nice URL from given string - trim leading,ending spaces,replace diacritics, replace spaces between words with something you choose.
        /// </summary>
        /// <param name="str">The input string.</param>
        /// <param name="replaceSpaceWith">The replace space with string.</param>
        /// <returns>
        /// Output string.
        /// </returns>
        public static string MakeNiceURL(this string str, string replaceSpaceWith = "-")
        {
            var replace = new ReplaceSpecialCharacters();
            return replace.MakeNiceURL(str, replaceSpaceWith);
        }
    }
}
