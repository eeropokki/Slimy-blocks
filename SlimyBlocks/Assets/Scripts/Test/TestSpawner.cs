using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class TestSpawner : MonoBehaviour
{
    public GameObject blockPrefab;
    public float spawnInterval = 1f;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            timer = 0f;
            SpawnRandomBlock();
        }
    }

    void SpawnRandomBlock()
    {
        int x = Random.Range(0, 10); // Grid leveys
        Vector3 spawnPos = new Vector3(x, 19, 0); // Spawnaa ylhäältä

        GameObject block = Instantiate(blockPrefab, spawnPos, Quaternion.identity);

        // Väri
        Renderer renderer = block.GetComponent<Renderer>();
        renderer.material = new Material(renderer.material);
        renderer.material.color = GetRandomColor();

        // Tallennetaan väri myös Block-skriptiin
        Block b = block.GetComponent<Block>();
        b.color = renderer.material.color;
    }

    Color GetRandomColor()
    {
        Color[] colors = { Color.red, Color.blue, Color.green, Color.yellow };
        return colors[Random.Range(0, colors.Length)];
    }
}

