using System.Collections.Generic;
using UnityEngine;

public class LootSpawner : MonoBehaviour
{

    public List<GameObject> lootPrefabs;
    
    public void DropLoot()
    {
        Instantiate(lootPrefabs[Random.Range(0, lootPrefabs.Count)], transform.position, Quaternion.identity);
    }
}
