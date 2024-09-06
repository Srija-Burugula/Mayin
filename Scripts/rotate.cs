using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public float moveSpeed = 1.3f;
    public float rotationSpeed = 0.7f;

    void Update()
    {
        // Get input for movement and rotation
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * moveSpeed * Time.deltaTime;

        // Move the object
        transform.Translate(movement);

        // Calculate rotation
        float rotation = horizontalInput * rotationSpeed * Time.deltaTime;

        // Rotate the object
        transform.Rotate(0f, rotation, 0f);
    }
}