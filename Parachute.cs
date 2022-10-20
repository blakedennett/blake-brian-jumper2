class Parachute {

    private List<string> parachuteParts = new List<string>();

    public Parachute() {

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

        parachuteParts.RemoveAt(0);

    }


    public bool IsManAlive() {

        int length = parachuteParts.Count;

        if (length <= 3) {

            parachuteParts.RemoveAt(0);
            parachuteParts.Insert(0, "  x");

            return false;
        }

        return true;
    }

}