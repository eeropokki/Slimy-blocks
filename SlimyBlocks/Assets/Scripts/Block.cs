using UnityEngine;

public class Block : MonoBehaviour
{
    public Color color;

    public Color GetColor()
    {
        return GetComponent<Renderer>().material.color;
    }

    private void Start()
    {
        Vector2Int gridPos = GridManager.Instance.WorldToGrid(transform.position);
        GridManager.Instance.SetBlockAt(gridPos, this);
    }
}

