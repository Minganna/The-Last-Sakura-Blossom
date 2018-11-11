using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatorLogo : MonoBehaviour {
    SpriteRenderer color;
    Color old;
    public Animator Logo;
    public AudioSource slash;

    // Use this for initialization
    void Start () {
        old = color.color;
    }

    void Awake()
    {
        color = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        Logo.SetBool("Damage", true);
        StartCoroutine(notedone());
        Destroy(col.gameObject);
        
       
    }


    IEnumerator notedone()
    {

        color.color = new Color(0, 0, 0);
        slash.Play();
        yield return new WaitForSeconds(0.2f);
        color.color = old;
        Logo.SetBool("Damage", false);
    }
}
