using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField]
    [Tooltip("The movement speed")]
    private float movementSpeed = 5f;

    [SerializeField]
    [Tooltip("The distance to stop at")]
    private float distStop = 1.5f;


    [SerializeField]
    [Tooltip("The target's transform")]
    private Transform player;

    [SerializeField]
    [Tooltip("The rigidbody")]
    private Rigidbody2D rb;

    /*[SerializeField]
    [Tooltip("The thrust force")]
    private float thrust = -300f;*/

    private Vector2 Position
    {
        get
        {
            return transform.position;
        }

        set
        {
            transform.position = value;
        }
    }


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        float dist = Vector2.Distance(Position, player.position);
        float step = movementSpeed * Time.fixedDeltaTime;

        if (dist >= distStop)
        {
            Position = Vector2.MoveTowards(Position, player.position, step);
            rb.MovePosition(Position);
        }
    }
}
