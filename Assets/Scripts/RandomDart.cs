using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomDart : MonoBehaviour
{
    private const double V = 1.25;
    public GameObject realdartPrefab;
    //public Vector3 center;
    public Vector3 size;
    public Time time;
    public Vector3 spawnPosition;
    

    void Start()
    {
        spawnPosition = new Vector3(0, 0, 0); 
                                              
        InvokeRepeating("ChangePosition", 0, (float)V);    
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
        RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

        if (hit.collider != null)
        {
            if (hit.collider.tag == "dart")
            {

                
                SpawnNextDart();

                
            }
        }
    }



        public void SpawnNextDart()
        {
            Vector3 pos = new Vector3(Random.Range(-size.x / 3, size.x / 3), Random.Range(-size.y / 2, size.y / 2), 0);
            Instantiate(realdartPrefab, pos, Quaternion.identity);
            Destroy(gameObject);
        }
    void ChangePosition()
    {
        transform.position = spawnPosition;
        //Compute position for next time
        spawnPosition = new Vector3(Random.Range(-1, 9), Random.Range(-5, 5), Random.Range(-5, 5));
    }
    
    
    


}

