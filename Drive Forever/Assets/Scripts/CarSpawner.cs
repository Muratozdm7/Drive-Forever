using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject randomCarSpawn;
    bool canSpawn = true;

    
    void Start()
    {
        StartCoroutine(Bekle());
    }

    
    IEnumerator Bekle()
    {
        while (canSpawn == true)
        {
            Instantiate(randomCarSpawn, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
        }
    }
}
