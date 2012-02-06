Replace Special Characters Library
==================================

Purpose of this code snippet
----------------------------

To strip special characters from your string and replace it with nondiacritics version, to put dashes (or anything you choose) instead of spaces between words. In other words, to make nice URL string from some sentence with single method.

How to use this
---------------

If you want to use instance of class :

string input = "    AAAAb¾šèıáíé ab¾šèıáÍÍÍÍé ab¾šèİİİİİİáíé ab¾šÈÈÈÈıáíé abcd  ERTFSSS        ";
string output = string.Empty;

var specialChars = new ReplaceSpecialCharacters();
output = specialChars.MakeNiceURL(input);


If you want to call functionality over string (this would use most of you, but please don't forget to add using ReplaceSpecialCharactersLibrary; in your code) :

string input = "    ABCD ef ¾šèıáíé        ";
string output = string.Empty;

output = input.MakeNiceURL();