using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public UnityEngine.UI.Text scoreText;
    public GameObject gameOverScreen;
    public BirdScript bird;
    private int score = 0;

    void Start()
    {
        bird = GameObject.FindGameObjectWithTag("Player").GetComponent<BirdScript>();
    }

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
        gameOverScreen.SetActive(true);
        bird.isAlive = false;
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameOverScreen.SetActive(false);
        bird.isAlive = true;
    }
}
