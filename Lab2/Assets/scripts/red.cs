using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class red : MonoBehaviour {


    Vector2 originalPos = new Vector2(0.38f, 1.97f);

    Vector2 shrek_originalPos;
    Vector2 shrek_yellow_originalPos;
    Vector2 shrek_red_originalPos;
    Vector2 shrek_blue_originalPos;
 
    public GameObject shrek;
    public GameObject shrek_yellow;
    public GameObject shrek_red;
    public GameObject shrek_blue;

	// Use this for initialization
	void Start () {
        shrek.GetComponent<Rigidbody2D>().gravityScale = 0;
        shrek_yellow.GetComponent<Rigidbody2D>().gravityScale = 0;
        shrek_red.GetComponent<Rigidbody2D>().gravityScale = 0;
        shrek_blue.GetComponent<Rigidbody2D>().gravityScale = 0;



	}
	



	// Update is called once per frame
	void Update () {
		

	}


    private void OnMouseUp()
    {
        shrek.transform.position = originalPos;
        shrek_yellow.transform.position = originalPos;
        shrek_red.transform.position = originalPos;
        shrek_blue.transform.position = originalPos;


        shrek.GetComponent<Rigidbody2D>().gravityScale = 0;
        shrek_yellow.GetComponent<Rigidbody2D>().gravityScale = 0;
        shrek_red.GetComponent<Rigidbody2D>().gravityScale = 0;
        shrek_blue.GetComponent<Rigidbody2D>().gravityScale = 0;





        shrek.GetComponent<Rigidbody2D>().gravityScale = 10;
        shrek_yellow.GetComponent<Rigidbody2D>().gravityScale = 10;
        shrek_red.GetComponent<Rigidbody2D>().gravityScale = 0;
        shrek_blue.GetComponent<Rigidbody2D>().gravityScale = 10;

    }
}
