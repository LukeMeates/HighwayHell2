using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("PowerUp"))
        {
            Destroy(collision.gameObject);
        }

        else if (collision.collider.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
        }
    }
}