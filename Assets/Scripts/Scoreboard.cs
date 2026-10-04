using UnityEngine;
using TMPro;
public class Scoreboard : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    private int score = 0;

    public void IncreaseScore(int amount)
    {
        score += amount;
        scoreText.text = score.ToString();
    }
}
