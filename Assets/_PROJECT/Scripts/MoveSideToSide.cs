using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSideToSide : MonoBehaviour
{
    public float xSpeed;
    public float minX;
    public float maxX;
    
    
    public float current;
    
    private void FixedUpdate()
    {
        Vector3 currentPos = transform.position;
        current = Mathf.PingPong(Time.time, maxX);
        transform.position = Vector3.MoveTowards(currentPos, new Vector3(current + minX, currentPos.y, currentPos.z), xSpeed * Time.fixedDeltaTime);
    }
}
