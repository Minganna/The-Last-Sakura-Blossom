using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawingClouds : MonoBehaviour {

    public GameObject[] CloudsPrefabs;
   
 

    float randx;
    float randy;
    Vector2 WhereToSpawn;
    public float rateSpawn = 2f;
    public float nextspawn = 0.0f;

    void Start()
    {
        
    }

    void Update()
    {
    
            if (Time.time > nextspawn)
            {
                nextspawn = Time.time + rateSpawn;
                randx = Random.Range(0f, 10f);
                randy = Random.Range(0, 4.31f);
                int cloudprefabnumb = Random.Range(0, 9);
                WhereToSpawn = new Vector2(transform.position.x + randx, transform.position.y + randy);
                Instantiate(CloudsPrefabs[cloudprefabnumb], WhereToSpawn, Quaternion.identity);
            }

    }

  

}
