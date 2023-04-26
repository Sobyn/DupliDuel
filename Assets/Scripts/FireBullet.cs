using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D bullet;

    [SerializeField]
    private Transform barrel;

    private float bulletSpeed = 500f;


    // Update is called once per frame
    void Update()
    {
        //if mousebutton is clicked
        if(Input.GetMouseButtonDown(0))
        {
            //instantiate bullet prefab at barrel's position, and with barrel's rotation
            var spawnedBullet = Instantiate(bullet, barrel.position, barrel.rotation);

            //add force to the bullet in the direction of the barrel's right side, with set speed
            spawnedBullet.AddForce(barrel.right * bulletSpeed);
        }
    }
}
