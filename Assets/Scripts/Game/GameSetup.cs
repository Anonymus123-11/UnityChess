using static GameManager;

// This is a helper class to pass data between scenes.
// It is not visible to the player.
public static class GameSetup
{
    // MainMenu writes to this, GameManager reads from this.
    public static AIMode SelectedAIMode = AIMode.HumanVsHuman;
}
