using UnityEngine;


public class LogicScript : MonoBehaviour
{
    public UnityEngine.UI.Text scoreText;
    private int score = 0;

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        score += 1;
        scoreText.text = score.ToString();
    }

    public void resetScore()
    {
        score = 0;
        scoreText.text = score.ToString();
    }
}
