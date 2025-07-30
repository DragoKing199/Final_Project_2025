using UnityEngine;
public class Portal : MonoBehaviour
{
    [Tooltip("Where the player should teleport to.")]
    public Transform teleportTarget;
    [Tooltip("Optional: set a rotation for the player to face after teleporting.")]
    public Transform rotationTarget;
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CharacterController controller = other.GetComponent<CharacterController>();
            if (controller != null)
            {
                controller.enabled = false;
                other.transform.position = teleportTarget.position;
                if (rotationTarget != null)
                    other.transform.rotation = rotationTarget.rotation;
                controller.enabled = true;
            }
            else
            {
                other.transform.position = teleportTarget.position;
                if (rotationTarget != null)
                    other.transform.rotation = rotationTarget.rotation;
            }
            // Optional: also rotate the camera if it's not a child of the player
            Camera mainCam = Camera.main;
            if (mainCam != null && rotationTarget != null)
            {
                mainCam.transform.rotation = rotationTarget.rotation;
            }
            Debug.Log("Player teleported and rotation matched to target!");
            // :white_check_mark: Spawn the collectabl
    
        }
    }
}
