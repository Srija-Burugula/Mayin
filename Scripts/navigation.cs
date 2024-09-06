using UnityEngine;
using UnityEngine.UI;

public class navigation : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float rotationSpeed = 1f;

    // Assign buttons in the Inspector
    public Button forwardButton;
    public Button backwardButton;
    public Button turnLeftButton;
    public Button turnRightButton;

    void Start()
    {
        // Attach button click event handlers
        forwardButton.onClick.AddListener(MoveForward);
        backwardButton.onClick.AddListener(MoveBackward);
        turnLeftButton.onClick.AddListener(TurnLeft);
        turnRightButton.onClick.AddListener(TurnRight);
    }

    void MoveForward()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    void MoveBackward()
    {
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
    }

    void TurnLeft()
    {
        transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
    }

    void TurnRight()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}



