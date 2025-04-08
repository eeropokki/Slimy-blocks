using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    public GameObject wallPrefab;  // Seinän prefab
    public float wallHeight = 10f; // Seinä on yhtä korkea kuin pelialue
    public float wallWidth = 10f;  // Seinä on yhtä leveä kuin pelialue
    public float wallLength = 10f;
    public float floorWidth = 10f; // Lattian leveys
    public float floorLength = 10f; // Lattian pituus


    void Start()
    {
        SpawnWallsAndFloor();
    }

    void SpawnWallsAndFloor()
    {
        // Takaseinä
        CreateWall(new Vector3(0, wallHeight / 2, -wallLength / 2), new Vector3(wallWidth, 1, 1));

        // Vasemmanpuoleinen seinä
        CreateWall(new Vector3(-wallWidth / 2, wallHeight / 2, 0), new Vector3(1, wallHeight, wallLength));

        // Oikeanpuoleinen seinä
        CreateWall(new Vector3(wallWidth / 2, wallHeight / 2, 0), new Vector3(1, wallHeight, wallLength));

        // Alaseinä (lattia)
        CreateFloor(new Vector3(0, -wallHeight / 2, 0), new Vector3(wallWidth, 1, wallLength));
    }

    void CreateWall(Vector3 position, Vector3 scale)
    {
        GameObject wall = Instantiate(wallPrefab, position, Quaternion.identity); // Luodaan seinä
        wall.transform.localScale = scale;  // Asetetaan seinän koko
    }

    void CreateFloor(Vector3 position, Vector3 scale)
    {
        GameObject floor = Instantiate(wallPrefab, position, Quaternion.identity); // Luodaan lattia
        floor.transform.localScale = scale;  // Asetetaan lattian koko
    }
}
