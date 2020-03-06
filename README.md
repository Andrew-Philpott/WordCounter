# WordCounter

#### WordCounter 03.05.2020\_

#### By _**Andrew Philpott**_

## Description

Epicodus project that gathers both a word and sentence from a user and checks how frequently the word appears in the sentence.

## Specs

- _Spec: If the user inputted word is blank then return false._

  - Input: word: "", sentence: "There is a dog in this sentence."
  - Output: false

Description: "" is the only input possible for this spec and sets up for the next spec.

- _Spec: If the user inputted word contains any non letter characters then return false._

  - Input: word: "c4t", sentence: "There is a cat in this sentence."
  - Output: false

Description: This input was used to show that only letter characters can be used to move forward in the application.

- _Spec: If the user inputted "sentence" contains more than one end of sentence punctuation then return false._

  - Input: word: cat, sentence: "There's my cat Benny. Isn't he great?"
  - Output: false

Description: This demonstrates that only one sentence can be used for the users sentence input.

- _Spec: The program should be able to remove leading and trailing white space before checking if the sentence has a end of sentence punctuation mark at end of the sentence._

  - Input: sentence: " Hello there. "
  - Output: sentence: "Hello there."

Description: This input was used to show that trailing and leading white space will be removed from the user sentence input. This is needed to check if the last position of the string is an end of sentence punctuation mark.

- _Spec: If the user inputted sentence doesn't contain a period, exclamation mark, or question mark at the end of the sentence then return false._

  - Input: word: cat, sentence: "There is a cat"
  - Output: false

Description: This demonstrates that the user must define their one sentence correctly by placing the punctuation at end of the input.

- _Spec: If the user inputted sentence doesn't contain a letter before the end of the sentence return false._

  - Input: word: cat, sentence: "There is a cat ."
  - Output: false

Description: This demonstrates that the user must define their one sentence correctly by placing the punctuation at end of the input immediately following the last word in the sentence.

- _Spec: If the sentence doesn't contain any occurances of the user input the answer returned should be 0._

  - Input: word: cat sentence: There is a dog in this sentence.
  - Output: 0

Description: This demonstrates that false positives won't be returned.

- _Spec: If the sentence contains an occurance of the word the answer returned should be 1._

  - Input: word: cat sentence: There is a cat in this sentence.
  - Output: 1

Description: This demonstrates that false negatives won't be returned for a single match.

- _Spec: If the sentence contains an occurance of the word differering by casing, the answer returned should be 1._

  - Input: word: hello, sentence: Hello.
  - Output: 1

Description: This demonstrates that false negatives won't be returned for a single match when the matches differ by casing.

- _Spec: If the sentence contains an occurance of the word and punctuation follows after it with a space before the start of the word or it's the starting word in the sentence, the answer returned should be 1._
  - Input: word: "cat" sentence: "Cat."
  - Output: 1
  - Input: word: "cat" sentence: "My cat is named Benny."
  - Output: 1

Description: This demonstrates all possible match types.

- _Spec: If the sentence multiple occurances of the word then the number of occurances should be returned._

  - Input: word: cat, sentence: "A cat was friends with another cat named dog."
  - Output: 2

## Setup/Installation Requirements

- Clone this repository.
- \$dotnet restore in tests
- \$dotnet build in main project folder

## Known Bugs

- No known bugs

## Support and contact details

- Issues or concerns? Contact us at andrewphilpott92@gmail.com

## Technologies Used

- C#
- .NET Core 2.2

### License

Copyright (c) 2020 **_Andrew Philpott_**

_This software is licensed under the MIT license._
