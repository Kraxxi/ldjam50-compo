using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterAnimation : MonoBehaviour
{
    public Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        float animTime = anim.GetCurrentAnimatorStateInfo(0).length;
        
        Destroy(gameObject, animTime);
    }
}
