using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    // Get the character controller of the player
    CharacterController characterController;

    // Get the camera object for the player
    public Transform verticalRotater;

    public float moveSpeed = 300f;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Lock the player's cursor.
        Cursor.lockState = CursorLockMode.Locked;

        // Move the character forwards and backwards
        // as the player presses W and S (Vertical axis).

        Vector3 forwardMovemnt = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime * transform.TransformDirection(Vector3.forward);
        Vector3 strafeMovement = Input.GetAxis("Horizontal") * (moveSpeed / 2) * Time.deltaTime * transform.TransformDirection(Vector3.right);

        // TODO: Fix simple movement so there isn't 2 calls per frame
        characterController.SimpleMove(forwardMovemnt);
        //characterController.SimpleMove(strafeMovement);

        // Turn the character left and right
        // as the player moves their mouse on the axis.
        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0));

        // Move the camera up and down as the player moves their mouse on the Y axis.
        verticalRotater.Rotate(new Vector3(-Input.GetAxis("Mouse Y"), 0, 0));
    }
}
