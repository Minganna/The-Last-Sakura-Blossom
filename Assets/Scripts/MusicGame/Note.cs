using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note : MonoBehaviour
{

    activator getactivator;
    Player2 getPlayer2;
    GameObject Activator;
    GameObject Activator2;
    public int collisioncount = 0;
    Rigidbody2D rb;
     float speed=5f;
   
   


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Activator =GameObject.FindGameObjectWithTag("collider1");
        getactivator = Activator.GetComponent<activator>();
        Activator2 = GameObject.FindGameObjectWithTag("collider3");
        getPlayer2 = Activator2.GetComponent<Player2>();
        
        
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


    }
    void OnTriggerStay2D(Collider2D col)
    {
        
         if (col.gameObject.tag == "collider2" )
        {
            getactivator.GoodScore();
            getactivator.BadScore();
           
            
            collisioncount = 1;
           
        }

        else if (col.gameObject.tag == "collider1")
        {
            getactivator.PerfectScore();
            getactivator.BadScore();
          
            collisioncount = 1;
 
        }
        if (col.gameObject.tag == "collider4")
        {
            getPlayer2.GoodScore();
            getPlayer2.BadScore();
            collisioncount = 1;

        }

        else if (col.gameObject.tag == "collider3")
        {
            getPlayer2.PerfectScore();
            getPlayer2.BadScore();
            collisioncount = 1;

        }

    }

    void OnTriggerExit2D(Collider2D col)
    {
        collisioncount = 0;
    }

}

