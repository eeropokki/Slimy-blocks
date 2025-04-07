using System.Collections;
using System.Collections.Generic;
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
            SpawnLock();
            timer = 0f;
        }
    }

    private void SpawnLock()
    {
        Instantiate(blockPrefab, transform.position, Quaternion.identity);
    }
}