using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LaserGun : MonoBehaviour
{
    public float bulletDamage;
    public float bulletSpeed;
    
    public float fireCooldown;
    public float lastShotFired;

    public GameObject bullet;

    public bool shooting;

    
    public void Shoot(InputAction.CallbackContext ctx)
    {

        if (ctx.started)
        {
            shooting = true;
        }

        if (ctx.canceled)
        {
            shooting = false;
        }
    }

    private void Update()
    {
        if (shooting)
        {
            if (Time.fixedTime - lastShotFired > fireCooldown)
            {
                lastShotFired = Time.fixedTime;
                GameObject bulletGO = Instantiate(bullet, transform.position, transform.rotation);
                bulletGO.tag = gameObject.tag;
                Bullet b = bulletGO.GetComponent<Bullet>();

                //Calculate any damage/speed buffs here
                b.speed = bulletSpeed;
                b.damage = bulletDamage;

            }
        }
    }
}
