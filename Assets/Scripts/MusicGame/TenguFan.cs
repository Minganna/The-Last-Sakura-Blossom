using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TenguFan : MonoBehaviour {

    public GameObject Fan1;
    public GameObject Fan2;
    public SorMplayers sm;
    public PauseMenuandEndGame Paused;
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
  
        StartCoroutine(FanAppear());
       
    }

    IEnumerator FanAppear()
    {
        if (Paused.ispaused == false)
        {
            if (sm.Ciao == true)
            {
                yield return new WaitForSeconds(10f);
                Fan1.SetActive(true);
                Fan2.SetActive(true);
                yield return new WaitForSeconds(20f);
                Fan1.SetActive(false);
                Fan2.SetActive(false);
                yield return new WaitForSeconds(10f);
            }
            if (sm.Ciao == false)
            {
                yield return new WaitForSeconds(10f);
                Fan1.SetActive(true);
                yield return new WaitForSeconds(20f);
                Fan1.SetActive(false);
            }
            
        }
    }

}
