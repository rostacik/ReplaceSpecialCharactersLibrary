﻿Replace Special Characters Library
==================================

Purpose of this code snippet
----------------------------

To strip special characters from your string and replace it with nondiacritics version, to put dashes (or anything you choose) instead of spaces between words. In other words, to make nice URL string from some sentence with single method.

How to use this
---------------


If you want to use instance of class :

```csharp
string input = "    AAAAbľščťžýáíé abľščťžýáÍÍÍÍé abľščťžÝÝÝÝÝÝáíé abľšČČČČťžýáíé abcd  ERTFSSS        ";
string output = string.Empty;

var specialChars = new ReplaceSpecialCharacters();
output = specialChars.MakeNiceURL(input);
```


If you want to call functionality over string (this would use most of you, but please don't forget to add using ReplaceSpecialCharactersLibrary; in your code) :

```csharp
string input = "    ABCD ef ľščťžýáíé        ";
string output = string.Empty;

output = input.MakeNiceURL();
```
