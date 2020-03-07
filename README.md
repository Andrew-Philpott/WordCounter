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

Description: "" is the only input possible for this spec and sets up for the next spec.

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

- _Spec: If the user sentence is empty return false._

  - Input: sentence: ""
  - Output: false

Description: This input was chosen to prevent the next spec from erroring out.

- _Spec: If the user inputted sentence doesn't contain a letter before the end of the sentence return false._

  - Input: word: cat, sentence: "There is a cat ."
  - Output: false

Description: This demonstrates that the user must define their one sentence correctly by placing the punctuation at end of the input immediately following the last word in the sentence.

- _Spec: If the sentence doesn't contain any occurances of the user input the answer returned should be 0._

  - Input: word: cat sentence: There is a dog in this sentence.
  - Output: 0

Description: This demonstrates that false positives won't be returned.

- _Spec: If the sentence contains an occurance of the word with white space surrounding it the answer returned should be 1._

  - Input: word: cat sentence: There is a cat in this sentence.
  - Output: 1

Description: This demonstrates that false the application can process word matches with white space.

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

- _Spec: If the sentence contains multiple occurances of the word then the number of occurances should be returned._

  - Input: word: "cat" sentence: "A cat was friends with another cat named dog."
  - Output: 2

Description: This Input demonstrates that the application can search past the first occurance of the word.

- _Spec: If the user presses enter without providing a word for the word input question they will be given an error._

- Input: word: ""
- Output: "Word must contain at least one letter."

Description: Demonstrates information provided to the user when they provide an empty string.

- _Spec: If the user enters a word with a non letter character the application will provide them with an error._

- Input: word: "Hello "
- Output: "Word must contain only letter characters."

Description: Demonstrates information provided to the user when they include an illegal character in their word.

- _Spec: If the user enters a sentence with more than one end of sentence punctuation the user will be told to enter a single sentence._

- Input: word: "There's my cat Benny. Isn't he great?"
- Output: "Only one sentence may be entered."

Description: Demonstrates information provided to the user when they enter more than one sentence.

- _Spec: If the user enters a sentence without an end of sentence punctuation the user will be told to provide a ".", "?" or "!" at the end of their sentence._

- Input: word: "There's my cat Benny"
- Output: "Please include either a ".", "?", or "!" at the end of the sentence."

Description: Demonstrates information provided to the user when they dont format their sentence properly.

- _Spec: If the user enters a sentence with a non letter character before the end of sentence punctuation the user will be told to end their sentence with a word followed by ".", "?", or "!"_

- Input: word: "There's my cat Benny ."
- Output: "Please finish your sentence with a word followed by ".", "?", or "!"."

Description: Demonstrates information provided to the user when they dont format their sentence properly.

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
