using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yScroller : MonoBehaviour
{
    public float scrollSpeed;

    private void FixedUpdate()
    {
        transform.Translate(Vector3.up * (scrollSpeed * Time.fixedDeltaTime));
    }
}
