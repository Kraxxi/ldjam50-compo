using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Events;

public class Killable : MonoBehaviour
{
    public bool isAlive;
    public float maxHealth;
    public float currentHealth;
    public Transform healthFill;

    public GameObject explosionPrefab;
    public UnityEvent onDeath;
    
    
    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float dmg)
    {

        currentHealth = currentHealth - dmg;

        if (currentHealth < 0)
        {
            currentHealth = 0;
        }
        
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        float percentage = currentHealth / maxHealth;
        
        healthFill.transform.localScale = new Vector3(
            percentage,
            healthFill.transform.localScale.y,
            healthFill.transform.localScale.z);
        
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Instantiate(explosionPrefab, transform.position, quaternion.identity);
        onDeath.Invoke();
        Destroy(gameObject);
    }
}
