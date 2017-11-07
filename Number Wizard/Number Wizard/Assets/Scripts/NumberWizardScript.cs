using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizardScript : MonoBehaviour {

    int min = 1;
    int max = 1000;
    int guess = 500;

    void StartGame()
    {
        min = 1;
        max = 1000;

        print("Welcome to Number Wizard");
        print("Pick a number between 1 and 1000");

        NextGuess();
    }

    // Use this for initialization
    void Start() {
        StartGame();
    }


    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown("up"))
        {
            print("UP key was pressed");
            min = guess + 1;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("DOWN key was pressed");
            max = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown("return")) 
        {
            print("ENTER key was pressed");
            print("You won!");
            StartGame();
            
        }
    }

    void NextGuess()
    {
        /*
         This method always generates a new guess and prints it in the console window
         * */

        //guess = (min + max) / 2;

        System.Random rand = new System.Random(); //Created the copy of the random class so that I can use its methods.
        guess = rand.Next(min, (max+1)); // Next is a method which generates a random value between the specified range.

        print("Is the number higher, lower or equal to " + guess + "?");
        print("Higher: UP, Lower: DOWN, Equal: ENTER");

    }
}
