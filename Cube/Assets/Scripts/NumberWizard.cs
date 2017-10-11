using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    //Global Variables
    int max = 1000;
    int min = 1;
    int guess = 500;

    void StartGame() {
        //Local Variables
        max = 1000;
        min = 1;
        guess = 500;

        //Print and Debug.Log is the same thing. These will print the following data in the console.
        print("Welcome to number wizard");
        Debug.Log("Please think of an number from" + min + "and" + max);
        NextGuess();
    }

    void NextGuess() {
        print("Is the number bigger or smaller than " + guess + " ?");
        print("UP: Bigger DOWN: Smaller RETURN: Equal");
    }

	// Use this for initialization
	void Start () {
        StartGame();
	}
	
	// Update is called once per frame
	void Update () {


        //If statement. When the up arrow is pressed "Up Arrow Pressed" message is displayed in the console.
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Up Arrow Pressed");
            min = guess;
            guess = (min + max) / 2;
            NextGuess();
        }

        else

        //If statement. When the down arrow is pressed "Up Arrow Pressed" message is displayed in the console.
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down Arrow Pressed"); 
            max = guess;
            guess = (min + max) / 2;
            print("Is the number bigger or smaller than " + guess + " ?");
            print("UP: Bigger DOWN: Smaller RETURN: Equal");
        }

        else

            if (Input.GetKeyDown(KeyCode.Return)) 
            {
                print("YOU WON!! WOOOHOOO");
                print("Play Again ? Press : P / Quit ? Press : Q");
            }
            else

                if (Input.GetKeyDown(KeyCode.P))
                {
                    StartGame();
                }
                else
                    if (Input.GetKeyDown(KeyCode.Q))
                    {
                        UnityEditor.EditorApplication.isPlaying = false;
                        print("GoodBye");
                    }
                


	}
}
