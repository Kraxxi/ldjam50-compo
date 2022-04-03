using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenUser : MonoBehaviour
{
    public float maxOxygen;
    public float currentOxygen;

    public float depletionAmount;
    public float depletionCooldown;

    public float oxygenDamage;
    public float oxygenDamageCooldown;


    public Transform oxygenFill;
    public Killable playerKillable;
    
    // Start is called before the first frame update
    void Start()
    {
        currentOxygen = maxOxygen;

        StartCoroutine(Deplete0xygen());
    }


    public IEnumerator Deplete0xygen()
    {
        while (playerKillable.isAlive)
        {
            if (currentOxygen > 0)
            {

                yield return new WaitForSeconds(depletionCooldown);
                currentOxygen -= depletionAmount;

                if (currentOxygen < 0)
                {
                    currentOxygen = 0;
                }

                float percentage = currentOxygen / maxOxygen;
                
                oxygenFill.transform.localScale = new Vector3(
                    percentage,
                    oxygenFill.transform.localScale.y,
                    oxygenFill.transform.localScale.z);
                
            }
            else
            {
                yield return new WaitForSeconds(oxygenDamageCooldown);
                playerKillable.TakeDamage(oxygenDamage);
            }
        }
    }

    public IEnumerator DepleteHealth()
    {
        while (playerKillable.isAlive && playerKillable.currentHealth > 0)
        {
            playerKillable.TakeDamage(oxygenDamage);
            yield return new WaitForSeconds(oxygenDamageCooldown);
        }
    }
}
