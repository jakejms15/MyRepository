using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        print(Input.mousePosition.x);

        Vector3 newPaddlePos = new Vector3(Input.mousePosition.x, gameObject.transform.position.y, gameObject.transform.position.z);
        gameObject.transform.position = newPaddlePos;
	}
}
