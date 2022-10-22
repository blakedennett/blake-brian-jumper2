class Parachute {

    private List<string> parachuteParts = new List<string>();

    public Parachute() {

        parachuteParts.Add("\n");
        parachuteParts.Add("  --");
        parachuteParts.Add(" /  \\");
        parachuteParts.Add(" ----");
        parachuteParts.Add(" \\  /");
        parachuteParts.Add("  \\/");
        parachuteParts.Add("  o");
        parachuteParts.Add(" /|\\");
        parachuteParts.Add(" / \\");

    }

    public void DisplayParachute() {

        foreach (string part in parachuteParts) {
            Console.WriteLine(part);
        }
    }

    public void WrongGuessPunishment() {

        parachuteParts.RemoveAt(1);

    }


    public bool IsManAlive() {

        int length = parachuteParts.Count;

        if (length <= 4) {

            parachuteParts.RemoveAt(1);
            parachuteParts.Insert(1, "  x");

            return false;
        }

        return true;
    }

}