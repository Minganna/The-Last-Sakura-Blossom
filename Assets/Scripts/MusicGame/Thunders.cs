using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thunders : MonoBehaviour {
    public GameObject thunder1;
    public GameObject thunder2;
    public SorMplayers sm;
    public PauseMenuandEndGame Paused;
    public bool start=false;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (start == false)
        {
            start = true;
            StartCoroutine(ThunderAppear());
            return;
        }
    }
    IEnumerator ThunderAppear()
    {
        if (Paused.ispaused == false)
        {
            
                yield return new WaitForSeconds(1.8f);
                thunder1.SetActive(true);
                thunder2.SetActive(false);
                yield return new WaitForSeconds(1.8f);
            thunder2.SetActive(false);
            thunder1.SetActive(false);
            yield return new WaitForSeconds(1.8f);
            thunder2.SetActive(true);
                thunder1.SetActive(false);
            yield return new WaitForSeconds(1.8f);
            thunder2.SetActive(false);
            thunder1.SetActive(false);


            start = false;
          

        }
    }
}
