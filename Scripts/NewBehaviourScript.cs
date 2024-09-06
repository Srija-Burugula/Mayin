using UnityEngine;
using UnityEngine.UI;

public class FollowObjectScript : MonoBehaviour
{
    public Transform targetObject;
    public Text labelText;

    private void Update()
    {
        if (targetObject != null)
        {
            Vector3 screenPos = Camera.main.WorldToScreenPoint(targetObject.position);
            labelText.transform.position = screenPos;
        }
    }
}
