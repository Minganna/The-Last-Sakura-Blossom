using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Joypadnumber : MonoBehaviour {

    public Text NumberofJoy;
    public Animator Ps4;
    public Animator KeyBoard;
    public KeyCode key;
    public int what;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
     
       
            string[] names = Input.GetJoystickNames();
            Debug.Log("Controllers Connected: " + names.Length);
        NumberofJoy.text = "Joypad Connected: " + names.Length;
        if (Input.GetButtonDown("ButtonX"))
        {
            what = 0;
            Ps4.SetBool("IsChoosed", true);
            StartCoroutine(HowMAnyPlayers());
            

        }
        if (Input.GetKeyDown(key))
        {
            what = 2;
            KeyBoard.SetBool("IsChoosed", true);
            StartCoroutine(HowMAnyPlayers());

        }


    }
    IEnumerator HowMAnyPlayers()
    {
        if (what == 0)
        {
            yield return new WaitForSeconds(1f);
            Ps4.SetBool("IsChoosed", false);
            SceneManager.LoadScene("MainMenu");
        }
        if (what == 2)
        {
            yield return new WaitForSeconds(1f);
            KeyBoard.SetBool("IsChoosed", false);
            SceneManager.LoadScene("MainMenu");
        }

    }
}
