# _Word Counter with C#_

#### _5th & 6th Independent project, 04/26/2019 - 05/05/2019_

#### By _**Stephen Trewick**_

## Program Name _Word Counter_ 5th & 6th Independent Project

## Description

This exercise is designed to take a word from a user and then a sentence that may have the word in it a certain number of times. The program will return to the user the amount of times the word is in their sentence. It will make sure that their word is not a part of another word. Test Methods are a large part of the practice of this exercise and DRYing up our code to be able to use and edit our methods without altering our Program code. The next large practice part of this project is building out an MVC web user interface.

### Specs

| Spec | Input | Output |
| :-----------------    | :------------------ | :-------------- |
| Returns a number pertaining to the amount of times a word was found in a string. | _Input:_ "hat" _Input:_ "That emphatic hateful manhattan chatterbox has a phat hat." | _Output:_ "You used "hat" 1 time."  |
| Returns a number pertaining to the amount of times a word was found in a string if the word starts with an uppercase letter and the original word doesn't. | _Input:_ "is" _Input:_ "Is this a persistent sunrise or is it going to end?" | _Output:_ "You used "is" 2 times. |
| Can account for numbers too, as long as the number isn't part of another word or number. | _Input:_ "2019" _Input:_ "In 2019, I have been awake for 201958 hours." | _Output:_ "You used "2019" 1 time." |
| If a word isn't in the sentence, returns a message with 0. | _Input:_ "zero" _Input:_ "How many times?" | _Output:_ "You used "zero" 0 times." |
| Counts words with mixed uppercase letters. | _Input:_ "funky" _Input:_ "FuNkY behaviors call for fUnKy specs." | _Output:_ "You used "funky" 3 times." | | Spaces or blank strings aren't taken into account of. | _Input:_ " " _Input:_ "I can't see you." | _Output:_ "Please enter a word with substance." |

## Setup/Installation Requirements

* _You can check out the repository link in my github pages [Link to repository](https://github.com/step818/)_

_You need a a terminal or command line and .Net Core 2.2 to be able to run the code_


## Support and contact details

_stephent818@gmail.com_

## Technologies Used

_GIT Bash, , .NET-Sdk-2.2-x64 _

### License
*Licensed under the GPL License*
Copyright (c) 2019 **_Stephen Trewick_**
