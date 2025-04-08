using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    public GameObject wallPrefab; // Seinän prefab
    public float gridWidth = 10;  // Pelialueen leveys
    public float gridHeight = 10; // Pelialueen korkeus

    void Start()
    {
        CreateWalls();
    }

    void CreateWalls()
    {
        // Luo ylä- ja alaseinät
        Instantiate(wallPrefab, new Vector3(0, gridHeight / 2, 0), Quaternion.identity); // Yläseinä
        Instantiate(wallPrefab, new Vector3(0, -gridHeight / 2, 0), Quaternion.identity); // Alaseinä

        // Luo vasen ja oikea seinä
        Instantiate(wallPrefab, new Vector3(-gridWidth / 2, 0, 0), Quaternion.identity); // Vasemmalla
        Instantiate(wallPrefab, new Vector3(gridWidth / 2, 0, 0), Quaternion.identity);  // Oikealla
    }
}
