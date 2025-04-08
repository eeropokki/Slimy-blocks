using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDrop : MonoBehaviour
{
    public float fallSpeed = 2f; // Putoamisnopeus
    public int gridWidth = 10;   // Ruudukon leveys
    public int gridHeight = 10;  // Ruudukon korkeus

    void Update()
    {
        // Lasketaan palikan sijaintia
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);

        // Tarkistetaan, onko palikka mennyt ruudukon alas (y <= 0)
        if (transform.position.y <= 0.5f)
        {
            LockBlock();
        }

        // Rajoitetaan palikan liikettä ruudukon sisälle (x ja y)
        Vector3 position = transform.position;

        // Estetään liikkuminen x-akselilla ruudukon rajoille
        position.x = Mathf.Clamp(position.x, 0, gridWidth - 1); // Rajoita X-akseli 0-9

        // Estetään liikkuminen y-akselilla ruudukon rajoille
        position.y = Mathf.Clamp(position.y, 0, gridHeight - 1); // Rajoita Y-akseli 0-9

        // Asetetaan uusi rajoitettu sijainti
        transform.position = position;
    }

    void LockBlock()
    {
        // Lukitse palikka, kun se saavuttaa alarajan
        Debug.Log("Palikka lukittu!");
        enabled = false; // Estää palikan liikkumisen enää
    }
}

    

