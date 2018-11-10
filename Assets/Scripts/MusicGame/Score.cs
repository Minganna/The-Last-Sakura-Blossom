using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public Text Scoreg;
    public Text Comment;
    public NoteDestroyer actualscore;
	// Use this for initialization
	void Start () {
        Scoreg.text = actualscore.health.ToString();
        if(actualscore.health<=10)
        {
            Comment.text = "That was close";
        }
        if (actualscore.health > 10&& actualscore.health <= 40)
        {
            Comment.text = "Good Job";
        }

        if (actualscore.health > 40 && actualscore.health < 50)
        {
            Comment.text = "Almost perfect";
        }
        if (actualscore.health == 50)
        {
            Comment.text = "Perfect";
        }

    }
	
	// Update is called once per frame
	void Update () {
        Scoreg.text = actualscore.health.ToString();
        if (actualscore.health < 10)
        {
            Comment.text = "That was close";
        }
        if (actualscore.health > 10 && actualscore.health < 40)
        {
            Comment.text = "Good Job";
        }

        if (actualscore.health > 40 && actualscore.health < 50)
        {
            Comment.text = "Almost perfect";
        }
        if (actualscore.health == 50)
        {
            Comment.text = "Perfect";
        }

    }
}
