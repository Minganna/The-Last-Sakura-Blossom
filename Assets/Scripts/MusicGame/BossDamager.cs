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
            if (Input.GetKeyDown(keyRedPlayer1)&& col.gameObject.tag == "NoteRed" || Input.GetKeyDown(keyBluePlayer1)&&col.gameObject.tag == "NoteBlue" ||
                Input.GetKeyDown(keyRedPlayer2) && col.gameObject.tag == "NoteRed" || Input.GetKeyDown(keyBluePlayer2) && col.gameObject.tag == "NoteBlue"||
                Input.GetKeyDown(keyRedPlayer1)&&  Input.GetKeyDown(keyBluePlayer1)&& col.gameObject.tag == "NotePurple"||
                Input.GetButtonDown("ButtonX") && col.gameObject.tag == "NoteRed"|| Input.GetButtonDown("ButtonCircle")&& col.gameObject.tag == "NoteBlue"||
                Input.GetButtonDown("ButtonSquare") && col.gameObject.tag == "NoteRed" || Input.GetButtonDown("ButtonTriangle") && col.gameObject.tag == "NoteBlue" ||
                 Input.GetButtonDown("ButtonX") && Input.GetButtonDown("ButtonCircle")&& col.gameObject.tag == "NotePurple"||
                Input.GetButtonDown("ButtonSquare") && Input.GetButtonDown("ButtonTriangle") && col.gameObject.tag == "NotePurple")
            {
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
