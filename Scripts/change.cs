using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change : MonoBehaviour
{
    // Start is called before the first frame update
    public void Loaddeer()
    {
        SceneManager.LoadScene("deer");
    }

    public void Loaddino()
    {
        SceneManager.LoadScene("dino");
    }
public void Loadgiraffe()
    {
        SceneManager.LoadScene("giraffe");
    }
public void Loadfirtree()
    {
        SceneManager.LoadScene("firtree");
    }
}
