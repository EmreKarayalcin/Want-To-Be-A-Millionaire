using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text2 : MonoBehaviour {

    List<string> secondchoice = new List<string>() {"Second Choice" };
	// Use this for initialization
	void Start () {
        GetComponent<TextMesh>().text = secondchoice[0];	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
