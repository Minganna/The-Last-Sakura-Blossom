using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public GameObject Samurai;
    public GameObject Ninja;
    public GameObject Door;
    public Animator AniSamurai;
    public Animator AniNinja;
    public Animator AniDoor;
    public KeyCode Keytocontinue;
    public KeyCode[] directionalkeys;
    public int selection;
    public GameObject[] texts;
   public SorMplayers Players;
   

	// Use this for initialization
	void Start () {
        Players.GetComponent<SorMplayers>();
       
        
	}
	
	// Update is called once per frame
	void Update () {

        if (!texts[7].activeSelf)
        {

            if (Input.GetKeyDown(directionalkeys[0]) && selection >= 0 && selection <= 1)
            {
                selection += 1;
            }
            if (Input.GetKeyDown(directionalkeys[1]) && selection >= 0 && selection <= 2)
            {
                selection -= 1;
            }
        }
        else if(texts[7].activeSelf)
        {
            if (Input.GetKeyDown(directionalkeys[0]) && selection >= 0 && selection < 1)
            {
                selection += 1;
            }
            if (Input.GetKeyDown(directionalkeys[1]) && selection >= 0 && selection < 2)
            {
                selection -= 1;
            }
        }
        if (selection == 0)
        {
            Samurai.SetActive(true);
            Ninja.SetActive(false);
            Door.SetActive(false);
            if (Input.GetButtonDown("ButtonX")&& texts[0].activeSelf||Input.GetKeyDown(Keytocontinue)&&texts[0].activeSelf)
            {
                AniSamurai.SetBool("Attack", true);
                texts[0].SetActive(false);
                texts[1].SetActive(false);
                texts[2].SetActive(false);
                texts[3].SetActive(true);
                texts[4].SetActive(true);
                texts[5].SetActive(true);
                
                return;
            }
           else if (Input.GetButtonDown("ButtonX") && texts[3].activeSelf || Input.GetKeyDown(Keytocontinue) && texts[3].activeSelf)
                {
                AniSamurai.SetBool("Attack", true);
                Players.Ciao = false;
                texts[3].SetActive(false);
                texts[4].SetActive(false);
                texts[5].SetActive(false);
                texts[6].SetActive(true);
                texts[7].SetActive(true);
            }
            else if (Input.GetButtonDown("ButtonX") && texts[6].activeSelf || Input.GetKeyDown(Keytocontinue) && texts[6].activeSelf)
            {
                AniSamurai.SetBool("Attack", true);
                Players.bossy = false;
                StartCoroutine(StartGame());
            }

            else
            {
                AniSamurai.SetBool("Attack", false);

            }
        }
        else if(selection==1)
        {
            Samurai.SetActive(false);
            Ninja.SetActive(true);
            Door.SetActive(false);
            if (Input.GetButtonDown("ButtonX") && texts[1].activeSelf || Input.GetKeyDown(Keytocontinue)&& texts[1].activeSelf)
            {
                AniNinja.SetBool("IsAttack", true);
                StartCoroutine(Instructions());

            }
            else if (Input.GetButtonDown("ButtonX") && texts[4].activeSelf || Input.GetKeyDown(Keytocontinue) && texts[4].activeSelf)
            {
                AniNinja.SetBool("IsAttack", true);
                Players.Ciao = true;
                texts[3].SetActive(false);
                texts[4].SetActive(false);
                texts[5].SetActive(false);
                texts[6].SetActive(true);
                texts[7].SetActive(true);
               
            }
            else if (Input.GetButtonDown("ButtonX") && texts[7].activeSelf || Input.GetKeyDown(Keytocontinue) && texts[7].activeSelf)
            {
                AniNinja.SetBool("IsAttack", true);
                Players.bossy = true;
       
                StartCoroutine(StartGame());
            }
            else
            {
                 
                    AniNinja.SetBool("IsAttack", false);
            }
        }
        else if(selection==2)
        {
            Ninja.SetActive(false);
            Door.SetActive(true);
            if (Input.GetButtonDown("ButtonX") && texts[2].activeSelf || Input.GetKeyDown(Keytocontinue)&&texts[2].activeSelf)
            {
                AniDoor.SetBool("IsOpen", true);
                StartCoroutine(ExitGame());
                
            }
            if (Input.GetButtonDown("ButtonX") && texts[5].activeSelf || Input.GetKeyDown(Keytocontinue) && texts[5].activeSelf)
            {
                AniDoor.SetBool("IsOpen", true);
                texts[0].SetActive(true);
                texts[1].SetActive(true);
                texts[2].SetActive(true);
                texts[3].SetActive(false);
                texts[4].SetActive(false);
                texts[5].SetActive(false);
                selection = 0;
            }
         
        }
	}

    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("SampleScene");
    }

    IEnumerator Instructions()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Instructions");
    }

    IEnumerator ExitGame()
    {
        yield return new WaitForSeconds(1f);
        Application.Quit();
    }
}
