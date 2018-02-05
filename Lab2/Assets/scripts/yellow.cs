using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellow : MonoBehaviour {

    Vector2 originalPos = new Vector2(0.38f, 1.97f);

    public GameObject shrek;
    public GameObject shrek_yellow;
    public GameObject shrek_red;
    public GameObject shrek_blue;

	// Use this for initialization
	void Start () {
        shrek.transform.position = originalPos;
        shrek_yellow.transform.position = originalPos;
        shrek_red.transform.position = originalPos;
        shrek_blue.transform.position = originalPos;

	}
	
	// Update is called once per frame
	void Update () {
   
	}
 
    private void OnMouseUp()
    {
        shrek.SetActive(false);
        shrek_yellow.SetActive(true);
        shrek_red.SetActive(false);
        shrek_blue.SetActive(false);
             
    }
}
