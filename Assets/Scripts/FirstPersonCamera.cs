using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonCamera : MonoBehaviour
{
    public float sensitivity = 2.0f;
    public float maxYAngle = 80.0f;
    private float rotationY = 0.0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        Vector2 mouseInput = Mouse.current.delta.ReadValue();

        float rotationX = transform.localEulerAngles.y + mouseInput.x * sensitivity;
        rotationY += mouseInput.y * sensitivity;
        rotationY = Mathf.Clamp(rotationY, -maxYAngle, maxYAngle);
        transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
    }
}
