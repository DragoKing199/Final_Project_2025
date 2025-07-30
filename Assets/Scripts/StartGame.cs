using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // For Button

public class StartGame : MonoBehaviour
{
    public Button playButton;               // Assign this in the Inspector
    public string sceneToLoad = "Mini Game"; // Set your target scene name

    void Start()
    {
        // Ensure the cursor is visible and unlocked when in the main menu
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        // Add a listener to the Play Button's onClick event
        if (playButton != null)
        {
            playButton.onClick.AddListener(StartTheGame);
        }
        else
        {
            Debug.LogError("Play Button not assigned in StartGame!");
        }
    }

    // This method is called when the Play Button is clicked
    public void StartTheGame()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
