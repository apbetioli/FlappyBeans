using UnityEngine;

public class ScrollObjects : MonoBehaviour
{
    public GameManager gameManager;
    public float speedMultiplier = 1;
    public float size = 5.63f;

    private SpriteRenderer[] children;

    void Start()
    {
        children = GetComponentsInChildren<SpriteRenderer>();
    }

    void Update()
    {
        foreach (SpriteRenderer spriteRenderer in children)
        {
            Vector2 position = spriteRenderer.transform.position;
            position.x -= gameManager.speed * speedMultiplier * Time.deltaTime;

            if (position.x <= -size)
            {
                position.x += 2 * size;
            }

            spriteRenderer.transform.position = position;
        }
    }
}
