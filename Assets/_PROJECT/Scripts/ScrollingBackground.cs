using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public float scrollSpeed;

    private Renderer rend;
    private Vector2 savedOffset;

    void Start () {
        rend = GetComponent<Renderer> ();
    }

    void Update () {
        float y = Mathf.Repeat (Time.time * scrollSpeed, 1);
        Vector2 offset = new Vector2 (0, y);
        rend.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
