using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuandEndGame : MonoBehaviour {
    public GameObject Notes;
    public KeyCode pausekey;
    public bool ispaused=false;
    public GameObject Pausemenu;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(pausekey)&&ispaused==false)
        {
            Notes.SetActive(false);
            Pausemenu.SetActive(true);
            ispaused = true;
            return;
        }
        if (Input.GetKeyDown(pausekey) && ispaused == true)
        {
            Notes.SetActive(true);
            Pausemenu.SetActive(false);
            ispaused = false;
            return;
        }
    }
}
