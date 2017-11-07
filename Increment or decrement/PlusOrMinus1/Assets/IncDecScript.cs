using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncDecScript : MonoBehaviour {
    int CurrentNum = 50;

	// Use this for initialization
    void CurrentNumValue()
    {
        print("The current number is " + CurrentNum);
        print("Press up key to add by 1 or down key to subtract by 1");
    }
	void Start () {
        print("Hello");
        CurrentNumValue();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("up"))
        {
            CurrentNum++;
            CurrentNumValue();
        }
            
        else if (Input.GetKeyDown("down"))
        {
            CurrentNum--;
            CurrentNumValue();
        }

        else if(Input.GetKeyDown("return"))
        {
            print("The progam was terminated");
            UnityEditor.EditorApplication.isPlaying = false;
        }
	}
}
        