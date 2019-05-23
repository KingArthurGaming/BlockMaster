
using UnityEngine;

public class Collision : MonoBehaviour
{
    GameObject Obstacle;
    
    GameManager end;

   

    public void OnCollisionEnter(UnityEngine.Collision Obstacle)
        
    {
        if (Obstacle.gameObject.name == "Player")
        {
            
            //bool boll = true;
            FindObjectOfType<GameManager>().EndGame();
        }
      
    }

}


