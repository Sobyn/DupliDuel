using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadBullet : MonoBehaviour
{
    [SerializeField] 
    [Tooltip("The opponent's number of copies")]
    private int copies;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            //Destroy(collision.gameObject);
            Instantiate(collision.gameObject);
            copies++;
            Destroy(transform.gameObject);
        }

        else
        {
            Destroy(transform.gameObject);
        }
    }

    private void Update()
    {
        if ( copies == 5)
        {
            print("You lost.");
        }
    }
}
