// --------------------------------------------------------------------------------------------------------------------
// <copyright company="dusan" file="ReplaceSpecialCharacters.cs">
//  Feel free to use.
// </copyright>
// <summary>
//   Replaces special characters with their non diacritics counterparts and / or replaces spaces with dash.
// </summary>
// 
// --------------------------------------------------------------------------------------------------------------------

namespace ReplaceSpecialCharactersLibrary
{
    using System.Globalization;
    using System.Text;

    /// <summary>
    /// Replaces special characters with their non diacritics counterparts and / or replaces spaces with dash.
    /// </summary>
    public class ReplaceSpecialCharacters
    {
        /// <summary>
        /// Removes the diacritics from supplied string.
        /// </summary>
        /// <param name="inputString">The input string.</param>
        /// <returns>
        /// Input string with removed diacritics.
        /// </returns>
        public string RemoveDiacritics(string inputString)
        {
            if (!string.IsNullOrWhiteSpace(inputString))
            {
                inputString = inputString.Normalize(NormalizationForm.FormD);
                var stringBuilder = new StringBuilder();

                for (int i = 0; i < inputString.Length; i++)
                {
                    if (CharUnicodeInfo.GetUnicodeCategory(inputString[i]) != UnicodeCategory.NonSpacingMark)
                    {
                        stringBuilder.Append(inputString[i]);
                    }
                }

                return stringBuilder.ToString();
            }

            return inputString;
        }

        /// <summary>
        /// Replaces the spaces in given string with another string.
        /// </summary>
        /// <param name="inputString">The input string.</param>
        /// <param name="replaceWith">The replace with string.</param>
        /// <returns>Processed string.</returns>
        public string ReplaceSpaces(string inputString, string replaceWith = "-")
        {
            if ((!string.IsNullOrWhiteSpace(inputString)) && (!string.IsNullOrWhiteSpace(replaceWith)))
            {
                var stringBuilder = new StringBuilder(inputString);
                stringBuilder.Replace(" ", replaceWith);

                return stringBuilder.ToString();
            }

            return inputString;
        }

        /// <summary>
        /// Removes the diacritics and replace spaces with supplied string.
        /// </summary>
        /// <param name="inputString">The input string to process.</param>
        /// <param name="replaceWith">The replace with string.</param>
        /// <returns>Processed string.</returns>
        public string RemoveDiacriticsAndReplaceSpaces(string inputString, string replaceWith = "-")
        {
            var outcome = this.RemoveDiacritics(inputString);
            outcome = this.ReplaceSpaces(outcome, replaceWith);

            return outcome;
        }

        /// <summary>
        /// Trims and removes diacritics from supplied string.
        /// </summary>
        /// <param name="inputString">The input string.</param>
        /// <returns>Input string with removed diacritics and removed spaces on start and end.</returns>
        public string TrimAndRemoveDiacritics(string inputString)
        {
            if (!string.IsNullOrWhiteSpace(inputString))
            {
                return this.RemoveDiacritics(inputString.Trim());
            }

            return inputString;
        }

        /// <summary>
        /// Trims and replaces the spaces in given string with another string.
        /// </summary>
        /// <param name="inputString">The input string.</param>
        /// <param name="replaceWith">The replace with string.</param>
        /// <returns>Processed string.</returns>
        public string TrimAndReplaceSpaces(string inputString, string replaceWith = "-")
        {
            if ((!string.IsNullOrWhiteSpace(inputString)) && (!string.IsNullOrWhiteSpace(replaceWith)))
            {
                if (replaceWith != "-")
                {
                    return this.ReplaceSpaces(inputString.Trim(), replaceWith);
                }
                else
                {
                    return this.ReplaceSpaces(inputString.Trim());
                }
            }

            return inputString;
        }

        /// <summary>
        /// Trims and removes the diacritics and replace spaces with supplied string.
        /// </summary>
        /// <param name="inputString">The input string.</param>
        /// <param name="replaceWith">The replace with string.</param>
        /// <returns>Processed string.</returns>
        public string TrimAndRemoveDiacriticsAndReplaceSpaces(string inputString, string replaceWith = "-")
        {
            if ((!string.IsNullOrWhiteSpace(inputString)) && (!string.IsNullOrWhiteSpace(replaceWith)))
            {
                var outcome = this.RemoveDiacritics(inputString.Trim());
                outcome = this.ReplaceSpaces(outcome, replaceWith);

                return outcome;
            }

            return inputString;
        }

        /// <summary>
        /// Makes the nice URL from given string - trim leading,ending spaces,replace diacritics, replace spaces between words with something you choose.
        /// </summary>
        /// <param name="inputString">The input string.</param>
        /// <param name="replaceWith">The replace with string.</param>
        /// <returns>Processed string.</returns>
        public string MakeNiceURL(string inputString, string replaceWith = "-")
        {
            if ((!string.IsNullOrWhiteSpace(inputString)) && (!string.IsNullOrWhiteSpace(replaceWith)))
            {
                var outcome = this.RemoveDiacritics(inputString.Trim());
                outcome = this.ReplaceSpaces(outcome, replaceWith).ToLower();

                return outcome;
            }

            return inputString;
        }
    }
}
