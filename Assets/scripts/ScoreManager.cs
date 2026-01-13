using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    private int score = 0;

    public void AddScore(int points)
    {
        score++;
        scoreText.text = "" + score;
    }
    public void UpdateHealthHUD()
    {
        scoreText.text = "" + score;
    }
}