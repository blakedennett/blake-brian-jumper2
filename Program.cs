Main();

void Main () {
    Word word = new Word();
    Parachute parachute = new Parachute();
    word.GetNew();

    do {
        Console.Write("\n\n");
        word.DisplayBadLetters();
        word.DisplayGuess();
        word.DisplaySolution(); 
        parachute.DisplayParachute();
        if (!word.Contains(GetUserInput())) {
            parachute.WrongGuessPunishment();
            Console.Write("\nAwww, that letter is not in the word.");
        } else {
            Console.Write("\nHooray! That letter is in the word!");
        }
    } while (!word.HasWon() && parachute.IsManAlive());
    
}

char GetUserInput () {
    char[] input;
    Console.Write("\nType a letter to guess: ");
    while (true) {
        input = Console.ReadLine().ToCharArray();
        if (input.Length == 1) {
            if ((input[0] >= 'a' && input[0] <= 'z') || (input[0] >= 'A' && input[0] <= 'Z')) {
                if (!Word.IsAlreadyGuessed(input[0])) {
                    break;
            }
            }
        }
        Console.WriteLine("Invalid input. Try again.");
    }
    return input[0];
}

