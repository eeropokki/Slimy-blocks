using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public Color color;

    private void Start()
    {
        Vector2Int gridPos = GridManager.Instance.WorldToGrid(transform.position);
        GridManager.Instance.SetBlockAt(gridPos, this);
    }
}

