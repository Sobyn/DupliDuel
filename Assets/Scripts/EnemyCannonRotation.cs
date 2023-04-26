using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using Unity.Mathematics;
using UnityEngine;

//
// This script makes the cannon tower rotate towards the player at all times
// 


public class EnemyCannonRotation : MonoBehaviour
{
    //values set in the inspector
    public Transform playerTarget;
    public float rotationSpeed;

    //values for internal use
    //private Quaternion lookRotation;
    private Vector3 direction;
    
    void FixedUpdate()
    {
        //find the vector pointing from our position to the target
        direction = (transform.position - playerTarget.position).normalized;

        //create the rotation we need to be in to look at the target
        //OLD: lookRotation = Quaternion.LookRotation(direction);

        //retrieve current angle
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        //quaternion stuff
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        //rotate us over time according to speed until we are in the required rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.fixedDeltaTime * rotationSpeed);

        //needed for all of this to work in 2D, somehow
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);
    }
}
