using UnityEngine;
using UnityEngine.Video;

public class AreaVideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Assign the VideoPlayer component
    public string playerTag = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            if (!videoPlayer.isPlaying)
            {
                videoPlayer.Play();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            if (videoPlayer.isPlaying)
            {
                videoPlayer.Pause(); // or .Stop() if you want it to reset
            }
        }
    }
}
