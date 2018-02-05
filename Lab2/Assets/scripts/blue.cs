using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blue : MonoBehaviour {

    Vector2 originalPos = new Vector2(0.38f, 1.97f);

    public bool clicked = false;

    public GameObject shrek;
    public GameObject shrek_yellow;
    public GameObject shrek_red;
    public GameObject shrek_blue;

	// Use this for initialization
	void Start () {


        //shrek.GetComponent<Rigidbody2D>().gravityScale = 0;
        //shrek_yellow.GetComponent<Rigidbody2D>().gravityScale = 0;
        //shrek_red.GetComponent<Rigidbody2D>().gravityScale = 0;
        //shrek_blue.GetComponent<Rigidbody2D>().gravityScale = 0;

	}
	
	// Update is called once per frame
	void Update () {
        //if (clicked)
        //{
        //    shrek.GetComponent<Rigidbody2D>().gravityScale = 10;
        //    shrek_yellow.GetComponent<Rigidbody2D>().gravityScale = 10;
        //    shrek_red.GetComponent<Rigidbody2D>().gravityScale = 10;
        //    shrek_blue.GetComponent<Rigidbody2D>().gravityScale = 0;
        //}
	}



    private void OnMouseUp()
    {

        shrek.SetActive(false);
        shrek_yellow.SetActive(false);
        shrek_red.SetActive(false);
        shrek_blue.SetActive(true);
 
        //clicked = true;
        //shrek_yellow.SetActive();
        //shrek_blue.GetComponent<Rigidbody2D>().gravityScale = 0;
        ////shrek.transform.position = originalPos;
        ////shrek_yellow.transform.position = originalPos;
        ////shrek_red.transform.position = originalPos;
        //shrek_blue.transform.position = originalPos;


        ////shrek.GetComponent<Rigidbody2D>().gravityScale = 0;
        ////shrek_yellow.GetComponent<Rigidbody2D>().gravityScale = 0;
        ////shrek_red.GetComponent<Rigidbody2D>().gravityScale = 0;

        ////shrek.GetComponent<Rigidbody2D>().gravityScale = 10;
        ////shrek_yellow.GetComponent<Rigidbody2D>().gravityScale = 10;
        ////shrek_red.GetComponent<Rigidbody2D>().gravityScale = 10;
        ////shrek_blue.GetComponent<Rigidbody2D>().gravityScale = 0;

    }
}
