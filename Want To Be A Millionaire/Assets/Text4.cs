using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text4 : MonoBehaviour {
    List<string> fourthchoice = new List<string>() {"Fourth Choice" };
	// Use this for initialization
	void Start () {
        GetComponent<TextMesh>().text = fourthchoice[0];	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
