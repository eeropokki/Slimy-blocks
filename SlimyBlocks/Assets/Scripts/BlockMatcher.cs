using System;
using System.Collections.Generic;
using UnityEngine;

public class BlockMatcher : MonoBehaviour
{
    public static BlockMatcher Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void CheckMatch(Vector2Int origin)
    {
        Color matchColor = GridManager.Instance.GetBlockAt(origin).GetColor();
        List<Vector2Int> matched = new List<Vector2Int>();
        HashSet<Vector2Int> visited = new HashSet<Vector2Int>();

        FloodFill(origin, matchColor, matched, visited);

        if (matched.Count >=3)
        {
            foreach (var pos in matched)
            {
                Block b = GridManager.Instance.GetBlockAt(pos);
                if (b != null)
                {
                    Destroy(b.gameObject);
                    GridManager.Instance.ClearBlockAt(pos);
                }
            }

            Debug.Log($"Match! Removed {matched.Count} blocks.");
        }
    }

    private void FloodFill(Vector2Int pos, Color targetColor, List<Vector2Int> matched, HashSet<Vector2Int> visited)
    {
        if (visited.Contains(pos)) return;
        visited.Add(pos);

        Block b = GridManager.Instance.GetBlockAt(pos);
        if (b == null || b.GetColor() != targetColor) return;

        matched.Add(pos);

        FloodFill(pos + Vector2Int.up, targetColor, matched, visited);
        FloodFill(pos + Vector2Int.down, targetColor, matched, visited);
        FloodFill(pos + Vector2Int.left, targetColor, matched, visited);
        FloodFill(pos + Vector2Int.right, targetColor, matched, visited);
    }
}
