Title: Jumper

Authors: Blake Dennett and Brian Haacke

This game is broken into three files. Unfortunately we didn't realize that we were supposed to make four classes so we
built it with two. The main file is program. It has two functions, Main and GetUserInput. Main pulls most of its logic 
from the two classes but is the brain of the game. GetUserInput gets the guesses from the user.

The first class is Parachute. This class creates the parachute, displays it, and manipulates it with incorrect guesses. 
The next class, Word, pulls a random word from a large list for the user to guess, determines a win, and displays the 
dashes and word to the user.