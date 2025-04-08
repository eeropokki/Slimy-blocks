using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public static GridManager Instance;

    public int width = 10;
    public int height = 20;
    public float cellSize = 1f;

    private Block[,] grid;

    private void Awake()
    {
        Instance = this;
        grid = new Block[width, height];
    }

    public Vector2Int GridToWorld(Vector3 worldPos)
    {
        int x = Mathf.RoundToInt(worldPos.x);
        int y = Mathf.RoundToInt(worldPos.y);
        return new Vector2Int(x, y);
    }

    public Vector2Int WorldToGrid(Vector3 worldPos)
    {
        int x = Mathf.RoundToInt(worldPos.x / cellSize);
        int y = Mathf.RoundToInt(worldPos.y / cellSize);
        return new Vector2Int(x, y);
    }

    public Vector3 GridToWorld(Vector2Int gridPos)
    {
        return new Vector3(gridPos.x, gridPos.y, 0);
    }

    public void SetBlockAt(Vector2Int pos, Block block)
    {
        if (IsInsideGrid(pos))
            grid[pos.x, pos.y] = block;
    }

    public Block GetBlockAt(Vector2Int pos)
    {
        if (IsInsideGrid(pos))
            return grid[pos.x, pos.y];
        return null;
    }

    public void ClearBlockAt(Vector2Int pos)
    {
        if (IsInsideGrid(pos))
            grid[pos.x, pos.y] = null; 
    }

    public bool IsInsideGrid(Vector2Int pos)
    {
        return pos.x >= 0 && pos.x < width && pos.y >= 0 && pos.y < height;
    }
}
