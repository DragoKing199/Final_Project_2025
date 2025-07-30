using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenuZone : MonoBehaviour
{
    public string startMenuSceneName = "Loading screen"; // Change to your scene name

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(startMenuSceneName);
        }
    }
}
