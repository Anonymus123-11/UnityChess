
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Scene name of the main game board
    private string gameSceneName = "Board";

    public void PlayPlayerVsPlayer()
    {
        // Here we will eventually set a static flag or use a ScriptableObject to tell GameManager what mode to start
        Debug.Log("Starting Player vs Player mode...");
        // For now, we just load the scene. The GameManager's default is PvP.
        SceneManager.LoadScene(gameSceneName);
    }

    public void PlayPlayerVsAI()
    {
        // This will require more logic to select side (White/Black)
        // For now, let's just log it.
        Debug.Log("Player vs AI mode selected - (Not fully implemented yet)");
        // Example of how it could work:
        // GameManager.StartAsPlayerVsAI(Side.White);
        // SceneManager.LoadScene(gameSceneName);
    }

    public void OpenSettings()
    {
        // Logic to open a settings panel/scene
        Debug.Log("Opening Settings... (Not implemented yet)");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
