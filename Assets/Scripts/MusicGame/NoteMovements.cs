using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMovements : MonoBehaviour {
    Rigidbody2D rb;
    public float speed;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnEnable()
    {
        rb.velocity = new Vector2(-speed, 0);
    }
    // Use this for initialization
    void Start()
    {
        rb.velocity = new Vector2(-speed, 0);
    }

   
   
	// Update is called once per frame
	void Update () {
		
	}
}
