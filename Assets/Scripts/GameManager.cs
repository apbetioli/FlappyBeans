using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameState
{
    Waiting,
    Playing,
    GameOver
}

[CreateAssetMenu(menuName = "Scriptable Objects/Game Manager")]
public class GameManager : ScriptableObject
{
    public float initialSpeed = 1.5f;
    public float speed = 0;
    public GameState state = GameState.Waiting;
    public int score = 0;
    public int maxScore = 0;

    public void OnEnable()
    {
        maxScore = PlayerPrefs.GetInt("maxScore", 0);
    }

    public void LoadGame()
    {
        state = GameState.Waiting;
        speed = 0;
        score = 0;
    }

    public void StartGame()
    {
        state = GameState.Playing;
        speed = initialSpeed;
    }

    public void GameOver()
    {
        state = GameState.GameOver;
        speed = 0;

        if (score > maxScore)
        {
            maxScore = score;
            PlayerPrefs.SetInt("maxScore", maxScore);
        }

    }

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
