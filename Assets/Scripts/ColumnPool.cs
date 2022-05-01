using UnityEngine;

public class ColumnPool : MonoBehaviour
{
    public GameManager gameManager;
    public int size = 5;
    public float distanceBetweenColumns = 3;
    public GameObject spawnPosition;
    public GameObject destroyPosition;
    public GameObject columnPrefab;

    private GameObject[] columns;

    void Start()
    {
        columns = new GameObject[size];

        Vector2 position = spawnPosition.transform.position;
        position.x = destroyPosition.transform.position.x + distanceBetweenColumns * size;
        spawnPosition.transform.position = position;

        for (int i = 0; i < size; i++)
        {
            position.y = Random.Range(-2.83f, 1.77f);

            GameObject column = Instantiate(columnPrefab, position, Quaternion.identity, transform);
            position.x += distanceBetweenColumns;
            columns[i] = column;
        }
    }

    void Update()
    {
        for (int i = 0; i < size; i++)
        {
            Vector2 pos = columns[i].transform.position;
            pos.x -= gameManager.speed * Time.deltaTime;

            if (pos.x <= destroyPosition.transform.position.x)
            {
                pos = spawnPosition.transform.position;
                pos.y = Random.Range(-2.83f, 1.77f);
            }

            columns[i].transform.position = pos;
        }
    }
}
