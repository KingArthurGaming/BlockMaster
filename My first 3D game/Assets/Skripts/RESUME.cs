using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RESUME : MonoBehaviour
{
    public GameObject PauseUI;

    public bool resume = true;

    public void Resume()
    {
        Debug.Log("resume");
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
        resume = false;

    }
    public void pause()
    {
        Debug.Log("pause");
        PauseUI.SetActive(true);
        Time.timeScale = 0f;
        resume = true;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (resume == true)
            {
                Resume();
                
            }
            else
            {
                pause();
                
            }
            
            

        }
    }
}
	

