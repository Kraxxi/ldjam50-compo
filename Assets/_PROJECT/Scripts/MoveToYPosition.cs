using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToYPosition : MonoBehaviour
{
    public float ySpeed;
    public float targetY;
    
    private void FixedUpdate()
    {
        Vector3 currentPos = transform.position;
        transform.position = Vector3.MoveTowards(currentPos, new Vector3(currentPos.x, targetY, currentPos.z), ySpeed * Time.fixedDeltaTime);
    }
}
