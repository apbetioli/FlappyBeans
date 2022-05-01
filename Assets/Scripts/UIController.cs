using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameManager gameManager;
    public Text score;
    public GameObject startScreen;
    public GameObject gameOverScreen;

    public GameObject silverMedal;
    public GameObject goldMedal;

    public Text gameOverScore;
    public Text gameOverBest;

    private void Start()
    {
        startScreen.SetActive(true);
        gameOverScreen.SetActive(false);
    }

    void Update()
    {
        if (gameManager.state != GameState.Waiting)
        {
            startScreen.SetActive(false);
            score.text = "" + gameManager.score;
        }

        if (gameManager.state == GameState.GameOver)
        {
            score.text = "";
            gameOverScore.text = "" + gameManager.score;
            gameOverBest.text = "" + gameManager.maxScore;

            gameOverScreen.SetActive(true);
            silverMedal.SetActive(false);
            goldMedal.SetActive(false);

            if (gameManager.score >= 20)
            {
                goldMedal.SetActive(true);
            }

            if (gameManager.score >= 10)
            {
                silverMedal.SetActive(true);
            }
        }

        if (gameManager.score > gameManager.maxScore)
        {
            score.color = Color.yellow;
        }
    }

    public void Play()
    {
        gameManager.Play();
    }
}

