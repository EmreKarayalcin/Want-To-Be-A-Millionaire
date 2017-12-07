using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text3 : MonoBehaviour {
    List<string> thirdchoice = new List<string>() {"Third Choice" };
	// Use this for initialization
	void Start () {
        GetComponent<TextMesh>().text = thirdchoice[0];	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
