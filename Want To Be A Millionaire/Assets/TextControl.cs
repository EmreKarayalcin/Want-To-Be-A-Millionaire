using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextControl : MonoBehaviour {

    List<string> questions = new List<string>() { "This is the first question", "This is second question", "This is third question", "This is fourth question", "This is fifth question" };

    List<string> correctAnswer = new List<string>() { "4", "1", "2", "4", "3" };

    public static string selectedAnswer;




    public static int randomquestion=-1;
    
    
    
    
    // Use this for initialization
	void Start () {
        //GetComponent<TextMesh>().text = questions[0];	
	}

    // Update is called once per frame
    void Update() {

        if (randomquestion == -1)
        {
            randomquestion = Random.Range(0, 5);
            
        }
        if (randomquestion > -1)
        {
             GetComponent<TextMesh>().text = questions[randomquestion];
        }
        //Debug.Log(questions[randomquestion]);    
    }
    }
