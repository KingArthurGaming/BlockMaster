using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Gems : MonoBehaviour
{
    public TextMeshProUGUI text;
    public int Score;
    private void Update()
    {
        text.text = Score.ToString();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Score+=5;
            Destroy(other.gameObject);

        }
        if (other.gameObject.CompareTag("Coin5"))
        {
            Score += 10;
            Destroy(other.gameObject);

        }
        if (other.gameObject.CompareTag("Coin50"))
        {
            Score += 50;
            Destroy(other.gameObject);

        }
    }
}
