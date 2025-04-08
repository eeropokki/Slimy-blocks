using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public GameObject blockPrefab;  // Palikkaprefabi
    public float spawnInterval = 1f;  // Mill� v�lein palikka spawnataan (sekunteina)

    private void Start()
    {
        // Aloita palikoiden spawnaaminen tietyll� aikav�lill�
        InvokeRepeating("SpawnBlock", 0f, spawnInterval);
    }

    private void SpawnBlock()
    {
        // Satunnainen X-koordinaatti ja Y-koordinaatti
        float spawnX = Random.Range(-4f, 4f);  // Satunnainen X-koordinaatti
        float spawnY = 6f;  // Spawnaa yl�puolelta (saat muuttaa tarpeen mukaan)

        // Luo uusi palikka
        Vector3 spawnPosition = new Vector3(spawnX, spawnY, 0);

        // Debug-viesti spawnauspaikasta
        Debug.Log("Spawning block at position: " + spawnPosition);

        // Spawnaa palikka
        Instantiate(blockPrefab, spawnPosition, Quaternion.identity);
    }
}