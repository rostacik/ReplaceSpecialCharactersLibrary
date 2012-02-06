namespace ReplaceSpecialCharactersLibrary.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ReplaceSpecialCharactersExtensionsTests
    {
        [TestMethod]
        public void extension_diacritics_will_be_stripped_1()
        {
            //arrange
            string input = "abľščťžýáíé";
            string output = string.Empty;

            //act
            output = input.RemoveDiacritics();

            //assert
            Assert.IsNotNull(output);
            Assert.AreEqual("ablsctzyaie", output);
        }

        [TestMethod]
        public void extension_spaces_will_be_replaced_with_default_string_1()
        {
            //arrange
            string input = "abcd efgh";
            string output = string.Empty;

            //act
            output = input.ReplaceSpaces();

            //assert
            Assert.IsNotNull(output);
            Assert.AreEqual("abcd-efgh", output);
        }

        [TestMethod]
        public void extension_strip_and_replace_space_1()
        {
            //arrange
            string input = "abľščťžýáíé abľščťžýáíé abľščťžýáíé abľščťžýáíé abcd";
            string output = string.Empty;

            //act
            output = input.RemoveDiacriticsAndReplaceSpaces("--");

            //assert
            Assert.IsNotNull(output);
            Assert.AreEqual("ablsctzyaie--ablsctzyaie--ablsctzyaie--ablsctzyaie--abcd", output);
        }

        [TestMethod]
        public void extension_diacritics_will_be_stripped_and_trimmed_1()
        {
            //arrange
            string input = "    abľščťžýáíé        ";
            string output = string.Empty;

            //act
            output = input.TrimAndRemoveDiacritics();

            //assert
            Assert.IsNotNull(output);
            Assert.AreEqual("ablsctzyaie", output);
        }

        [TestMethod]
        public void extension_spaces_will_be_replaced_with_default_string_and_trimmed_1()
        {
            //arrange
            string input = "     abcd efgh         ";
            string output = string.Empty;

            //act
            output = input.TrimAndReplaceSpaces();

            //assert
            Assert.IsNotNull(output);
            Assert.AreEqual("abcd-efgh", output);
        }

        [TestMethod]
        public void extension_strip_and_replace_space_and_trim_1()
        {
            //arrange
            string input = "    abľščťžýáíé abľščťžýáíé abľščťžýáíé abľščťžýáíé abcd          ";
            string output = string.Empty;

            //act
            output = input.TrimAndRemoveDiacriticsAndReplaceSpaces("--");

            //assert
            Assert.IsNotNull(output);
            Assert.AreEqual("ablsctzyaie--ablsctzyaie--ablsctzyaie--ablsctzyaie--abcd", output);
        }

        [TestMethod]
        public void extension_strip_and_replace_space_and_trim_2()
        {
            //arrange
            string input = "    abľščťžýáíé abľščťžýáíé abľščťžýáíé abľščťžýáíé abcd          ";
            string output = string.Empty;

            //act
            output = input.TrimAndRemoveDiacriticsAndReplaceSpaces(null);

            //assert
            Assert.IsNotNull(output);
            Assert.AreEqual("    abľščťžýáíé abľščťžýáíé abľščťžýáíé abľščťžýáíé abcd          ", output);
        }

        [TestMethod]
        public void extension_make_nice_url_from_string_1()
        {
            //arrange
            string input = "    ABCD ef ľščťžýáíé        ";
            string output = string.Empty;

            //act
            output = input.MakeNiceURL();

            //assert
            Assert.IsNotNull(output);
            Assert.AreEqual("abcd-ef-lsctzyaie", output);
        }
    }
}
