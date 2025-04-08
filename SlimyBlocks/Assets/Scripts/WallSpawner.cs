using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    public GameObject wallPrefab; // Sein�n prefab
    public float gridWidth = 10;  // Pelialueen leveys
    public float gridHeight = 10; // Pelialueen korkeus

    void Start()
    {
        CreateWalls();
    }

    void CreateWalls()
    {
        // Luo yl�- ja alasein�t
        Instantiate(wallPrefab, new Vector3(0, gridHeight / 2, 0), Quaternion.identity); // Yl�sein�
        Instantiate(wallPrefab, new Vector3(0, -gridHeight / 2, 0), Quaternion.identity); // Alasein�

        // Luo vasen ja oikea sein�
        Instantiate(wallPrefab, new Vector3(-gridWidth / 2, 0, 0), Quaternion.identity); // Vasemmalla
        Instantiate(wallPrefab, new Vector3(gridWidth / 2, 0, 0), Quaternion.identity);  // Oikealla
    }
}
