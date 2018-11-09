using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour {

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





    void Start()
    {
        old = color.color;

    }

    // Use this for initialization
    void Awake()
    {
        color = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
       
        if (numbjoy == 1)
        {
            if (Createmode == true && Input.GetKeyDown(keyRed) || Createmode == true && Input.GetButtonDown("ButtonSquare"))
            {
                Instantiate(NR, gameObject.transform.position, Quaternion.identity);
            }
            if (Createmode == true && Input.GetKeyDown(keyBlue) || Createmode == true && Input.GetButtonDown("ButtonTriangle"))
            {
                Instantiate(NB, gameObject.transform.position, Quaternion.identity);
            }
            if (Createmode == true && Input.GetKeyDown(keyRed) && Input.GetKeyDown(keyBlue) || Createmode == true && Input.GetButtonDown("ButtonTriangle") && Input.GetButtonDown("ButtonSquare"))
            {
                Instantiate(NP, gameObject.transform.position, Quaternion.identity);
            }
            else
            {
                if (Input.GetKeyDown(keyRed) || Input.GetKeyDown(keyBlue) || Input.GetButtonDown("ButtonSquare") || Input.GetButtonDown("ButtonTriangle"))
                {
                    StartCoroutine(notedone());
                }
                if (Input.GetKeyDown(keyRed) && active || Input.GetButtonDown("ButtonSquare") && active)
                {
                    Destroy(noteRed);
                }
                if (Input.GetKeyDown(keyBlue) && active || Input.GetButtonDown("ButtonTriangle") && active)
                {
                    Destroy(noteBlue);
                }
                if (Input.GetKeyDown(keyBlue) && Input.GetKeyDown(keyRed) && active || Input.GetButtonDown("ButtonSquare") && Input.GetButtonDown("ButtonTriangle") && active)
                {
                    Destroy(notePurple);
                }
            }
        }




    }

    void OnTriggerEnter2D(Collider2D col)
    {
        active = true;

        if (col.gameObject.tag == "NoteRed")
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
