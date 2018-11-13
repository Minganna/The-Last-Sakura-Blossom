using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class activator : MonoBehaviour {
    SpriteRenderer color;
    public KeyCode keyRed;
    public KeyCode keyBlue;
    bool active = false;
    GameObject noteRed;
    GameObject noteBlue;
    GameObject notePurple;
    Color old;
    public bool Createmode;
    public GameObject NR;
    public GameObject NB;
    public GameObject NP;
    public int numbjoy;
    int damage=1;
    public NoteDestroyer inflictdamage;
    public AudioSource slash;
    public int Goodorbad;
 
   
  
    void Start()
    {
       old= color.color;
  

    }

    // Use this for initialization
    void Awake () {
        color = GetComponent<SpriteRenderer>();
       
	}
	
	// Update is called once per frame
	void Update () {
    
        
        if (numbjoy == 0)
        {
            if (Createmode == true && Input.GetKeyDown(keyRed) || Createmode == true && Input.GetButtonDown("ButtonX"))
            {
                Instantiate(NR, gameObject.transform.position, Quaternion.identity);
            }
            if (Createmode == true && Input.GetKeyDown(keyBlue) || Createmode == true && Input.GetButtonDown("ButtonCircle"))
            {
                Instantiate(NB, gameObject.transform.position, Quaternion.identity);
            }
            if (Createmode == true && Input.GetKeyDown(keyRed) && Input.GetKeyDown(keyBlue) || Createmode == true && Input.GetButtonDown("ButtonCircle") && Input.GetButtonDown("ButtonX"))
            {
                Instantiate(NP, gameObject.transform.position, Quaternion.identity);
            }
            else
            {
                if (Input.GetKeyDown(keyRed) || Input.GetKeyDown(keyBlue) || Input.GetButtonDown("ButtonX") || Input.GetButtonDown("ButtonCircle"))
                {
                    StartCoroutine(notedone());
                    
                }
                if (Input.GetKeyDown(keyRed) && active || Input.GetButtonDown("ButtonX") && active)
                {
                    Destroy(noteRed);
                    slash.Play();
                 
               

                }
                if (Input.GetKeyDown(keyBlue) && active || Input.GetButtonDown("ButtonCircle") && active)
                {
                    Destroy(noteBlue);
                    slash.Play();
                 

                }
                if (Input.GetKeyDown(keyBlue) && Input.GetKeyDown(keyRed) && active || Input.GetButtonDown("ButtonX") && Input.GetButtonDown("ButtonCircle") && active)
                {
                    Destroy(notePurple);
                    slash.Play();
                
                 
                }

            }
        }
           
                }
            
        

       
        
    

    void OnTriggerEnter2D(Collider2D col)
    {
        active = true;
       
            if (col.gameObject.tag == "NoteRed")
            {
                Goodorbad = 2;
                noteRed = col.gameObject;

            }
            if (col.gameObject.tag == "NoteBlue")
            {
                Goodorbad = 2;
                noteBlue = col.gameObject;
            }
            if (col.gameObject.tag == "NotePurple")
            {
                Goodorbad = 2;
                notePurple = col.gameObject;
            }
      
    }

   

        void OnTriggerExit2D(Collider2D col)
    {
        Goodorbad = 1;
        active = false;
        noteRed = null;
        notePurple = null;
        noteBlue = null;
    }

    IEnumerator notedone()
    {
   
        color.color = new Color(0, 0, 0);
        yield return new WaitForSeconds(0.2f);
        color.color = old;
    }
}
