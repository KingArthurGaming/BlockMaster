using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Gem : MonoBehaviour
{
    TextMeshProUGUI TextMesh;
    int Score;
    public void Gem1()
    { Score = (Score + 1); }
    public void Gem5()
    { Score = (Score + 5); }
    public void Gem50()
    { Score = (Score + 50); }
    private void Start()
    {
        TextMesh = GetComponent<TextMeshProUGUI>();
        Score = 0;
    }
    public void Update()
    {
        PlayerPrefs.SetInt("Score", Score);
        TextMesh.text = Score.ToString();

    }

}