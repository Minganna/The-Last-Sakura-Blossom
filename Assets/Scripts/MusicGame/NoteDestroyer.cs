using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteDestroyer : MonoBehaviour {
    public int health=10;
    public Slider healthbar;
   public  bool miss;


    void Update()
    {
       
        healthbar.value = health;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (health > 0)
        {
            if (other.gameObject.tag == "NoteRed")
            {
                Destroy(other.gameObject);
                health -= 1;
                miss = true;

            }
            if (other.gameObject.tag == "NoteBlue")
            {
                Destroy(other.gameObject);
                health -= 1;
                miss = true;
             
            }
            if (other.gameObject.tag == "NotePurple")
            {
                Destroy(other.gameObject);
                health -= 1;
                miss = true;
                
            }
            
        }
    }

    }
