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
    Note Redsnotes;
    GameObject[] RedNotearray;
    public GameObject score1;
    GameObject score2;
    Text ScorePlayer1;
    Text ScorePlayer2;
    NoteDestroyer noteDestroy;
    GameObject NoteD;
    bool courodone=false;


    void Start()
    {
       old= color.color;
       
        ScorePlayer1 = score1.GetComponent<Text>();
       
        NoteD = GameObject.FindGameObjectWithTag("NoteDestroyer");
        noteDestroy = NoteD.GetComponent<NoteDestroyer>();


    }

    // Use this for initialization
    void Awake () {
        color = GetComponent<SpriteRenderer>();
       
	}
	
	// Update is called once per frame
	void Update () {

        if (noteDestroy.miss == true)
        {
            score1.SetActive(true);
             ScorePlayer1.text = "Miss";
            if (courodone == false)
            {
                courodone = true;
                StartCoroutine(TextAway());
            }

        }

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
        if (numbjoy == 1)
        {
            if (Input.GetKeyDown(keyRed) || Input.GetKeyDown(keyBlue) || Input.GetButtonDown("ButtonSquare") || Input.GetButtonDown("ButtonTriangle"))
            {
                StartCoroutine(notedone());
            }
            if (Input.GetKeyDown(keyRed) && active || Input.GetButtonDown("ButtonSquare") && active)
            {
                Destroy(noteRed);
                slash.Play();

            }
            if (Input.GetKeyDown(keyBlue) && active || Input.GetButtonDown("ButtonTriangle") && active)
            {
                Destroy(noteBlue);
                slash.Play();



            }
            if (Input.GetKeyDown(keyBlue) && Input.GetKeyDown(keyRed) && active || Input.GetButtonDown("ButtonSquare") && Input.GetButtonDown("ButtonTriangle") && active)
            {
                Destroy(notePurple);
                slash.Play();
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
    public void BadScore()
    {
        if (Input.GetKeyDown(keyBlue) && noteRed || Input.GetKeyDown(keyRed) && noteBlue)
        {
            score1.SetActive(true);
            ScorePlayer1.text = "Bad";
            noteDestroy.miss =false;
            if (courodone == false)
            {
                courodone = true;
                StartCoroutine(TextAway());
            }
        }

    }
    public void GoodScore()
    {
        if (Input.GetKeyDown(keyRed) && noteRed|| Input.GetKeyDown(keyBlue) && noteBlue|| Input.GetKeyDown(keyRed)&& Input.GetKeyDown(keyBlue)&&notePurple)
        {
            score1.SetActive(true);
            ScorePlayer1.text = "Good";
            noteDestroy.miss = false;
            if (courodone == false)
            {
                courodone = true;
                StartCoroutine(TextAway());
            }
        }
    }
    public void PerfectScore()
    {
        if (Input.GetKeyDown(keyRed) && noteRed || Input.GetKeyDown(keyBlue) && noteBlue || Input.GetKeyDown(keyRed) && Input.GetKeyDown(keyBlue) && notePurple)
        {
            score1.SetActive(true);
            ScorePlayer1.text = "Perfect";
            noteDestroy.miss = false;
            if (courodone == false)
            {
                courodone = true;
                StartCoroutine(TextAway());
            }
        }

    }


    IEnumerator TextAway()
    {
        yield return new WaitForSeconds(0.2f);
        score1.SetActive(false);
        courodone = false;
    }
}
