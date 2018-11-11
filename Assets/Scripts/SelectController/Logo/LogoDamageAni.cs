using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoDamageAni : MonoBehaviour {

    public GameObject Notes;
    public Animator Logo;

	// Use this for initialization
	void Start () {
    
    }
	
	// Update is called once per frame
	void Update () {
		if(this.Logo.GetCurrentAnimatorStateInfo(0).IsName("LogoIdle"))
        {
            Notes.SetActive(true);
        }
	}
}
