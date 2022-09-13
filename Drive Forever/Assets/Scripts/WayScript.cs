using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayScript : MonoBehaviour
{
    public GameObject way;
    bool yolyapildi = false;

    void OnTriggerEnter2D(Collider2D temas)
    {
        if(temas.gameObject.tag == "mainCar" && yolyapildi == false)
        {
            Vector3 spawnlocation = new Vector3(transform.position.x, transform.position.y+10, 0);
            Instantiate(way, spawnlocation, Quaternion.identity);
            yolyapildi = true;
            ScoreManager.skor += 10;
            Destroy(this.gameObject, 5f);
        }
    }
}
