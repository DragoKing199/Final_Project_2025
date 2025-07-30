using UnityEngine;

public class MouseLook : MonoBehaviour
{
 public float sensitivity = 2f; // Controls mouse sensitivity
public Transform playerCamera; // Assign this in the inspector
    private Vector2 rotation = Vector2.zero;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        rotation.y += mouseX; // Horizontal (yaw)
        rotation.x -= mouseY; // Vertical (pitch)
        rotation.x = Mathf.Clamp(rotation.x, -80f, 80f);

        // Rotate the player left/right (horizontal rotation)
        transform.rotation = Quaternion.Euler(0f, rotation.y, 0f);

        // Rotate the camera up/down (vertical rotation)
        playerCamera.localRotation = Quaternion.Euler(rotation.x, 0f, 0f);
    }
}
