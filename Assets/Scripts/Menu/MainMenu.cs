using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public GameObject Samurai;
    public GameObject Ninja;
    public Animator AniSamurai;
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
        if(Input.GetKeyDown(directionalkeys[0])&&selection>=0&&selection<=1)
        {
            selection += 1;
        }
        if (Input.GetKeyDown(directionalkeys[1]) && selection >= 0 && selection <= 2)
        {
            selection -= 1;
        }

        if (selection == 0)
        {
            Samurai.SetActive(true);
            Ninja.SetActive(false);
            if (Input.GetKeyDown(Keytocontinue)&&texts[0].activeSelf)
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
           else if (Input.GetKeyDown(Keytocontinue) && texts[3].activeSelf)
                {
                Players.Ciao = false;
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
            if (Input.GetKeyDown(Keytocontinue)&& texts[1].activeSelf)
            {
                StartCoroutine(Instructions());

            }
            else if (Input.GetKeyDown(Keytocontinue) && texts[4].activeSelf)
            {
                Players.Ciao = true;
                StartCoroutine(StartGame());
            }
        }
        else if(selection==2)
        {
            Ninja.SetActive(false);
            if (Input.GetKeyDown(Keytocontinue)&&texts[2].activeSelf)
            {
                StartCoroutine(ExitGame());
                
            }
            if (Input.GetKeyDown(Keytocontinue) && texts[5].activeSelf)
            {

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
