using UnityEngine;
using UnityEngine.InputSystem;

public class Bird : MonoBehaviour
{
    public GameManager gameManager;
    public float force = 5;
    public AudioSource coinAudioSource;
    public AudioSource flapAudioSource;
    public AudioSource gameOverAudioSource;
    public AudioSource highscoreAudioSource;

    private Rigidbody2D body;
    private Animator animator;

    private bool flap = false;

    private void Start()
    {
        gameManager.LoadGame();

        body = GetComponent<Rigidbody2D>();
        body.isKinematic = true;

        animator = GetComponentInChildren<Animator>();
    }

    public void Flap(InputAction.CallbackContext context)
    {
        flap = context.ReadValueAsButton();
    }

    private void Update()
    {
        if (gameManager.state == GameState.GameOver)
            return;

        animator.SetFloat("Y_Velocity", body.velocity.y);
    }

    private void FixedUpdate()
    {
        if (!flap)
            return;

        flap = false;

        if (gameManager.state == GameState.GameOver)
        {
            return;
        }

        if (gameManager.state == GameState.Waiting)
        {
            gameManager.StartGame();
            body.isKinematic = false;
        }
        else
        {
            gameManager.speed = (float)gameManager.initialSpeed + ((float)gameManager.score) / 20f;
        }

        body.velocity = Vector2.zero;
        body.AddForce(new Vector2(0, force));
        flapAudioSource.Play();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Die();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.score++;
        coinAudioSource.Play();
        if (gameManager.score == gameManager.maxScore + 1)
            highscoreAudioSource.Play();
    }

    private void Die()
    {
        if (gameManager.state == GameState.GameOver)
            return;

        gameManager.GameOver();
        gameOverAudioSource.Play();
        animator.SetTrigger("Die");
    }
}
