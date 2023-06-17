using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public GameObject prefab;
    public float minX;
    public float maxX;
    public Sprite[] sprites;
    public float startTime;
    private float time;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if (time <= 0)
        {
            spawnObject();
            time = startTime;
        }
        else
        {
            time -= Time.deltaTime;
        }
    }
    void spawnObject()
    {
        GameObject newprefab = Instantiate(prefab);
        newprefab.transform.position = new Vector2(
            Random.Range(minX, maxX),
            transform.position.y);
        Sprite randomSprite = sprites[Random.Range(0, sprites.Length)];
        newprefab.GetComponent<SpriteRenderer>().sprite = randomSprite;
    }
    
}
