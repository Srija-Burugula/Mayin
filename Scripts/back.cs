using UnityEngine;
using UnityEngine.SceneManagement;
public class back : MonoBehaviour
{
public void Back()
    {
        SceneManager.LoadScene("SampleScene");
    }
}