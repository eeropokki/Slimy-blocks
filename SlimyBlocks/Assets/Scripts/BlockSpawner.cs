using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public GameObject blockPrefab;
    public float spwanInternal = 2;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spwanInternal)
        {
            SpawnBlock();
            timer = 0f;
        }
    }


    private void SpawnBlock()
    {
        GameObject newBlock = Instantiate(blockPrefab, transform.position, Quaternion.identity);

        Renderer renderer = newBlock.GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material = new Material(renderer.material);

            Color randomColor = GetRandomColor();
            renderer.material.color = randomColor;

            Debug.Log("Spawn color:" + randomColor);
        }
    }

    private Color GetRandomColor()
    {
        // List of available colors
        Color[] colors =
        {
            Color.red,
            Color.green,
            Color.blue,
            Color.yellow,
            Color.magenta,
            Color.cyan
        };

        return colors[Random.Range(0, colors.Length)];
    }
}