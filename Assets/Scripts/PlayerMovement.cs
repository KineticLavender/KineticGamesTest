using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10.0f;
    private Vector3 moveDirection = Vector3.zero;
    CharacterController characterController;
    public Camera playerCamera;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        float forwardSpeed = Keyboard.current.wKey.isPressed ? speed : Keyboard.current.sKey.isPressed ? -speed : 0;
        float sideSpeed = Keyboard.current.dKey.isPressed ? speed : Keyboard.current.aKey.isPressed ? -speed : 0;

        Vector3 forward = playerCamera.transform.forward;
        forward.y = 0; // ignore vertical direction
        forward.Normalize();

        Vector3 right = playerCamera.transform.right;

        moveDirection = forward * forwardSpeed + right * sideSpeed;

        characterController.SimpleMove(moveDirection);
    }
}
