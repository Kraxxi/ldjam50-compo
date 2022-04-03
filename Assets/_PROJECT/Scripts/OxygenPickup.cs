using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class OxygenPickup : MonoBehaviour
{
    public float replenishAmount;

    public GameObject pickupEffect;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        OxygenUser o2User = other.GetComponent<OxygenUser>();

        if (!o2User) return;
        
        o2User.currentOxygen += replenishAmount;
        if (o2User.currentOxygen > o2User.maxOxygen)
        {
            o2User.currentOxygen = o2User.maxOxygen;
        }
        
        if (pickupEffect)
        {
            Instantiate(pickupEffect, transform.position, Quaternion.identity);
        }

        Destroy(gameObject);
        
    }
}
