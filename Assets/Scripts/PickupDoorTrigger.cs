using UnityEngine;

public class PickupDoorTrigger : MonoBehaviour
{
    [Tooltip("Number of pickups required to destroy this door.")]
    public int requiredPickups = 1;

    [Tooltip("Reference to the PlayerController script.")]
    public PlayerController player;

    private bool doorDestroyed = false;

    void Update()
    {
        if (!doorDestroyed && player != null && player.GetPickupCount() >= requiredPickups)
        {
            Destroy(gameObject);
            doorDestroyed = true;
        }
    }
}
