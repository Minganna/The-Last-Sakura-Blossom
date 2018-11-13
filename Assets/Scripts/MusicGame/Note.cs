using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{

    Rigidbody2D rb;
    public float speed;
    public int whichcollider;
    activator getactivator;
    GameObject Activator;


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Activator=GameObject.FindGameObjectWithTag("collider1");
        getactivator = Activator.GetComponent<activator>();
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
    void Update()
    {
    if (Input.GetKeyDown(getactivator.keyRed)|| Input.GetKeyDown(getactivator.keyRed))
        {
            if (whichcollider==1)
            {
                Debug.Log("Bad");
            }
            if (whichcollider == 2)
            {
                Debug.Log("Good");
            }
            if (whichcollider == 3)
            {
                Debug.Log("Perfect");
            }
        }
    }
    void OnTriggerStay2D(Collider2D col)
    {
        
         if (col.gameObject.tag == "collider2" )
        {
            whichcollider = 2;
            getactivator.Goodorbad = whichcollider;
           
        }

        else if (col.gameObject.tag == "collider1")
        {
            whichcollider = 3;
            getactivator.Goodorbad = whichcollider;
 
        }
    }
    
}

