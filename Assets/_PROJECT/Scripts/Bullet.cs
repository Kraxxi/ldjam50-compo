using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage;
    public float speed;

    private void FixedUpdate()
    {
        transform.Translate(Vector3.up * (speed * Time.fixedDeltaTime) );
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //We tag player bullets with player and enemy bullets with enemy, prevent collisions between allies
        if (other.CompareTag(gameObject.tag)) return;
        
        Killable killable = other.GetComponent<Killable>();

        if (killable)
        {
            killable.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
