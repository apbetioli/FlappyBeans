using UnityEngine;

public class ScrollTexture : MonoBehaviour
{
    public GameManager gameManager;
    public float speedMultiplier = 1;

    private MeshRenderer meshRenderer;

    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        Vector2 offset = meshRenderer.material.mainTextureOffset;
        offset.x += gameManager.speed * speedMultiplier * Time.deltaTime;
        meshRenderer.material.mainTextureOffset = offset;
    }
}
