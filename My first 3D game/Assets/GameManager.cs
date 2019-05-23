using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

     
    bool end = false;
    public float Delay = .01f;

    public void CompleteLevel()
    {

        Debug.Log("level won");
    }
    private void Start()
    {
        Time.timeScale = 1f;
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    private void Update()
    {
        if (end == true)
        {
            Time.timeScale += (0.5f) * Time.unscaledDeltaTime;
            Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
        }
    }
    public void EndGame()
    {
            Time.timeScale = 0.035f;
            Time.fixedDeltaTime = Time.timeScale * 0.02f;
            end = true;
            Debug.Log("GAME OVER");
            Invoke("restart", .2f);
    }
}
