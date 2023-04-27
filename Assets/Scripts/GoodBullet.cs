using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodBullet : MonoBehaviour
{

    [SerializeField]
    [Tooltip("The opponent's number of copies")]
    private int copies = 0;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Enemy")
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
        if (copies == 5)
        {
            print("YOU WON!");
        }
    }
}
