using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float mousePosInBlocks = (Input.mousePosition.x / Screen.width * 14f) - 7f;

        //Vectior3 saves any point in (x,y,z)
        Vector3 paddlePosition = new Vector3(0.5f, this.transform.position.y, 0);

        paddlePosition.x = mousePosInBlocks;

        //sets the position of the paddle (this) to
        //the paddlePosition
        this.transform.position = paddlePosition;

	}
}
