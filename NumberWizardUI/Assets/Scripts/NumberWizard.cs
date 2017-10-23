using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

    //Global Variables
    int max = 1000;
    int min = 1;
    int guess = 500;
    int maxNumberOfGuesses = 10;

    public Text guessText;

    public void GuessHigher()
        {
            min = guess;
            NextGuess();
        }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

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
        guess = Random.Range(min, max + 1);
        //converts guess to String and updates text
        guessText.text = guess.ToString();
        maxNumberOfGuesses --;
        
        if (maxNumberOfGuesses == 0)
        {
            SceneManager.LoadScene("Win");
        }
    }

	// Use this for initialization
	void Start () {
        StartGame();
	}
	
    
	}

