using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{

    private static DontDestroy _instance;
    
    public static DontDestroy Instance
    {
        get { return _instance; }
    }
    
    // Start is called before the first frame update
    void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        } else {
            _instance = this;
        }
        
        DontDestroyOnLoad(gameObject);
    }
}
