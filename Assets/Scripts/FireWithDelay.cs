using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWithDelay : MonoBehaviour
{
    [Tooltip("Prefab rigidbody to spawn")]
    [SerializeField]
    private Rigidbody2D bullet;

    [Tooltip("Empty object location to fire from")]
    [SerializeField]
    private Transform barrel;

    [Tooltip("Bullet speed (Default: 500)")]
    [Range(0f, 1000f)]
    [SerializeField] private float bulletSpeed = 500f;

    [Tooltip("Cooldown in seconds")]
    [Range(0f, 10f)]
    [SerializeField] private float cooldown = 1f;

    private float nextFire = 0f;

    [Tooltip("Knockback force (Default: 300)")]
    [Range(0f, 1000f)]
    [SerializeField] private float knockBack = 300f;

    [SerializeField]
    private Rigidbody2D rb;

    private void Start()
    {
        //rb = gameObject.GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        //if mousebutton is clicked, and cooldown is off
        if (Input.GetMouseButtonDown(0) && Time.time > nextFire)
        {
            //add cooldown
            nextFire = Time.time + cooldown;

            //instantiate bullet prefab at barrel's position, and with barrel's rotation
            var spawnedBullet = Instantiate(bullet, barrel.position, barrel.rotation);

            //add force to the bullet in the direction of the barrel's right side, with set speed
            spawnedBullet.AddForce(barrel.right * bulletSpeed);
            
            //add force to the player in the opposite direction
            rb.AddForce(-barrel.right * knockBack);
        }
    }
}
