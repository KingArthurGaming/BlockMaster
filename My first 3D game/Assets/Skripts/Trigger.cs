using UnityEngine;

public class Trigger : MonoBehaviour {

    
    public void OnTriggerEnter(Collider Player)
    {
         FindObjectOfType<GameManager>().CompleteLevel();
    }
}
