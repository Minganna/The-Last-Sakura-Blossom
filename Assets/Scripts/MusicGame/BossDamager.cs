using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossDamager : MonoBehaviour {
    public int Bosshealth = 20;
    public Slider Bosshealthbar;
    public KeyCode keyRedPlayer1;
    public KeyCode keyBluePlayer1;
    public KeyCode keyRedPlayer2;
    public KeyCode keyBluePlayer2;
    public NoteDestroyer Playerhealth;
    public SorMplayers Damaging;
    
    

    // Use this for initialization
    void Start () {
        Playerhealth.GetComponent<NoteDestroyer>();

        
    }
	
	// Update is called once per frame
	void Update () {
        Bosshealthbar.value = Bosshealth;
        

    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (Bosshealth > 0)
        {
            if (Input.GetKeyDown(keyRedPlayer1) || Input.GetKeyDown(keyBluePlayer1) || Input.GetKeyDown(keyRedPlayer2) || Input.GetKeyDown(keyBluePlayer2)||Input.GetButtonDown("ButtonX")|| Input.GetButtonDown("ButtonCircle"))
            {
                if (col.gameObject.tag == "NoteRed" || col.gameObject.tag == "NoteBlue" || col.gameObject.tag == "NotePurple")

                    if (Damaging.bossy == false)
                    { Bosshealth -= 1; }
                if (Playerhealth.health < 40 && Playerhealth.health > 0)
                {
                    Playerhealth.health += 1;
                }
            }
        }
    }
    }
