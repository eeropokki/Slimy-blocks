using UnityEngine;
using UnityEngine.UI;

public class GridUI : MonoBehaviour
{
    public int width = 10;
    public int height = 20;
    public float cellSize = 100f;
    public GameObject cellPrefab;

    void Start()
    {
        CreateGrid();
    }

    void CreateGrid()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                // Luo ruutu UI:hen
                GameObject cell = Instantiate(cellPrefab, transform);
                RectTransform rt = cell.GetComponent<RectTransform>();
                rt.anchoredPosition = new Vector2(x * cellSize, -y * cellSize); // M‰‰ritell‰‰n sijainti
                rt.sizeDelta = new Vector2(cellSize, cellSize); // M‰‰ritell‰‰n koko
            }
        }
    }
}
