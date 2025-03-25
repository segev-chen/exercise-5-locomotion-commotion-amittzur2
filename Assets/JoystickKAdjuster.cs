using UnityEngine;
using UnityEngine.InputSystem;

public class JoystickKAdjuster : MonoBehaviour
{
    public CustomActionBasedController controller;
    public InputActionReference joystickInput; // Assign this in the Inspector
    public float speed = 0.1f; // Sensitivity of adjustment

    void Update()
    {
        if (controller == null || joystickInput == null)
            return;

        Vector2 joystickValue = joystickInput.action.ReadValue<Vector2>();
        Debug.Log("Joystick Value: " + joystickValue);

        // Use the vertical axis (up/down) to modify k
        controller.k += joystickValue.y * speed * Time.deltaTime;

        // Optional: Clamp k to prevent extreme values
        controller.k = Mathf.Clamp(controller.k, 0f, 5f);
    }
}
