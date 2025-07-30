using UnityEngine;

public class ForceFieldController : MonoBehaviour
{
    public GameObject forceField;  // Assign your forcefield object
    public GameObject door;        // Assign the door object
    public Collider triggerZone;   // Assign the zone (must be a trigger)
    public string playerTag = "Player"; // Tag used to identify the player

    private bool doorGone = false;

    void Start()
    {
        if (forceField != null)
        {
            forceField.SetActive(false); // Start with forcefield off
        }
    }

    void Update()
    {
        // When door is destroyed, activate forcefield
        if (!doorGone && door == null)
        {
            doorGone = true;

            if (forceField != null)
            {
                forceField.SetActive(true);
                Debug.Log("Forcefield activated.");
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // If the player enters the zone, deactivate the forcefield
        if (doorGone && other.CompareTag(playerTag) && forceField != null && forceField.activeSelf)
        {
            forceField.SetActive(false);
            Debug.Log("Forcefield deactivated by player.");
        }
    }
}
