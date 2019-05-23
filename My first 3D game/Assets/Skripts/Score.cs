using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour {
    public Transform player;
    public Text score;    
    public Text HighScore;
 
    void Update()
    {
        
        
        score.text = player.position.z.ToString("0");

       // PlayerPrefs.SetString("HighScore", player.position.z.ToString); 
    }
}
