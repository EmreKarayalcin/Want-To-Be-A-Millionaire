using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text1 : MonoBehaviour {

    List<string> firstchoice = new List<string>() {"First Choice" };
    
    
    
    
    // Use this for initialization
	void Start () {
        GetComponent<TextMesh>().text = firstchoice[0];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
