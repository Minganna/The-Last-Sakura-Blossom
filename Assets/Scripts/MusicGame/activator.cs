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
       
            if (Input.GetKeyDown(keyRed) || Input.GetKeyDown(keyBlue))
            {
                StartCoroutine(notedone());
            }
            if (Input.GetKeyDown(keyRed) && active)
            {
                Destroy(noteRed);
            }
            if (Input.GetKeyDown(keyBlue) && active)
            {
                Destroy(noteBlue);
            }
            if (Input.GetKeyDown(keyBlue) && Input.GetKeyDown(keyRed) && active)
            {
                Destroy(notePurple);
            }
        

       
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        active = true;
      
        if(col.gameObject.tag=="NoteRed")
        {
            noteRed = col.gameObject;
        }
        if (col.gameObject.tag == "NoteBlue")
        {
            noteBlue = col.gameObject;
        }
        if (col.gameObject.tag == "NotePurple")
        {
            notePurple = col.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
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
