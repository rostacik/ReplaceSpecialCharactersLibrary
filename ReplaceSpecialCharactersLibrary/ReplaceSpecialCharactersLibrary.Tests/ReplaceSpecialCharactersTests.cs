namespace ReplaceSpecialCharactersLibrary.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ReplaceSpecialCharactersLibraryFullNET;

    [TestClass]
    public class ReplaceSpecialCharactersTests
    {
        [TestMethod]
        public void diacritics_will_be_stripped_1()
        {
            //arrange
            string input = "abľščťžýáíé";
            string output = string.Empty;

            //act
            var specialChars = new ReplaceSpecialCharacters();
            output = specialChars.RemoveDiacritics(input);

            //assert
            Assert.IsNotNull(output);
            Assert.AreEqual("ablsctzyaie", output);
        }

        [TestMethod]
        public void spaces_will_be_replaced_with_default_string_1()
        {
            //arrange
            string input = "abcd efgh";
            string output = string.Empty;

            //act
            var specialChars = new ReplaceSpecialCharacters();
            output = specialChars.ReplaceSpaces(input);

            //assert
            Assert.IsNotNull(output);
            Assert.AreEqual("abcd-efgh", output);
        }

        [TestMethod]
        public void strip_and_replace_space_1()
        {
            //arrange
            string input = "abľščťžýáíé abľščťžýáíé abľščťžýáíé abľščťžýáíé abcd";
            string output = string.Empty;

            //act
            var specialChars = new ReplaceSpecialCharacters();
            output = specialChars.RemoveDiacriticsAndReplaceSpaces(input, "--");

            //assert
            Assert.IsNotNull(output);
            Assert.AreEqual("ablsctzyaie--ablsctzyaie--ablsctzyaie--ablsctzyaie--abcd", output);
        }

        [TestMethod]
        public void diacritics_will_be_stripped_and_trimmed_1()
        {
            //arrange
            string input = "    abľščťžýáíé        ";
            string output = string.Empty;

            //act
            var specialChars = new ReplaceSpecialCharacters();
            output = specialChars.TrimAndRemoveDiacritics(input);

            //assert
            Assert.IsNotNull(output);
            Assert.AreEqual("ablsctzyaie", output);
        }

        [TestMethod]
        public void spaces_will_be_replaced_with_default_string_and_trimmed_1()
        {
            //arrange
            string input = "     abcd efgh         ";
            string output = string.Empty;

            //act
            var specialChars = new ReplaceSpecialCharacters();
            output = specialChars.TrimAndReplaceSpaces(input);

            //assert
            Assert.IsNotNull(output);
            Assert.AreEqual("abcd-efgh", output);
        }

        [TestMethod]
        public void strip_and_replace_space_and_trim_1()
        {
            //arrange
            string input = "    abľščťžýáíé abľščťžýáíé abľščťžýáíé abľščťžýáíé abcd          ";
            string output = string.Empty;

            //act
            var specialChars = new ReplaceSpecialCharacters();
            output = specialChars.TrimAndRemoveDiacriticsAndReplaceSpaces(input, "--");

            //assert
            Assert.IsNotNull(output);
            Assert.AreEqual("ablsctzyaie--ablsctzyaie--ablsctzyaie--ablsctzyaie--abcd", output);
        }

        [TestMethod]
        public void strip_and_replace_space_and_trim_2()
        {
            //arrange
            string input = "    abľščťžýáíé abľščťžýáíé abľščťžýáíé abľščťžýáíé abcd          ";
            string output = string.Empty;

            //act
            var specialChars = new ReplaceSpecialCharacters();
            output = specialChars.TrimAndRemoveDiacriticsAndReplaceSpaces(input, null);

            //assert
            Assert.IsNotNull(output);
            Assert.AreEqual("    abľščťžýáíé abľščťžýáíé abľščťžýáíé abľščťžýáíé abcd          ", output);
        }
    }
}
