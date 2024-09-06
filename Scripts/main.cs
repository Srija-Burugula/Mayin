using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
   public float moveSpeed = 5.0f;
    public float rotationSpeed = 2.0f;

    void Update()
    {
        // Camera Movement
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(horizontalMovement, 0, verticalMovement);
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

        // Camera Rotation
        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up, mouseX * rotationSpeed);

        // Additional logic for other inputs and smoother movement can be added here
    }
}