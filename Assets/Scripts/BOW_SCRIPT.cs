using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BOW_SCRIPT : MonoBehaviour
{
    public static event Action ArrowIsSend = delegate { };
    Rigidbody2D _rb;
    
    //Vector3 velocity = new Vector3(10f/*x*/, 10f/*y*/, 10f/*z*/);
    //private const double V = 1.25;
    public Vector2 direction;
   
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        //GetComponent<Rigidbody>().velocity = velocity;
    }

    // Update is called once per frame
    void Update()
    {
        

        Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 BowPos = transform.position;
        direction = MousePos - BowPos;
        
        FaceMouse();
    }
    void FaceMouse()
    {
        transform.right = direction;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Shaft"))
        {
            _rb.velocity = Vector2.right;



        }
    }



}
