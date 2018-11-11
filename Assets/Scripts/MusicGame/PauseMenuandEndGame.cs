using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenuandEndGame : MonoBehaviour {
    public GameObject Notes;
    public KeyCode pausekey;
    public bool ispaused=false;
    public GameObject Pausemenu;
    public BossDamager Bosshealth;
    public NoteDestroyer Player;
    public GameObject Boss;
    public GameObject Players;
    public GameObject PauseText;
    public GameObject YouWon;
    public string name;
    public Text Score;
    public GameObject lastNote;
    public GameObject YouDied;
    public GameObject Roko;
    public GameObject Game;
    public activator KandL;
    public Player2 AandS;
    


	// Use this for initialization
	void Start () {
  
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(pausekey)||Input.GetButtonDown("PadStart")&&ispaused==false)
        {
            Notes.SetActive(false);
            Pausemenu.SetActive(true);
            ispaused = true;
            return;
        }
        if (Input.GetKeyDown(pausekey) || Input.GetButtonDown("PadStart") && ispaused == true)
        {
            Notes.SetActive(true);
            Pausemenu.SetActive(false);
            ispaused = false;
            return;
        }

        if(Bosshealth.Bosshealth<=0||lastNote==null)
        {
            Notes.SetActive(false);
            Pausemenu.SetActive(true);
            PauseText.SetActive(false);
            YouWon.SetActive(true);
            ispaused = true;
            StartCoroutine(WaitToPress());
          
        }
       if( Player.health <= 0)
        {
            YouDied.SetActive(true);
            Game.SetActive(false);
            Roko.SetActive(true);
            Notes.SetActive(false);
            StartCoroutine(WaitToPress2());

        }

    }
    IEnumerator WaitToPress()
    {
        yield return new WaitForSeconds(1f);
        if (Input.GetButtonDown("ButtonCircle") && ispaused == true || Input.GetButtonDown("ButtonTriangle") && ispaused == true|| Input.GetKeyDown(KandL.keyBlue) && ispaused == true||Input.GetKeyDown(KandL.keyRed) && ispaused == true || Input.GetKeyDown(AandS.keyBlue) && ispaused == true)
        {
            SceneManager.LoadScene("MainMenu");
        }

        if (Input.GetButtonDown("ButtonX") && ispaused == true || Input.GetButtonDown("ButtonSquare") && ispaused == true || Input.GetKeyDown(KandL.keyRed) && ispaused == true || Input.GetKeyDown(AandS.keyRed) && ispaused == true)
        {
            SceneManager.LoadScene("TenguCave");
        }
    }

    IEnumerator WaitToPress2()
    {
        yield return new WaitForSeconds(1f);
        if (Input.GetButtonDown("ButtonCircle")  || Input.GetButtonDown("ButtonTriangle") || Input.GetKeyDown(KandL.keyBlue)  || Input.GetKeyDown(AandS.keyBlue))
        {
            SceneManager.LoadScene("MainMenu");
        }

        if (Input.GetButtonDown("ButtonX")  || Input.GetButtonDown("ButtonSquare") || Input.GetKeyDown(KandL.keyRed)  || Input.GetKeyDown(AandS.keyRed) )
            SceneManager.LoadScene("SampleScene");
        }
    }

