using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiPlayer : MonoBehaviour {
   public SorMplayers Playersq;
    public GameObject Player2;
    public GameObject BossBar;
    public GameObject BossHP;
    public int Level;
    public GameObject Player1;
	// Use this for initialization
	void Start () {
        Playersq.GetComponent<SorMplayers>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Playersq.Ciao == false)
        {
            Player2.SetActive(false);
            if(Level==2)
            {
                Player1.SetActive(true);
            }
        }
        else if (Playersq.Ciao == true)
        {
            Player2.SetActive(true);
            if (Level == 2)
            {
                Player1.SetActive(false);
            }
        }
        if(Playersq.bossy==false)
        {
            BossBar.SetActive(true);
            BossHP.SetActive(true);
        }
        else if(Playersq.bossy==true)
        {
            BossBar.SetActive(false);
            BossHP.SetActive(false);
        }
	}

}
