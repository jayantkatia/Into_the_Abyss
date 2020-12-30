using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneSwitching : MonoBehaviour
{
    public void ButtonStart()
    {
        Application.LoadLevel(1);
    }

    public void ButtonCredit()
    {
        SceneManager.LoadScene(1);
    }
    public void ButtonQuit()
    {
        Application.Quit();
    }
}
