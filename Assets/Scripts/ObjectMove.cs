using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    private const float V = 10f;
    public Rigidbody2D rb;
    public float minX;
    public float minY;
    public float maxX;
    public float maxY;
    public float lifetime;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(
            Random.Range(minX, maxX),
            Random.Range(minY, maxY)
        );
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame

    

}
