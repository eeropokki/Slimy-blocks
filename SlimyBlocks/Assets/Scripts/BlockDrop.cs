using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDrop : MonoBehaviour
{
    public float fallSpeed = 2f; // Falling speed

    void Update()
    {
        // Block falls down
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);

        // Check if block goes too far down
        if (transform.position.y <= 0.5f)
        {
            // Lock the block
            enabled = false;
        }
    }
}
