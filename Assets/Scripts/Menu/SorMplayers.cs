using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SorMplayers : MonoBehaviour {
   static public bool howmanyplayer = false;
    public bool Ciao = false;
    // Use this for initialization
    void Start () {
        Ciao = howmanyplayer;
	}
	
	// Update is called once per frame
	void Update () {
        howmanyplayer = Ciao;
	}
}
