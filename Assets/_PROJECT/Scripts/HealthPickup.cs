using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public float replenishAmount;
    public GameObject pickupEffect;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Killable killable = other.GetComponent<Killable>();

        if (!killable) return;

        killable.TakeDamage(-replenishAmount);

        if (pickupEffect)
        {
            Instantiate(pickupEffect, transform.position, Quaternion.identity);
        }
        
        Destroy(gameObject);
        
    }
}
