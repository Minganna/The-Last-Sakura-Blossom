using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SorMplayers : MonoBehaviour {
   static public bool howmanyplayer = true;
    static public bool bosslife = false;
    public bool bossy = false;
    public bool Ciao = false;
    // Use this for initialization
    void Start () {
        Ciao = howmanyplayer;
        bossy = bosslife;
	}
	
	// Update is called once per frame
	void Update () {
        howmanyplayer = Ciao;
        bosslife = bossy;
	}
}
