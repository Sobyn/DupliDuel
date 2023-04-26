using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonRotation : MonoBehaviour
{
    public float rotationSpeed;

    void FixedUpdate()
    {
        //get direction from player to mouse
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        //retrieve current angle
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        //quaternion stuff
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        //rotate smoothly from current rotation to mouse with a rotation speed
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.fixedDeltaTime * rotationSpeed);
    }
}
