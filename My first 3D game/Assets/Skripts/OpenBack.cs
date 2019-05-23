using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OpenBack : MonoBehaviour
{

    public void player1()
    {
        SceneManager.LoadScene(0);
    }
    public void quit1()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}

