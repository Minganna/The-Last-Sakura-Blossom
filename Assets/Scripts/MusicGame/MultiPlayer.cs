using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiPlayer : MonoBehaviour {
   public SorMplayers Playersq;
    public GameObject Player2;
	// Use this for initialization
	void Start () {
        Playersq.GetComponent<SorMplayers>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Playersq.Ciao == false)
        {
            Player2.SetActive(false);
        }
        else
            Player2.SetActive(true);
	}
}
