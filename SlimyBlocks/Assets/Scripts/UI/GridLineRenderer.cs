using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridLineRenderer : MonoBehaviour
{
    public int width = 10;
    public int height = 10;
    public float cellSize = 1f;

    private LineRenderer lineRenderer;

    void Start()
    {
        lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer.positionCount = (width + height) * 2; // Lasketaan viivojen m‰‰r‰
        lineRenderer.startWidth = 0.05f;
        lineRenderer.endWidth = 0.05f;
        lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
        lineRenderer.startColor = Color.black;
        lineRenderer.endColor = Color.black;
        DrawGrid();
    }

    void DrawGrid()
    {
        int index = 0;

        // Piirr‰ pystysuorat viivat
        for (int x = 0; x <= width; x++)
        {
            lineRenderer.SetPosition(index++, new Vector3(x * cellSize, 0, 0));
            lineRenderer.SetPosition(index++, new Vector3(x * cellSize, height * cellSize, 0));
        }

        // Piirr‰ vaakasuorat viivat
        for (int y = 0; y <= height; y++)
        {
            lineRenderer.SetPosition(index++, new Vector3(0, y * cellSize, 0));
            lineRenderer.SetPosition(index++, new Vector3(width * cellSize, y * cellSize, 0));
        }
    }
}
