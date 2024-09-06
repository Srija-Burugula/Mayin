using UnityEngine;

public class cubeMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float distanceToMove = 5f;

    private bool hasMoved = false;
    private void Start()
{
    // Ensure the cube starts above the terrain surface
    RaycastHit hit;
    if (Physics.Raycast(transform.position, Vector3.down, out hit))
    {
        transform.position = hit.point + Vector3.up * 0.5f; // Adjust 0.5f as needed
    }
}

    private void Update()
    {
        // Check if the cube has moved the specified distance
        if (!hasMoved)
        {
            // Move the cube forward
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

            // Check if the cube has reached the desired distance
            if (transform.position.z >= distanceToMove)
            {
                hasMoved = true;
                Debug.Log("Cube has moved forward by " + distanceToMove + " units.");
            }
        }
    }
}
