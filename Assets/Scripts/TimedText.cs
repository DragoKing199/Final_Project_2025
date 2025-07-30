using UnityEngine;
using TMPro;

public class TimedText : MonoBehaviour
{
    public float displayTime = 3f; // Time before the text disappears

    private void OnEnable()
    {
        // Start countdown every time the text becomes active
        StartCoroutine(HideAfterTime());
    }

    private System.Collections.IEnumerator HideAfterTime()
    {
        yield return new WaitForSeconds(displayTime);
        gameObject.SetActive(false); // Hides the whole text object
    }
}
