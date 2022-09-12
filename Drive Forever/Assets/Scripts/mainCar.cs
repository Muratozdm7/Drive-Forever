using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainCar : MonoBehaviour
{
    public float dikeyhiz, yatayhiz, varsayilanhiz;
    private float dikeyhareket, yatayhareket;
    Rigidbody2D rb;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
        dikeyhareket = Input.GetAxis("Vertical");
        yatayhareket = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(yatayhareket*50*yatayhiz*Time.deltaTime, varsayilanhiz+dikeyhareket*50*dikeyhiz*Time.deltaTime);

        if(transform.position.x > 1.85f)
        {
            Vector3 rightlimit = new Vector3(1.85f, transform.position.y);
            transform.position = rightlimit;
        }

        if(transform.position.x < -1.82f)
        {
            Vector3 leftlimit = new Vector3(-1.82f, transform.position.y);
            transform.position = leftlimit;
        }
    }
}
