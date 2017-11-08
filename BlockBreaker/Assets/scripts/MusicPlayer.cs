using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    //static variables are available across all instance of a class
    static MusicPlayer myMusicPlayer = null;



    void Awake() {

        //if MusicPlayer already exists
        if (myMusicPlayer != null)
        {
            Debug.Log("Destroying " + this.gameObject.GetInstanceID().ToString());
            //destroy the new MusicPlayer
            Destroy(this.gameObject);
        }

        else //if MusicPlayer is null 
        {
            myMusicPlayer = this;

            //this.gameObject = the gameObject attached to this script.
            //DontDestroyOnLoad = dont destroy this gameObject
            //when loading a new scene
            GameObject.DontDestroyOnLoad(this.gameObject);
        }

        
    }

	// Use this for initialization
	void Start () {

      

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
