using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoAdieu : MonoBehaviour {

    public GameObject LastNote;
    public GameObject EverythingaboutLogo;
    public GameObject JoypadSelection;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(LastNote==null)
        {
            StartCoroutine(Adieu());
        }
	}

    IEnumerator Adieu()
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(EverythingaboutLogo.gameObject);
        JoypadSelection.SetActive(true);
    }
}
