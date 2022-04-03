using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class MoveSideToSide : MonoBehaviour
{
    public float xSpeed;
    public float minX;
    public float maxX;
    
    
    public float current;

    private float randomOffset = 0;

    private void Start()
    {
        randomOffset = Random.Range(0, 100f);
    }

    private void FixedUpdate()
    {
        Vector3 currentPos = transform.position;
        current = Mathf.PingPong(Time.time + randomOffset, maxX);
        transform.position = Vector3.MoveTowards(currentPos, new Vector3(current + minX, currentPos.y, currentPos.z), xSpeed * Time.fixedDeltaTime);
    }
}
