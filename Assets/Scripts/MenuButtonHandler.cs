using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonHandler : MonoBehaviour
{
    public void PlayGame()
    {
        // Load the "Play Game" scene by its name or index.
        // Replace "PlayGameScene" with the actual name of your play game scene.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void QuitGame()
    {
#if UNITY_EDITOR
        // This is only for quitting the play mode in the Unity Editor.
        UnityEditor.EditorApplication.isPlaying = false;
#else
            // This is for quitting the standalone build of your game.
            Application.Quit();
#endif
    }

}
