using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Destroy(collision.gameObject);
        Instantiate(collision.gameObject);
        Destroy(transform.gameObject);

    }
}
