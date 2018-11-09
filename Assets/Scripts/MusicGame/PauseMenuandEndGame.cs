using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuandEndGame : MonoBehaviour {
    public GameObject Notes;
    public KeyCode pausekey;
    public bool ispaused=false;
    public GameObject Pausemenu;
    public BossDamager Bosshealth;
    public NoteDestroyer Player;
    public GameObject Boss;
    public GameObject Players;
    

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

        if(Bosshealth.Bosshealth<=0||Player.health<=0)
        {
            SceneManager.LoadScene("MainMenu");
        }

    }
}
